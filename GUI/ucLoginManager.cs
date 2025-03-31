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
    public partial class ucLoginManager : UserControl
    {
        public event Action<UserControl>? RequestLoadControl;

        public ucLoginManager()
        {
            InitializeComponent();
        }

        private void btnLoginManager_Click(object sender, EventArgs e)
        {
            if (RequestLoadControl != null)
            {
                RequestLoadControl.Invoke(new HomePageAdmin());
            }
            else
            {
                MessageBox.Show("Error: Cannot navigate to HomePageAdmin.", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
