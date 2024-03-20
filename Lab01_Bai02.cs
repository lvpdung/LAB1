using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void button_Tim_Click(object sender, EventArgs e)
        {
            float Num1, Num2, Num3;
            if (!float.TryParse(textBox_1.Text, out Num1) || !float.TryParse(textBox_2.Text, out Num2) || !float.TryParse(textBox_2.Text, out Num3))
            {
                MessageBox.Show("Vui lòng nhập số thực!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_1.Text = "";
                textBox_2.Text = "";
                textBox_3.Text = "";
                textBox_Max.Text = "";
                textBox_Min.Text = "";
            }
            else 
            {
                Num1 = float.Parse(textBox_1.Text);
                Num2 = float.Parse(textBox_2.Text);
                Num3 = float.Parse(textBox_3.Text);
                float NumMax, NumMin;;
                NumMax = Num1;
                if (Num2 > NumMax)
                {
                    NumMax = Num2;
                }
                if (Num3 > NumMax)
                {
                    NumMax = Num3;
                }
                NumMin = Num1;
                if (Num2 < NumMin)
                {
                    NumMin = Num2;
                }
                if (Num3 < NumMin)
                {
                    NumMin = Num3;
                }
                textBox_Min.Text = NumMin.ToString();
                textBox_Max.Text = NumMax.ToString();
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            textBox_1.Text = "";
            textBox_2.Text = "";
            textBox_3.Text = "";
            textBox_Min.Text = "";
            textBox_Max.Text = "";
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
