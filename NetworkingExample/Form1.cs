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
        string text;
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
            int recv;

            byte[] data = new byte[1024];

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);

            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            newsock.Bind(ipep);

            newsock.Listen(10);

            connectingLabel.Text = "Waiting for a connection...";

            Socket client = newsock.Accept();

            IPEndPoint clientep = (IPEndPoint)client.RemoteEndPoint;

            connectingLabel.Text = $"Connected with {clientep.Address} at port {clientep.Port}";

            data = Encoding.UTF8.GetBytes(text);

            client.Send(data, data.Length, SocketFlags.None);

            string input;

            while (true)
            {
                data = new byte[1024];

                recv = client.Receive(data);

                if (recv == 0)
                {
                    break;
                }
                recieveLabel.Text += $"\n Client: {Encoding.UTF8.GetString(data, 0, recv)}";

                input = recieveLabel.Text;

                recieveLabel.Text = $"\n You: {input}";

                client.Send(Encoding.UTF8.GetBytes(input));


            }
            connectingLabel.Text = $"Disconnected from {clientep.Address}";

            client.Close();

            newsock.Close();




        }
        private void ClientFunc(string text)
        {
            byte[] data = new byte[1024];

            string stringData;

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);

            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                server.Connect(ipep);

            }
            catch (SocketException)
            {
                connectingLabel.Text = "Unable to connect";
            }

            int recv = server.Receive(data);

            stringData = Encoding.UTF8.GetString(data, 0, recv);

            recieveLabel.Text += stringData;

            while (true)
            {
                if (text.ToLower() == "exit")
                {
                    break;
                }

                recieveLabel.Text += $"\n You: {text}";

                server.Send(Encoding.UTF8.GetBytes(text));

                data = new byte[1024];

                recv = server.Receive(data);

                stringData = Encoding.UTF8.GetString(data, 0, recv);

                recieveLabel.Text += $"\n Server: {stringData}";

            }
            connectingLabel.Text = "Disconnecting from server...";

            server.Shutdown(SocketShutdown.Both);

            server.Close();

            connectingLabel.Text = "Disconnected!";



        }
    }
}
