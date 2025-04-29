using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public event Action<UserControl>? RequestLoadControl;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void ucLoginCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnLoginCustomer_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the login form first
            frm mainForm = new frm();
            mainForm.ShowDialog();
            this.Close(); // Optionally close the login form after the new form is done
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}