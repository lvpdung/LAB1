namespace LAB1
{
    partial class Lab01_Bai03
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
            this.textBox_Nhap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_KQ = new System.Windows.Forms.TextBox();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Doc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Nhap
            // 
            this.textBox_Nhap.Location = new System.Drawing.Point(299, 80);
            this.textBox_Nhap.Name = "textBox_Nhap";
            this.textBox_Nhap.Size = new System.Drawing.Size(116, 26);
            this.textBox_Nhap.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nhập vào số nguyên từ 0 đến 9";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Kết quả";
            // 
            // textBox_KQ
            // 
            this.textBox_KQ.Location = new System.Drawing.Point(45, 336);
            this.textBox_KQ.Name = "textBox_KQ";
            this.textBox_KQ.ReadOnly = true;
            this.textBox_KQ.Size = new System.Drawing.Size(332, 26);
            this.textBox_KQ.TabIndex = 10;
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(575, 300);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(109, 48);
            this.button_Thoat.TabIndex = 21;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(575, 195);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(109, 48);
            this.button_Xoa.TabIndex = 20;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Doc
            // 
            this.button_Doc.Location = new System.Drawing.Point(575, 72);
            this.button_Doc.Name = "button_Doc";
            this.button_Doc.Size = new System.Drawing.Size(109, 48);
            this.button_Doc.TabIndex = 19;
            this.button_Doc.Text = "Đọc";
            this.button_Doc.UseVisualStyleBackColor = true;
            this.button_Doc.Click += new System.EventHandler(this.button_Doc_Click);
            // 
            // Lab01_Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Doc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_KQ);
            this.Controls.Add(this.textBox_Nhap);
            this.Controls.Add(this.label9);
            this.Name = "Lab01_Bai03";
            this.Text = "Bài 03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Nhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_KQ;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Doc;
    }
}