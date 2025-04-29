using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using DTO;
using BUS;


namespace GUI
{
    public partial class frmLogin : Form
    {
        public event Action<UserControl>? RequestLoadControl;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLoginCustomer_Click(object sender, EventArgs e)
        {
            if (txtEmailCustomer.Text == "")
            {
                MessageBox.Show("Hãy nhập vào Email");
            }
            else if (txtPassCustomer.Text == "")
            {
                MessageBox.Show("Hãy nhập vào mật khẩu");
            }
            else
            {
                string email = txtEmailCustomer.Text;
                string pass = EncodeSHA256(txtPassCustomer.Text);

                TaiKhoan taiKhoan = new TaiKhoan
                {
                    Email = email,
                    MatKhau = pass
                };
                string connStr = Config.GetConnectionString();
                TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS(connStr);
                int check = taiKhoanBUS.KiemTra(taiKhoan);
                if (check == 0)
                {
                    MessageBox.Show("Email hoặc mật khẩu không chính xác");
                }
                else
                {
                    this.Hide(); // Ẩn frmLogin
                    frm newForm = new frm();
                    newForm.ShowDialog(); // Mở frm mới
                    this.Close(); // Đóng frmLogin sau khi frm mới đóng
                }
            }

        }

        // hàm mã hóa mật khẩu bằng SHA256
        public string EncodeSHA256(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder hash = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hash.Append(b.ToString("x2"));
                }

                return hash.ToString();
            }
        }

        private void btnForgotPassCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được triển khai");
        }
    }
}