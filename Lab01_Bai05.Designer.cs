namespace LAB1
{
    partial class Lab01_Bai05
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
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.buttonTinh = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.Thoát = new System.Windows.Forms.Button();
            this.textBoxKQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(138, 69);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(116, 26);
            this.textBox_A.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Nhập a";
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(556, 72);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(116, 26);
            this.textBox_B.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nhập b";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Bảng cửu chương",
            "Tính toán giá trị"});
            this.comboBox.Location = new System.Drawing.Point(250, 179);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(306, 28);
            this.comboBox.TabIndex = 28;
            // 
            // buttonTinh
            // 
            this.buttonTinh.Location = new System.Drawing.Point(103, 281);
            this.buttonTinh.Name = "buttonTinh";
            this.buttonTinh.Size = new System.Drawing.Size(151, 41);
            this.buttonTinh.TabIndex = 29;
            this.buttonTinh.Text = "Tính các giá trị";
            this.buttonTinh.UseVisualStyleBackColor = true;
            this.buttonTinh.Click += new System.EventHandler(this.buttonTinh_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(351, 281);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(102, 41);
            this.buttonXoa.TabIndex = 30;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // Thoát
            // 
            this.Thoát.Location = new System.Drawing.Point(581, 281);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(91, 41);
            this.Thoát.TabIndex = 31;
            this.Thoát.Text = "Thoát";
            this.Thoát.UseVisualStyleBackColor = true;
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            // 
            // textBoxKQ
            // 
            this.textBoxKQ.Location = new System.Drawing.Point(52, 396);
            this.textBoxKQ.Multiline = true;
            this.textBoxKQ.Name = "textBoxKQ";
            this.textBoxKQ.Size = new System.Drawing.Size(677, 84);
            this.textBoxKQ.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Kết quả";
            // 
            // Lab01_Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKQ);
            this.Controls.Add(this.Thoát);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonTinh);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_A);
            this.Controls.Add(this.label9);
            this.Name = "Lab01_Bai05";
            this.Text = "Bài 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button buttonTinh;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button Thoát;
        private System.Windows.Forms.TextBox textBoxKQ;
        private System.Windows.Forms.Label label2;
    }
}