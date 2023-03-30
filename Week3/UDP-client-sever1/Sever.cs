using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace UDP_client_sever1
{
    public partial class Sever : Form
    {
        private Thread listenThread;
        private UdpClient udpClient;
        private IPEndPoint remoteEndPoint;

        public Sever()
        {
            InitializeComponent();
        }

        private void Sever_Load(object sender, EventArgs e)
        {
            remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
            bt_connect.Enabled = true;
            bt_disconnect.Enabled = false;
            udpClient = new UdpClient();
            udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, 8044));
            
        }

        private void Listen()
        {
            while (true)
                {
                    byte[] data = udpClient.Receive(ref remoteEndPoint);
                    string message = Encoding.ASCII.GetString(data);
                    AddMessage(message);
                }
        }

        private void AddMessage(string message)
        {
            if (lb_mess.InvokeRequired)
            {
                lb_mess.Invoke(new Action<string>(AddMessage),"Client: " + message);
            }
            else
            {
                lb_mess.Items.Add(message);
            }
        }


        private void bt_connect_Click(object sender, EventArgs e)
        {
            listenThread = new Thread(new ThreadStart(Listen));
            listenThread.IsBackground = true;
            listenThread.Start();
            bt_connect.Enabled = false;
            bt_disconnect.Enabled = true;
        }
        private void lb_chat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_disconnect_Click(object sender, EventArgs e)
        {
            udpClient.Close();
            listenThread.Abort();
            bt_connect.Enabled = true;
            bt_disconnect.Enabled = false;
        }
    }
}
