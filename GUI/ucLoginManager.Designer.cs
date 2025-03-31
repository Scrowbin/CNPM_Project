namespace GUI
{
    partial class ucLoginManager
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
            btnForgotPassManager = new Button();
            btnLoginManager = new Button();
            txtPassManager = new TextBox();
            txtEmailManager = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnForgotPassManager
            // 
            btnForgotPassManager.Location = new Point(401, 233);
            btnForgotPassManager.Margin = new Padding(3, 2, 3, 2);
            btnForgotPassManager.Name = "btnForgotPassManager";
            btnForgotPassManager.Size = new Size(111, 22);
            btnForgotPassManager.TabIndex = 17;
            btnForgotPassManager.Text = "Quên Mật Khẩu";
            btnForgotPassManager.UseVisualStyleBackColor = true;
            // 
            // btnLoginManager
            // 
            btnLoginManager.Location = new Point(150, 233);
            btnLoginManager.Margin = new Padding(3, 2, 3, 2);
            btnLoginManager.Name = "btnLoginManager";
            btnLoginManager.Size = new Size(82, 22);
            btnLoginManager.TabIndex = 12;
            btnLoginManager.Text = "Đăng Nhập";
            btnLoginManager.UseVisualStyleBackColor = true;
            btnLoginManager.Click += btnLoginManager_Click;
            // 
            // txtPassManager
            // 
            txtPassManager.Location = new Point(150, 170);
            txtPassManager.Margin = new Padding(3, 2, 3, 2);
            txtPassManager.Name = "txtPassManager";
            txtPassManager.Size = new Size(363, 23);
            txtPassManager.TabIndex = 16;
            // 
            // txtEmailManager
            // 
            txtEmailManager.Location = new Point(150, 105);
            txtEmailManager.Margin = new Padding(3, 2, 3, 2);
            txtEmailManager.Name = "txtEmailManager";
            txtEmailManager.Size = new Size(363, 23);
            txtEmailManager.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 146);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 14;
            label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 78);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 13;
            label1.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 10);
            label3.Name = "label3";
            label3.Size = new Size(211, 30);
            label3.TabIndex = 18;
            label3.Text = "Đăng nhập Quản lý";
            // 
            // ucLoginManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label3);
            Controls.Add(btnForgotPassManager);
            Controls.Add(btnLoginManager);
            Controls.Add(txtPassManager);
            Controls.Add(txtEmailManager);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucLoginManager";
            Size = new Size(679, 320);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnForgotPassManager;
        private Button btnLoginManager;
        private TextBox txtPassManager;
        private TextBox txtEmailManager;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}
