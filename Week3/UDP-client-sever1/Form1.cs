using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP_client_sever1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sever sever = new Sever();
            Client client = new Client();
            sever.Show();
            client.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btsever_Click(object sender, EventArgs e)
        {
            Sever sever = new Sever();
            sever.Show();
        }

        private void btClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }
    }
}
