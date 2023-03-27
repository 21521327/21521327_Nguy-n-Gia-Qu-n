namespace lap1
{
    public partial class LAP_1 : Form
    {
        public LAP_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm2 form2 = new Frm2();
            //form2.MdiParent = this;
            form2.Show();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void bai2_Click(object sender, EventArgs e)
        {
            Frm3 form3 = new Frm3();
            //form3.MdiParent = this;
            form3.Show();
        }

        private void dọc_so_Click(object sender, EventArgs e)
        {
            Frm4 form4 = new Frm4();
            //form4.MdiParent = this;
            form4.Show();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Frm5 form5 = new Frm5();
            //form5.MdiParent = this;
            form5.Show();
        }

        private void Frm6_Click(object sender, EventArgs e)
        {
            Frm6 form6 = new Frm6();
            //form6.MdiParent = this;
            form6.Show();
        }
    }
}