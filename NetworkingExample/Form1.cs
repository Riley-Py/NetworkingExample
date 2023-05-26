using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace NetworkingExample
{
    public partial class Form1 : Form
    {
        int hi;
        string change = "change";
        string text;
        string stringData;
        int recv;
        byte[] data = new byte[1024];
        IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("10.63.42.206"), 9050);
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Socket client;
        IPEndPoint clientep;
       

        public Form1()
        {
            InitializeComponent();

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            text = messageBox.Text;
            messageBox.Clear();

            if (serverCheck.Checked)
            {
                ServerFunc(text);

            }
            else if (clientCheck.Checked)
            {
                ClientFunc(text);
            }

        }
        private void ServerFunc(string text)
        {






           


            

            data = Encoding.UTF8.GetBytes(text);

            client.Send(data, data.Length, SocketFlags.None);

            string input;

            //while (true)
            //{
                data = new byte[1024];

                recv = client.Receive(data);

                //if (recv == 0)
                //{
                //    break;
                //}
                recieveLabel.Text += $"\n Client: {Encoding.UTF8.GetString(data, 0, recv)}";

                input = recieveLabel.Text;

                recieveLabel.Text = $"\n You: {input}";

                client.Send(Encoding.UTF8.GetBytes(input));


           // }
            //connectingLabel.Text = $"Disconnected from {clientep.Address}";

            //client.Close();

            //newsock.Close();




        }
        private void ClientFunc(string text)
        {

            int recv = server.Receive(data);

            stringData = Encoding.UTF8.GetString(data, 0, recv);

            recieveLabel.Text += stringData;

                recieveLabel.Text += $"\n You: {text}";

                server.Send(Encoding.UTF8.GetBytes(text));

                data = new byte[1024];

                recv = server.Receive(data);

                stringData = Encoding.UTF8.GetString(data, 0, recv);

                recieveLabel.Text += $"\n Server: {stringData}";
        }

        private void clientConnectButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                server.Connect(ipep);

            }
            catch (SocketException)
            {
                connectingLabel.Text = "Unable to connect";
            }
        }

        private void connectServer_Click(object sender, EventArgs e)
        {
            newsock.Bind(ipep);

            newsock.Listen(10);

            connectingLabel.Text = "Waiting for a connection...";

            Refresh();

            client = newsock.Accept();

            clientep = (IPEndPoint)client.RemoteEndPoint;

            connectingLabel.Text = $"Connected with {clientep.Address} at port {clientep.Port}";

            Refresh();



        }
    }
}
