using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{

    public partial class ChatClientForm : Form
    {
        StreamReader streamReader;
        StreamWriter streamWriter;
        TcpClient tcpClient;
        Person person;
        string[]? clientsUsernames;

        public ChatClientForm()
        {
            InitializeComponent();

            GetUserDataForm getUserDataForm = new GetUserDataForm();
            getUserDataForm.UserDataOkay += GetUserDataForm_UserDataOkay;
            getUserDataForm.ShowDialog();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void GetUserDataForm_UserDataOkay(string username)
        {
            if (username == null || username == "") this.Close();
            person = new Person(username);
        }

        private async Task Connect()
        {
            //TcpClient tcpClient = new TcpClient("127.0.0.1", 49300);
            tcpClient = new TcpClient();
            tcpClient.Connect("127.0.0.1", 49300);

            NetworkStream networkStream = tcpClient.GetStream();

            streamReader = new StreamReader(networkStream);
            streamWriter = new StreamWriter(networkStream);
            streamWriter.AutoFlush = true;

            string userData = JsonConvert.SerializeObject(person);
            streamWriter.WriteLine(userData);

            lbConnecting.Text = streamReader.ReadLine();

            while (true)
            {
                string msg = await streamReader.ReadLineAsync() ?? "";

                if(msg.Contains("#*NewClients*#"))
                {
                    clientsUsernames = null;
                    msg = msg.Substring(14);
                    clientsUsernames = msg.Split(",");
                    usernamesList.Items.Clear();
                    foreach (string client in clientsUsernames)
                    {
                        if (client == person.Username) continue;
                        usernamesList.Items.Add(client);
                    }
                }
                else
                {
                    this.txtMsgReceived.Text += $"{msg}{Environment.NewLine}";
                }

            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {

            string msg = "#*ForUsers*#";
            bool flag = false;
            for(int i = 0;i < usernamesList.CheckedItems.Count;i++)
            {
                msg += usernamesList.CheckedItems[i]?.ToString();
                if (i < usernamesList.CheckedItems.Count - 1) msg += ",";
                else msg += "#";
                    flag = true;
            }
            if (flag)
                streamWriter.WriteLine(msg + txtMsg.Text);
            else
                streamWriter.WriteLine(txtMsg.Text);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
