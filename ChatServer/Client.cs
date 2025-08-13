using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ChatServer
{
    internal class Client
    {
        //public event EventHandler<EventArgs> ClientConnected;
        public event Action<string> MsgReceived;

        StreamReader streamReader;
        StreamWriter streamWriter;
        TcpClient tcpClient;
        public string Username { get; }
        int Id;
        public Client(TcpClient tcpClient)
        {
            this.tcpClient = tcpClient;

            NetworkStream networkStream = tcpClient.GetStream();

            streamReader = new StreamReader(networkStream);
            streamWriter = new StreamWriter(networkStream);
            streamWriter.AutoFlush = true;

            
            dynamic userData = JsonConvert.DeserializeObject<dynamic>(streamReader.ReadLine());

            Username = userData.Username;

            streamWriter.WriteLine($"{Username}:Connected Successfully");

            //streamWriter.Flush(); // Flush for one time

            ReadMsgs();
        }

        public async void ReadMsgs()
        {
            while (true)
            {
                string msg = await streamReader.ReadLineAsync() ?? "";
              
                MsgReceived.Invoke(msg);
            }
        }

        public void SendMsg(string msg)
        {
            streamWriter.WriteLine(msg);
        }
    }
}
