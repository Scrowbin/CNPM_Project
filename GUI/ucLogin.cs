using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace GUI
{
    public partial class ucLogin : UserControl
    {
        private UserControl? currentControl = null;
        SqlConnection? cn;

        public event Action<UserControl>? RequestLoadControl; // Add event for parent to handle

        public ucLogin()
        {
            InitializeComponent();
            LoadControl(new ucSelectRole()); // Load the role selection on startup
        }

        private void ucLogin_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.txt");
            
            if (File.Exists(path))
            {
                StreamReader rd = new StreamReader(path);
                String? s = rd.ReadLine();

                if (s.Equals("windows"))
                {
                    Program.authen = "windows";
                    Program.server = rd.ReadLine();
                    Program.db = rd.ReadLine();
                    MessageBox.Show("Kết nối thành công đến " + Program.server + ", " + Program.db);
                    LoadControl(new ucSelectRole());

                }
                else
                {
                    Program.authen = "sql";
                    Program.server = rd.ReadLine();
                    Program.db = rd.ReadLine();
                    Program.uid = rd.ReadLine();
                    Program.pw = rd.ReadLine();
                    LoadControl(new ucSelectRole());

                }
                rd.Close();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu Config, thiết lập...");
                RequestLoadControl?.Invoke(new ucConfig()); // Gửi yêu cầu đến frmConfig để mở UserControl ucConfig
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (Program.authen == "windows")
                    sql = $"Data Source={Program.server};Initial Catalog={Program.db};Integrated Security=True;TrustServerCertificate=True";
                else
                    sql = $"Data Source={Program.server};Initial Catalog={Program.db};User ID={Program.uid};Password={Program.pw};TrustServerCertificate=True";

                cn = new SqlConnection(sql);
                cn.Open();

                RequestLoadControl?.Invoke(new HomePageAdmin());
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadControl(UserControl newControl)
        {
            if (currentControl != null)
            {
                panelContainer.Controls.Remove(currentControl);
                currentControl.Dispose();
            }

            currentControl = newControl;

            // Register RequestLoadControl event for each control
            if (newControl is ucSelectRole selectRole)
            {
                selectRole.RequestLoadControl += LoadControl;
            }
            else if (newControl is ucLoginManager loginManager)
            {
                loginManager.RequestLoadControl += LoadControl;
            }
            else if (newControl is ucLoginCustomer loginCustomer)
            {
                loginCustomer.RequestLoadControl += LoadControl;
            }

            currentControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(currentControl);
        }

        // Example method to switch to another UserControl from outside
        public void SwitchTo(UserControl nextControl)
        {
            RequestLoadControl?.Invoke(nextControl); // Trigger the event for parent control
        }
    }
}
