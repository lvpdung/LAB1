namespace LAB1
{
    partial class Lab01_Bai08
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
            this.textBoxNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDS = new System.Windows.Forms.TextBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonTim = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.textBoxMonAn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNhap
            // 
            this.textBoxNhap.Location = new System.Drawing.Point(172, 55);
            this.textBoxNhap.Name = "textBoxNhap";
            this.textBoxNhap.Size = new System.Drawing.Size(305, 26);
            this.textBoxNhap.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập món ăn";
            // 
            // textBoxDS
            // 
            this.textBoxDS.Location = new System.Drawing.Point(615, 55);
            this.textBoxDS.Multiline = true;
            this.textBoxDS.Name = "textBoxDS";
            this.textBoxDS.Size = new System.Drawing.Size(305, 187);
            this.textBoxDS.TabIndex = 6;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(728, 290);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(122, 29);
            this.buttonThoat.TabIndex = 12;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(402, 290);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(138, 29);
            this.buttonXoa.TabIndex = 11;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonTim
            // 
            this.buttonTim.Location = new System.Drawing.Point(73, 290);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(122, 29);
            this.buttonTim.TabIndex = 10;
            this.buttonTim.Text = "Tìm món ăn";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(474, 119);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(122, 53);
            this.buttonThem.TabIndex = 13;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // textBoxMonAn
            // 
            this.textBoxMonAn.Location = new System.Drawing.Point(316, 401);
            this.textBoxMonAn.Name = "textBoxMonAn";
            this.textBoxMonAn.Size = new System.Drawing.Size(305, 26);
            this.textBoxMonAn.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Món hôm nay ăn là";
            // 
            // Lab01_Bai08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 450);
            this.Controls.Add(this.textBoxMonAn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.textBoxDS);
            this.Controls.Add(this.textBoxNhap);
            this.Controls.Add(this.label1);
            this.Name = "Lab01_Bai08";
            this.Text = "Bài 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDS;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.TextBox textBoxMonAn;
        private System.Windows.Forms.Label label2;
    }
}