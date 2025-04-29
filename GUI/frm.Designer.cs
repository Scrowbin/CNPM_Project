namespace GUI
{
    partial class frm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            myRentalsToolStripMenuItem = new ToolStripMenuItem();
            paymentToolStripMenuItem = new ToolStripMenuItem();
            notificationToolStripMenuItem = new ToolStripMenuItem();
            myInfoToolStripMenuItem = new ToolStripMenuItem();
            báoCáoDoanhThuToolStripMenuItem = new ToolStripMenuItem();
            tiềnĐiệnToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, myRentalsToolStripMenuItem, paymentToolStripMenuItem, notificationToolStripMenuItem, myInfoToolStripMenuItem, báoCáoDoanhThuToolStripMenuItem, tiềnĐiệnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1012, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // myRentalsToolStripMenuItem
            // 
            myRentalsToolStripMenuItem.Name = "myRentalsToolStripMenuItem";
            myRentalsToolStripMenuItem.Size = new Size(78, 20);
            myRentalsToolStripMenuItem.Text = "Các căn hộ";
            myRentalsToolStripMenuItem.Click += myRentalsToolStripMenuItem_Click;
            // 
            // paymentToolStripMenuItem
            // 
            paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            paymentToolStripMenuItem.Size = new Size(73, 20);
            paymentToolStripMenuItem.Text = "Hợp đồng";
            paymentToolStripMenuItem.Click += paymentToolStripMenuItem_Click;
            // 
            // notificationToolStripMenuItem
            // 
            notificationToolStripMenuItem.Name = "notificationToolStripMenuItem";
            notificationToolStripMenuItem.Size = new Size(129, 20);
            notificationToolStripMenuItem.Text = "Thông báo nhắc nhở";
            notificationToolStripMenuItem.Click += notificationToolStripMenuItem_Click;
            // 
            // myInfoToolStripMenuItem
            // 
            myInfoToolStripMenuItem.Name = "myInfoToolStripMenuItem";
            myInfoToolStripMenuItem.Size = new Size(58, 20);
            myInfoToolStripMenuItem.Text = "Chủ hộ";
            myInfoToolStripMenuItem.Click += myInfoToolStripMenuItem_Click;
            // 
            // báoCáoDoanhThuToolStripMenuItem
            // 
            báoCáoDoanhThuToolStripMenuItem.Name = "báoCáoDoanhThuToolStripMenuItem";
            báoCáoDoanhThuToolStripMenuItem.Size = new Size(119, 20);
            báoCáoDoanhThuToolStripMenuItem.Text = "Báo cáo doanh thu";
            báoCáoDoanhThuToolStripMenuItem.Click += báoCáoDoanhThuToolStripMenuItem_Click;
            // 
            // tiềnĐiệnToolStripMenuItem
            // 
            tiềnĐiệnToolStripMenuItem.Name = "tiềnĐiệnToolStripMenuItem";
            tiềnĐiệnToolStripMenuItem.Size = new Size(68, 20);
            tiềnĐiệnToolStripMenuItem.Text = "Tiền Điện";
            tiềnĐiệnToolStripMenuItem.Click += tiềnĐiệnToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 703);
            panel1.TabIndex = 1;
            // 
            // frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 729);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm";
            Text = "Plumeria";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem myRentalsToolStripMenuItem;
        private ToolStripMenuItem paymentToolStripMenuItem;
        private ToolStripMenuItem notificationToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem myInfoToolStripMenuItem;
        private ToolStripMenuItem báoCáoDoanhThuToolStripMenuItem;
        private ToolStripMenuItem tiềnĐiệnToolStripMenuItem;
    }
}
