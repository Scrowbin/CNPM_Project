namespace GUI
{
    partial class ucLoginCustomer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnForgotPassCustomer = new Button();
            btnLoginCustomer = new Button();
            txtPassCustomer = new TextBox();
            txtEmailCustomer = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnForgotPassCustomer
            // 
            btnForgotPassCustomer.Location = new Point(402, 233);
            btnForgotPassCustomer.Margin = new Padding(3, 2, 3, 2);
            btnForgotPassCustomer.Name = "btnForgotPassCustomer";
            btnForgotPassCustomer.Size = new Size(111, 22);
            btnForgotPassCustomer.TabIndex = 11;
            btnForgotPassCustomer.Text = "Quên Mật Khẩu";
            btnForgotPassCustomer.UseVisualStyleBackColor = true;
            // 
            // btnLoginCustomer
            // 
            btnLoginCustomer.Location = new Point(150, 233);
            btnLoginCustomer.Margin = new Padding(3, 2, 3, 2);
            btnLoginCustomer.Name = "btnLoginCustomer";
            btnLoginCustomer.Size = new Size(82, 22);
            btnLoginCustomer.TabIndex = 6;
            btnLoginCustomer.Text = "Đăng Nhập";
            btnLoginCustomer.UseVisualStyleBackColor = true;
            btnLoginCustomer.Click += btnLoginCustomer_Click;
            // 
            // txtPassCustomer
            // 
            txtPassCustomer.Location = new Point(150, 170);
            txtPassCustomer.Margin = new Padding(3, 2, 3, 2);
            txtPassCustomer.Name = "txtPassCustomer";
            txtPassCustomer.Size = new Size(363, 23);
            txtPassCustomer.TabIndex = 10;
            // 
            // txtEmailCustomer
            // 
            txtEmailCustomer.Location = new Point(150, 105);
            txtEmailCustomer.Margin = new Padding(3, 2, 3, 2);
            txtEmailCustomer.Name = "txtEmailCustomer";
            txtEmailCustomer.Size = new Size(363, 23);
            txtEmailCustomer.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 146);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 8;
            label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 78);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 7;
            label1.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 15);
            label3.Name = "label3";
            label3.Size = new Size(253, 30);
            label3.TabIndex = 19;
            label3.Text = "Đăng nhập Khách hàng";
            // 
            // ucLoginCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label3);
            Controls.Add(btnForgotPassCustomer);
            Controls.Add(btnLoginCustomer);
            Controls.Add(txtPassCustomer);
            Controls.Add(txtEmailCustomer);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucLoginCustomer";
            Size = new Size(679, 320);
            Load += ucLoginCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnForgotPassCustomer;
        private Button btnLoginCustomer;
        private TextBox txtPassCustomer;
        private TextBox txtEmailCustomer;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}
