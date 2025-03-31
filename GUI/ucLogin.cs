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
        public event Action<UserControl>? RequestLoadControl; // Delegate for switching controls

        public ucLogin()
        {
            InitializeComponent();
        }

        private void ucLogin_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.txt");

            if (File.Exists(path))
            {
                using StreamReader rd = new StreamReader(path);
                string? s = rd.ReadLine();

                if (s == "windows")
                {
                    Program.authen = "windows";
                    Program.server = rd.ReadLine();
                    Program.db = rd.ReadLine();
                    MessageBox.Show($"Kết nối thành công đến {Program.server}, {Program.db}");

                    RequestLoadControl?.Invoke(new ucSelectRole());  // Switch to next control
                }
                else
                {
                    Program.authen = "sql";
                    Program.server = rd.ReadLine();
                    Program.db = rd.ReadLine();
                    Program.uid = rd.ReadLine();
                    Program.pw = rd.ReadLine();

                    RequestLoadControl?.Invoke(new ucSelectRole());  // Switch to next control
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu Config, thiết lập...");
                RequestLoadControl?.Invoke(new ucConfig());  // Switch to config screen
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = Program.authen == "windows"
                    ? $"Data Source={Program.server};Initial Catalog={Program.db};Integrated Security=True;TrustServerCertificate=True"
                    : $"Data Source={Program.server};Initial Catalog={Program.db};User ID={Program.uid};Password={Program.pw};TrustServerCertificate=True";

                using SqlConnection cn = new SqlConnection(connectionString);
                cn.Open();

                RequestLoadControl?.Invoke(new HomePageAdmin()); // Switch to HomePageAdmin
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
