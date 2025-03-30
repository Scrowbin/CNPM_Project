namespace GUI
{
    public partial class frm : Form
    {
        private UserControl? currentControl = null;

        public frm()
        { 
            InitializeComponent();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            LoadControl(new ucLogin()); // Ensure ucLogin loads on startup
            //new ucLogin();
        }

        private void LoadControl(UserControl newControl)
        {
            if (currentControl != null)
            {
                panelContainer.Controls.Remove(currentControl);
                currentControl.Dispose();
            }

            currentControl = newControl;
            
            // Register event if necessary
            if (newControl is ucLogin signIn)
            {
                signIn.RequestLoadControl += LoadControl;  // Allow ucLogin to switch controls
            }
            else if (newControl is ucConfig config)
            {
                config.RequestLoadControl += LoadControl; // Allow ucConfig to switch back to ucLogin
            }
           
            currentControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(currentControl);
        }
    }
}
