using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap1
{
    public partial class Frm2 : Form
    {
        bool CheckInteger(string input)
        {
            float num;
            bool success = float.TryParse(input, out num);
            if (success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Frm2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckInteger(textBox1.Text) && CheckInteger(textBox2.Text))
            {
                int num1, num2;
                long sum = 0;
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);
                sum = num1 + num2;
                textBox3.Text = sum.ToString();
            }
            else MessageBox.Show("Đây không phải số, vui lòng kiểm tra lại ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
