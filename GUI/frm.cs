namespace GUI
{
    public partial class frm : Form
    {
        Form home;

        public frm()
        {
            InitializeComponent();
            //if (Program.role == "renter")
            //{
            //    home = new HomePageUser();

            //}
            //if (Program.role == "rentee")
            //{
            //    home = new HomePageAdmin();
            //}
            //else
            //{
            //    return;
            //}
            home = new HomePageUser();
            showForm(home);
        }

        private  void showForm(Form a)
        {
            a.TopLevel = false;
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            panel1.Controls.Add(a);
            a.Show();
        }
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

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

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
