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
    public partial class HomePageAdmin : Form
    {
        private frm _mainForm;

        public HomePageAdmin(frm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _mainForm.showForm(new frmAccount());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            _mainForm.showForm(new frmContract());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _mainForm.showForm(new frmRental());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _mainForm.showForm(new frmNotify());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _mainForm.showForm(new frmReport());
        }
    }
}