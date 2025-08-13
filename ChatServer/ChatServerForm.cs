using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class ChatServerForm : Form
    {
        TcpListener tcpListener;
        List<Client> clients;
        List<string> clientsUsernames;
        public ChatServerForm()
        {
            InitializeComponent();
            clients = new List<Client>();
            clientsUsernames = new List<string>();
        }

        private void StartServerBtn_Click(object sender, EventArgs e)
        {
            Start();
        }

        private async void Start()
        {
            //IPAddress ip = new IPAddress(new byte[] { 127, 0, 0, 1 });
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            //IPAddress ip = IPAddress.Parse("localhost");
            tcpListener = new TcpListener(ip, 49300);

            tcpListener.Start();

            while (true)
            {
                TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();
                //MessageBox.Show("Client Connected");
                Client client = new Client(tcpClient);

                client.MsgReceived += Client_MsgReceived;

                clients.Add(client);

                clientsUsernames.Add(client.Username);

                usernamesList.Items.Add(client.Username);

                string usernames = string.Join(",", clientsUsernames);

                foreach (Client clt in clients)
                {
                    clt.SendMsg("#*NewClients*#" + usernames);
                }
            }
        }

        private void Client_MsgReceived(string msg)
        {
            if(msg.Contains("#*ForUsers*#"))
            {
                msg = msg.Substring(12);
                string txt = msg.Split("#")[1];
                string[] names = msg.Split("#")[0].Split(",");
                foreach(Client clt in clients)
                {
                    if(names.Contains(clt.Username))
                    {
                        clt.SendMsg(txt);
                    }
                }
            } else
                txtMsgReceived.Text += $"{msg}{Environment.NewLine}";
        }

        private void SendAllBtn_Click(object sender, EventArgs e)
        {
            foreach (Client client in clients)
            {
                client.SendMsg(txtMsg.Text);
            }
        }

        private void SendSelected_Click(object sender, EventArgs e)
        {
            foreach(Client client in clients)
            {
                if(usernamesList.CheckedItems.Contains(client.Username))
                {
                    client.SendMsg(txtMsg.Text);
                }
            }
        }
    }
}
