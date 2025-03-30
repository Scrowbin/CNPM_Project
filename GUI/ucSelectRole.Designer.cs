namespace GUI
{
    partial class ucSelectRole
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
            label1 = new Label();
            btnCustomer = new Button();
            btnManager = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 48);
            label1.Name = "label1";
            label1.Size = new Size(361, 31);
            label1.TabIndex = 5;
            label1.Text = "Chọn đối tượng để đăng nhập";
            // 
            // btnCustomer
            // 
            btnCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCustomer.BackgroundImageLayout = ImageLayout.Stretch;
            btnCustomer.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.Location = new Point(390, 110);
            btnCustomer.Margin = new Padding(3, 2, 3, 2);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(201, 162);
            btnCustomer.TabIndex = 4;
            btnCustomer.Text = "KHÁCH HÀNG";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnManager
            // 
            btnManager.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnManager.BackColor = Color.Transparent;
            btnManager.BackgroundImageLayout = ImageLayout.Stretch;
            btnManager.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManager.ForeColor = Color.Black;
            btnManager.Location = new Point(88, 110);
            btnManager.Margin = new Padding(3, 2, 3, 2);
            btnManager.Name = "btnManager";
            btnManager.Size = new Size(201, 162);
            btnManager.TabIndex = 3;
            btnManager.Text = "QUẢN LÝ";
            btnManager.UseVisualStyleBackColor = false;
            btnManager.Click += btnManager_Click;
            // 
            // ucSelectRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnCustomer);
            Controls.Add(btnManager);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucSelectRole";
            Size = new Size(679, 320);
            Load += ucSelectRole_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCustomer;
        private Button btnManager;
    }
}
