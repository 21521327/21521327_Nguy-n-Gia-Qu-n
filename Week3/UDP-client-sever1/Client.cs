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

namespace UDP_client_sever1
{
    public partial class Client : Form
    {
        private UdpClient udpClient;

        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            udpClient = new UdpClient();
        }

        private void udpClient_Receive(IAsyncResult ar)
        {
            try
            {
                IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] data = udpClient.EndReceive(ar, ref remoteEndPoint);
                string message = Encoding.ASCII.GetString(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            try
            {
                string message = txtMessage.Text.Trim();
                byte[] data = Encoding.ASCII.GetBytes(message);
                udpClient.Send(data, data.Length, new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8044));
                txtMessage.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
