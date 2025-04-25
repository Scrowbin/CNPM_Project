using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Microsoft.Identity.Client;

namespace GUI
{
    public partial class frmAccount : Form
    {
        private List<DienNuoc> Dien;
        private List<DienNuoc> Nuoc;
        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
           
        }
    }
}
