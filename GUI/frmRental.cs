namespace GUI
{
    public partial class frmRental : Form
    {
        public frmRental()
        {
            InitializeComponent();
            showForm(new frmShort());
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            showForm(new frmShort());
            label1.Text = "CĂN HỘ NGẮN HẠN";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showForm(new frmShort());
            label1.Text = "CĂN HỘ DU LỊCH";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showForm(new frmShort());
            label1.Text = "CĂN HỘ DÀI HẠN";
        }
    }
}
