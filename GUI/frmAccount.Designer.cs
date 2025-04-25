namespace GUI
{
    partial class frmAccount
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            textBox4 = new TextBox();
            dgvElectricity = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvElectricity).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 15.75F);
            textBox1.Location = new Point(130, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 32);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 15.75F);
            textBox2.Location = new Point(133, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(329, 32);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 15.75F);
            textBox3.Location = new Point(133, 61);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(329, 32);
            textBox3.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Times New Roman", 15.75F);
            textBox5.Location = new Point(133, 100);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(329, 32);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Times New Roman", 15.75F);
            textBox6.Location = new Point(130, 60);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(361, 32);
            textBox6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(102, 23);
            label1.TabIndex = 6;
            label1.Text = "Tên chủ hộ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F);
            label2.Location = new Point(14, 25);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 7;
            label2.Text = "Số tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F);
            label3.Location = new Point(29, 64);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 8;
            label3.Text = "Ngân hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F);
            label4.Location = new Point(5, 103);
            label4.Name = "label4";
            label4.Size = new Size(122, 23);
            label4.TabIndex = 9;
            label4.Text = "Tên tài khoản";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F);
            label5.Location = new Point(4, 63);
            label5.Name = "label5";
            label5.Size = new Size(120, 23);
            label5.TabIndex = 10;
            label5.Text = "Số điện thoại";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(489, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 148);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chủ hộ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(471, 148);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin tài khoản ngân hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F);
            label6.Location = new Point(6, 103);
            label6.Name = "label6";
            label6.Size = new Size(70, 23);
            label6.TabIndex = 14;
            label6.Text = "Địa chỉ";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 15.75F);
            textBox4.Location = new Point(82, 100);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(409, 32);
            textBox4.TabIndex = 13;
            // 
            // dgvElectricity
            // 
            dgvElectricity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvElectricity.Location = new Point(12, 226);
            dgvElectricity.Name = "dgvElectricity";
            dgvElectricity.Size = new Size(968, 201);
            dgvElectricity.TabIndex = 13;
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 664);
            Controls.Add(dgvElectricity);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmAccount";
            Text = "frmAccount";
            Load += frmAccount_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvElectricity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox textBox4;
        private DataGridView dgvElectricity;
    }
}