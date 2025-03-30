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
    public partial class ucConfig : UserControl
    {
        public event Action<UserControl>? RequestLoadControl;
        public ucConfig()
        {
            InitializeComponent();
        }
        private void ucConfig_Load(object sender, EventArgs e)
        {
            if (ckWindows.Checked)
            {
                txtUID.ReadOnly = true;
                txtPassword.ReadOnly = true;
            }
            else
            {
                txtUID.ReadOnly = false;
                txtPassword.ReadOnly = false;
            }
        }
        private void ckW_CheckedChanged(object sender, EventArgs e)
        {
            if (ckWindows.Checked == true)
            {
                txtUID.ReadOnly = true;
                txtPassword.ReadOnly = true;
            }
            else
            {
                txtUID.ReadOnly = false;
                txtPassword.ReadOnly = false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("config.txt");
            if (ckWindows.Checked)
            {
                sw.WriteLine("windows");
                sw.WriteLine(txtServer.Text);
                sw.WriteLine(txtDatabase.Text);
            }
            else
            {
                sw.WriteLine("sql");
                sw.WriteLine(txtServer.Text);
                sw.WriteLine(txtDatabase.Text);
                sw.WriteLine(txtUID.Text);
                sw.WriteLine(txtPassword.Text);
            }
            sw.Close();

            RequestLoadControl?.Invoke(new ucLogin());
        }
    }
}
