namespace GUI
{
    public partial class frm : Form
    {

        public frm()
        {
            InitializeComponent();
            showForm(new HomePageAdmin(this));
        }

        public void showForm(Form a)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                ctrl.Dispose();
            }
            panel1.Controls.Clear();

            a.TopLevel = false;
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            panel1.Controls.Add(a);
            a.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new HomePageAdmin(this));
        }


        private void myRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new frmRental());
        }


        private void notificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new frmNotify());
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new frmContract());
        }

        private void myInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new frmAccount());
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new frmReport());
        }

        private void tiềnĐiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new frmElectricity());
        }
    }

}