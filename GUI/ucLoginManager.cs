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
        private void ucLoginManager_Load(object sender, EventArgs e)
        {

        }

        private void btnLoginManager_Click(object sender, EventArgs e)
        {
            RequestLoadControl?.Invoke(new HomePageAdmin());
        }
    }
}
