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
    public partial class Frm4 : Form
    {
        public Frm4()
        {
            InitializeComponent();
        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ket_qua_TextChanged(object sender, EventArgs e)
        {

        }

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
        public string doc_kq(int t1)
        {
            string a = "";
            switch (t1)
            {
                case 0:
                    a = "Khong";
                    break;

                case 1:
                    a = "Mot";
                    break;

                case 2:
                    a = "Hai";
                    break;

                case 3:
                    a = "Ba";
                    break;

                case 4:
                    a = "Bon";
                    break;

                case 5:
                    a = "Nam";
                    break;

                case 6:
                    a = "Sau";
                    break;


                case 7:
                    a = "Bay";
                    break;


                case 8:
                    a = "Tam";
                    break;


                case 9:
                    a = "Chin";
                    break;
            }
            return a;
        }

        public bool check(int t1)
        {
            if (0 > t1 || t1 > 9) return false;
            else return true;
        }
        private void doc_Click(object sender, EventArgs e)
        {
            if (CheckInteger(txt_number.Text))
            {
                int num;
                num = Convert.ToInt32(txt_number.Text);

                if (check(num)) txt_ket_qua.Text = doc_kq(num);
                else MessageBox.Show("Hãy nhập số tự 0 đến 9", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Đây không phải số, vui lòng kiểm tra lại ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void Frm4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            txt_number.Text = "";
            txt_ket_qua.Text = "";
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
