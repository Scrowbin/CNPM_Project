using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using static System.ComponentModel.Design.ObjectSelectorEditor;
namespace GUI
{
    public partial class frmNotify : Form
    {
        private NotifyBUS notifyBUS;
        public frmNotify(string db)
        {
            InitializeComponent();
            notifyBUS = new NotifyBUS(db);
            LoadTenants();
        }
        private void LoadTenants()
        {
            comboBox1.Items.Add("Tất cả");
            List<CanHo> canHos = notifyBUS.GetCanHoWithTenants();
            foreach (CanHo canho in canHos)
            {
                comboBox1.Items.Add(canho);
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox2.SelectedItem.ToString();

            switch (selected)
            {
                case "Nhắc nhở thanh toán tiền":
                    richTextBox1.Text = "Kính gửi quý khách, đây là lời nhắc thanh toán tiền thuê nhà tháng này. Vui lòng hoàn tất trước ngày quy định.";
                    break;

                case "Thông báo trễ hạn đóng tiền":
                    richTextBox1.Text = "Quý khách đã trễ hạn đóng tiền thuê nhà. Vui lòng thanh toán ngay để tránh phát sinh thêm phí phạt.";
                    break;

                case "Nhắc nhở đóng cửa":
                    richTextBox1.Text = "Quý khách vui lòng nhớ đóng cửa chính và cửa sổ khi rời khỏi căn hộ để đảm bảo an toàn.";
                    break;

                case "Thông báo tiền phạt trễ hạn":
                    richTextBox1.Text = "Thông báo: Do việc trễ hạn thanh toán, quý khách bị tính tiền phạt theo quy định trong hợp đồng.";
                    break;

                default:
                    richTextBox1.Clear();
                    break;
            }
        }
    }
}
