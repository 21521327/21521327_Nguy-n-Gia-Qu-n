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

    public partial class Frm5 : Form
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

        public double chuyen_doi(int num)
        {
            double num1 = 0;
            switch (cb1.SelectedIndex)
            {
                case 0:
                    num1 = num * 22.772;
                    break;

                case 1:
                    num1 = num * 28.132;
                    break;

                case 2:
                    num1 = num * 31.538;
                    break;

                case 3:
                    num1 = num * 17.286;
                    break;

                case 4:
                    num1 = num * 214;
                    break;
            }

            return num1;
        }
        public Frm5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_tien_TextChanged(object sender, EventArgs e)
        {

        }

        public string donvi()
        {
            string don_vi = "";
            switch (cb1.SelectedIndex)
            {
                case 0:
                    don_vi = "1 USD ";
                    break;

                case 1:
                    don_vi = "1 EUR";
                    break;

                case 2:
                    don_vi = "1 GBP";
                    break;

                case 3:
                    don_vi = "1 SJD";
                    break;

                case 4:
                    don_vi = "1 JPY";
                    break;
            }

            return don_vi;
        }
        private void chuyen__Click(object sender, EventArgs e)
        {
            if (CheckInteger(txt_tien.Text))
            {
                int num1 = Convert.ToInt32(txt_tien.Text);
                t_tiendoi.Text = chuyen_doi(num1).ToString();

                double num2 = chuyen_doi(num1) / num1;
                lb_Don_vi.Text = donvi() + " = " + Math.Round(num2, 3).ToString();
            }
            else MessageBox.Show("Đây không phải số, vui lòng kiểm tra lại ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void Frm5_Load(object sender, EventArgs e)
        {

        }

        private void l4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
