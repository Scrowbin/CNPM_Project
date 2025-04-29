using System.Drawing.Printing;
using System.Windows.Forms;

namespace GUI
{
    partial class frmLogin : Form
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
            btnForgotPassCustomer.Location = new Point(459, 311);
            btnForgotPassCustomer.Name = "btnForgotPassCustomer";
            btnForgotPassCustomer.Size = new Size(127, 29);
            btnForgotPassCustomer.TabIndex = 4;
            btnForgotPassCustomer.Text = "Quên Mật Khẩu";
            btnForgotPassCustomer.UseVisualStyleBackColor = true;
            btnForgotPassCustomer.Click += btnForgotPassCustomer_Click;
            // 
            // btnLoginCustomer
            // 
            btnLoginCustomer.Location = new Point(171, 311);
            btnLoginCustomer.Name = "btnLoginCustomer";
            btnLoginCustomer.Size = new Size(94, 29);
            btnLoginCustomer.TabIndex = 3;
            btnLoginCustomer.Text = "Đăng Nhập";
            btnLoginCustomer.UseVisualStyleBackColor = true;
            btnLoginCustomer.Click += btnLoginCustomer_Click;
            // 
            // txtPassCustomer
            // 
            txtPassCustomer.Location = new Point(171, 227);
            txtPassCustomer.Name = "txtPassCustomer";
            txtPassCustomer.Size = new Size(414, 27);
            txtPassCustomer.TabIndex = 2;
            txtPassCustomer.UseSystemPasswordChar = true;
            // 
            // txtEmailCustomer
            // 
            txtEmailCustomer.Location = new Point(171, 140);
            txtEmailCustomer.Name = "txtEmailCustomer";
            txtEmailCustomer.Size = new Size(414, 27);
            txtEmailCustomer.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 195);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 8;
            label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 104);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 7;
            label1.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 20);
            label3.Name = "label3";
            label3.Size = new Size(161, 38);
            label3.TabIndex = 19;
            label3.Text = "Đăng nhập";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(758, 375);
            Controls.Add(label3);
            Controls.Add(btnForgotPassCustomer);
            Controls.Add(btnLoginCustomer);
            Controls.Add(txtPassCustomer);
            Controls.Add(txtEmailCustomer);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
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