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
    public partial class ucSelectRole : UserControl
    {
        public event Action<UserControl>? RequestLoadControl;
        public ucSelectRole()
        {
            InitializeComponent();
        }

        private void ucSelectRole_Load(object sender, EventArgs e)
        {
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            RequestLoadControl?.Invoke(new ucLoginManager());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            RequestLoadControl?.Invoke(new ucLoginCustomer());
        }
    }
}
