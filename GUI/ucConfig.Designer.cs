namespace GUI
{
    partial class ucConfig
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
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtServer = new TextBox();
            txtDatabase = new TextBox();
            txtUID = new TextBox();
            txtPassword = new TextBox();
            ckWindows = new CheckBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(142, 362);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(168, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(475, 362);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(168, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 76);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 131);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "Database";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 185);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 4;
            label3.Text = "UID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 246);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 22);
            label5.Name = "label5";
            label5.Size = new Size(74, 28);
            label5.TabIndex = 6;
            label5.Text = "Config";
            // 
            // txtServer
            // 
            txtServer.Location = new Point(172, 76);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(528, 27);
            txtServer.TabIndex = 0;
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(172, 135);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(528, 27);
            txtDatabase.TabIndex = 1;
            // 
            // txtUID
            // 
            txtUID.Location = new Point(172, 192);
            txtUID.Name = "txtUID";
            txtUID.Size = new Size(528, 27);
            txtUID.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(172, 250);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(528, 27);
            txtPassword.TabIndex = 3;
            // 
            // ckWindows
            // 
            ckWindows.AutoSize = true;
            ckWindows.Location = new Point(58, 308);
            ckWindows.Name = "ckWindows";
            ckWindows.Size = new Size(187, 24);
            ckWindows.TabIndex = 7;
            ckWindows.Text = "Window Authentication";
            ckWindows.UseVisualStyleBackColor = true;
            ckWindows.CheckedChanged += ckW_CheckedChanged;
            // 
            // ucConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ckWindows);
            Controls.Add(txtPassword);
            Controls.Add(txtUID);
            Controls.Add(txtDatabase);
            Controls.Add(txtServer);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "ucConfig";
            Size = new Size(776, 426);
            Load += ucConfig_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtServer;
        private TextBox txtDatabase;
        private TextBox txtUID;
        private TextBox txtPassword;
        private CheckBox ckWindows;
    }
}
