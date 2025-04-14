using System.Drawing;

namespace GUI
{
    partial class HomePageUser : Form
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button5 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.156559F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.94922423F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.6953449F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.667137F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.7588158F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Controls.Add(label2, 3, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(button2, 0, 1);
            tableLayoutPanel1.Controls.Add(button5, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 2, 2);
            tableLayoutPanel1.Controls.Add(button3, 4, 0);
            tableLayoutPanel1.Controls.Add(button4, 5, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(709, 475);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Cursor = Cursors.No;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(283, 128);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 22;
            label2.Text = "Người thuê nhà";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 3);
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Image = Properties.Resources.User_icon_2;
            pictureBox1.Location = new Point(282, 161);
            pictureBox1.MaximumSize = new Size(160, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoEllipsis = true;
            tableLayoutPanel1.SetColumnSpan(button2, 2);
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(33, 187);
            button2.Name = "button2";
            button2.Size = new Size(184, 99);
            button2.TabIndex = 18;
            button2.Text = "Đánh giá phản hồi";
            button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.AutoEllipsis = true;
            tableLayoutPanel1.SetColumnSpan(button5, 3);
            button5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(47, 29);
            button5.Name = "button5";
            button5.Size = new Size(184, 99);
            button5.TabIndex = 23;
            button5.Text = "Thanh toán tiền";
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(button1, 3);
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(270, 346);
            button1.Name = "button1";
            button1.Size = new Size(184, 99);
            button1.TabIndex = 17;
            button1.Text = "Tìm Kiếm Căn hộ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoEllipsis = true;
            tableLayoutPanel1.SetColumnSpan(button3, 3);
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(486, 29);
            button3.Name = "button3";
            button3.Size = new Size(184, 99);
            button3.TabIndex = 19;
            button3.Text = "Thông báo nhắc nhở";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.AutoEllipsis = true;
            tableLayoutPanel1.SetColumnSpan(button4, 2);
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(499, 187);
            button4.Name = "button4";
            button4.Size = new Size(184, 99);
            button4.TabIndex = 20;
            button4.Text = "Quản lý căn hộ";
            button4.UseVisualStyleBackColor = true;
            // 
            // HomePageUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            MinimumSize = new Size(709, 475);
            Name = "HomePageUser";
            Size = new Size(709, 475);
            Load += HomePageUser_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button5;
        private Label label2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
