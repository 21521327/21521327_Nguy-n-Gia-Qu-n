using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace lap1
{
    public partial class Frm3 : Form
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
        public Frm3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm3_Load(object sender, EventArgs e)
        {

        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void t2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public int max(int t1, int t2, int t3)
        {
            if (t1 >= t2 && t1 >= t3) return t1;
            else if (t2 >= t1 && t2 >= t3) return t2;
            else return t3;
        }

        public int min(int t1, int t2, int t3)
        {
            if (t1 <= t2 && t1 <= t3) return t1;
            else if (t2 <= t1 && t2 <= t3) return t2;
            else return t3;
        }


        private void tim_Click(object sender, EventArgs e)
        {
            if (CheckInteger(txt_number1.Text) && CheckInteger(txt_number2.Text) && CheckInteger(txt_number3.Text))
            {
                int num1, num2, num3;
                num1 = Convert.ToInt32(txt_number1.Text);
                num2 = Convert.ToInt32(txt_number2.Text);
                num3 = Convert.ToInt32(txt_number3.Text);

                int max1 = max(num1, num2, num3);
                int min1 = min(num1, num2, num3);

                txt_max.Text = max1.ToString();
                txt_min.Text = min1.ToString();
            }
            else MessageBox.Show("Đây không phải số, vui lòng kiểm tra lại ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void t_max_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_min_TextChanged(object sender, EventArgs e)
        {

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            txt_number1.Text = "";
            txt_number2.Text = "";
            txt_number3.Text = "";
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void L3_Click(object sender, EventArgs e)
        {

        }

        private void L2_Click(object sender, EventArgs e)
        {

        }
    }
}
