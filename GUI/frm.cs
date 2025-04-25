namespace GUI
{
    public partial class frm : Form
    {
        Form home;

        public frm()
        {
            InitializeComponent();
            home = new HomePageAdmin();
            showForm(home);
        }

        private void showForm(Form a)
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
            showForm(home);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void myRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new frmNotify());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }

}
