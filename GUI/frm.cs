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
            LoadControl(new ucLogin()); // Start with Login page
        }
        private void ShowPanelTop()
        {
            panel1.Visible = true;
            panel1.Height = 30; // Adjust height
            panelContainer.Dock = DockStyle.Fill;
        }

        private void LoadControl(UserControl newControl)
        {
            if (currentControl != null)
            {
                panelContainer.Controls.Remove(currentControl);
                currentControl.Dispose();
            }

            currentControl = newControl;

            // Register event for switching controls
            if (newControl is ucLogin loginControl)
                loginControl.RequestLoadControl += LoadControl;
            else if (newControl is ucConfig configControl)
                configControl.RequestLoadControl += LoadControl;
            else if (newControl is ucSelectRole selectRoleControl)
                selectRoleControl.RequestLoadControl += LoadControl;
            else if (newControl is ucLoginManager loginManager)
                loginManager.RequestLoadControl += LoadControl;
            else if (newControl is ucLoginCustomer loginCustomer)
                loginCustomer.RequestLoadControl += LoadControl;
            else if (newControl is HomePageAdmin homeAdmin)
                homeAdmin.RequestLoadControl += LoadControl;
            else if (newControl is HomePageUser homePageUser)
                homePageUser.RequestLoadControl += LoadControl;

            currentControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(currentControl);
            if (newControl is HomePageUser || newControl is HomePageAdmin)
                ShowPanelTop();
                
        }
    }

}
