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
    public partial class Frm6 : Form
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
        public Frm6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm6_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void tA_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        public long giai_thua(int num)
        {
            long giaithua = 1;
            for (int i = 1; i <= num; i++)
                giaithua *= i;

            return giaithua;
        }

        public long tong(int num)
        {
            long sum = 0;
            for (int i = 1; i <= num; i++)
                sum += i;
            return sum;
        }

        public long tong_binh_phuong(int numa, int numb)
        {
            long sum = 0;
            for (int i = 1; i <= numb; i++)
                sum += (long)Math.Pow(numa, i);
            return sum;
        }

        private void btn__Click(object sender, EventArgs e)
        {
            if (CheckInteger(txt_A.Text) && CheckInteger(txt_B.Text))
            {
                int numa = Convert.ToInt32(txt_A.Text);
                int numb = Convert.ToInt32(txt_B.Text);
                string newLine = Environment.NewLine;

                txt_ket_qua.AcceptsReturn = true;
                txt_ket_qua.Text += "A! = " + giai_thua(numa).ToString() + " \t";
                txt_ket_qua.Text += "B! = " + giai_thua(numb).ToString();
                txt_ket_qua.Text += newLine + "S1 = " + tong(numa);
                txt_ket_qua.Text += newLine + "S1 = " + tong(numb);
                txt_ket_qua.Text += newLine + "S3 = " + tong_binh_phuong(numa, numb);
            }
            else MessageBox.Show("Đây không phải số, vui lòng kiểm tra lại ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
