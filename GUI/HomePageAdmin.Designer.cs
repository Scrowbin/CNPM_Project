namespace GUI
{
    partial class HomePageAdmin : Form
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
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            button4 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.5184145F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.5184145F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.926342F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.5184145F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.5184116F));
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Controls.Add(button5, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 3, 1);
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42.1052628F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.6315784F));
            tableLayoutPanel1.Size = new Size(709, 475);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.AutoEllipsis = true;
            tableLayoutPanel1.SetColumnSpan(button3, 2);
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(17, 208);
            button3.Name = "button3";
            button3.Size = new Size(184, 99);
            button3.TabIndex = 12;
            button3.Text = "Thông báo nhắc nhở";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.AutoEllipsis = true;
            tableLayoutPanel1.SetColumnSpan(button5, 2);
            button5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(17, 56);
            button5.Name = "button5";
            button5.Size = new Size(184, 99);
            button5.TabIndex = 16;
            button5.Text = "Thanh toán tiền";
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(button1, 2);
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(504, 208);
            button1.Name = "button1";
            button1.Size = new Size(184, 99);
            button1.TabIndex = 10;
            button1.Text = "Tìm Kiếm Căn hộ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.AutoEllipsis = true;
            tableLayoutPanel1.SetColumnSpan(button4, 2);
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(504, 56);
            button4.Name = "button4";
            button4.Size = new Size(184, 99);
            button4.TabIndex = 13;
            button4.Text = "Quản lý căn hộ";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.AutoEllipsis = true;
            tableLayoutPanel1.SetColumnSpan(button2, 3);
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(260, 360);
            button2.Name = "button2";
            button2.Size = new Size(184, 99);
            button2.TabIndex = 11;
            button2.Text = "Đánh giá phản hồi";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Image = Properties.Resources.Home_owner;
            pictureBox1.Location = new Point(272, 181);
            pictureBox1.MaximumSize = new Size(160, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Cursor = Cursors.No;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(312, 128);
            label2.Name = "label2";
            label2.Size = new Size(80, 30);
            label2.TabIndex = 15;
            label2.Text = "Chủ hộ";
            // 
            // HomePageAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            MinimumSize = new Size(709, 475);
            Name = "HomePageAdmin";
            Size = new Size(709, 475);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Button button4;
        private Button button3;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button5;
        private Button button1;
    }
}
