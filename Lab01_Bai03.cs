using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB1
{
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void button_Doc_Click(object sender, EventArgs e)
        {
            int i = 0;
            bool check = true;
            while (i < textBox_Nhap.Text.Length)
            {
                if (textBox_Nhap.Text[i] < 48 || textBox_Nhap.Text[i] > 57)
                {
                    check = false;
                    break;
                }
                i++;
            }
            if (!check)
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Nhap.Text = "";
                textBox_KQ.Text = "";
            }
            else
            {
                int Num;
                string KQ = null;
                Num = int.Parse(textBox_Nhap.Text);
                if (Num == 0)
                {
                    KQ = "Không";
                }
                if (Num == 1)
                {
                    KQ = "Một";
                }
                if (Num == 2)
                {
                    KQ = "Hai";
                }
                if (Num == 3)
                {
                    KQ = "Ba";
                }
                if (Num == 4)
                {
                    KQ = "Bốn";
                }
                if (Num == 5)
                {
                    KQ = "Năm";
                }
                if (Num == 6)
                {
                    KQ = "Sáu";
                }
                if (Num == 7)
                {
                    KQ = "Bảy";
                }
                if (Num == 8)
                {
                    KQ = "Tám";
                }
                if (Num == 9)
                {
                    KQ = "Chín";
                }
                textBox_KQ.Text = KQ;
            }    
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {

            textBox_Nhap.Text = "";
            textBox_KQ.Text = "";
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
