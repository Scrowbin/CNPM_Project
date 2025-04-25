namespace GUI
{
    partial class frmWater
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
            label15 = new Label();
            richTextBox1 = new RichTextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            textBox8 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvAll = new DataGridView();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAll).BeginInit();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(655, 277);
            label15.Name = "label15";
            label15.Size = new Size(55, 15);
            label15.TabIndex = 54;
            label15.Text = "Nhận xét";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(397, 303);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(564, 349);
            richTextBox1.TabIndex = 53;
            richTextBox1.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(89, 346);
            label11.Name = "label11";
            label11.Size = new Size(106, 15);
            label11.TabIndex = 49;
            label11.Text = "6 trở lên m3/người";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(99, 306);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 48;
            label10.Text = "4-6 m3/người";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(107, 279);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 47;
            label9.Text = "0-4 m3/người";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(89, 424);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(222, 23);
            dateTimePicker1.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 375);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 45;
            label8.Text = "Tên giá nước";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(89, 372);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(222, 23);
            textBox8.TabIndex = 44;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(196, 343);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 40;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(196, 303);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(109, 23);
            textBox3.TabIndex = 39;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 274);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 346);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 34;
            label4.Text = "Mức 3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 306);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 33;
            label3.Text = "Mức 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 279);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 32;
            label2.Text = "Mức 1";
            // 
            // dgvAll
            // 
            dgvAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAll.Location = new Point(12, 12);
            dgvAll.Name = "dgvAll";
            dgvAll.Size = new Size(972, 234);
            dgvAll.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 425);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 30;
            label1.Text = "Áp dụng từ";
            // 
            // button3
            // 
            button3.Location = new Point(239, 480);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 57;
            button3.Text = "Lưu";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(126, 480);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 56;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(16, 480);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 55;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmWater
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 664);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label15);
            Controls.Add(richTextBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(textBox8);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvAll);
            Controls.Add(label1);
            Name = "frmWater";
            Text = "frmWater";
            Load += frmWater_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAll).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label15;
        private RichTextBox richTextBox1;
        private Label label11;
        private Label label10;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private TextBox textBox8;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgvAll;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}