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
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void button_Sum_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            bool check1 = true, check2 = true;
            while (i < textBox_1.Text.Length)
            {
                if (textBox_1.Text[i] < 48 || textBox_1.Text[i] > 57)
                {
                    check1 = false;
                    break;
                }
                i++;
            }
            while (j < textBox_2.Text.Length)
            {
                if (textBox_2.Text[j] < 48 || textBox_2.Text[j] > 57)
                {
                    check2 = false;
                    break;
                }
                j++;
            }
            if (!check1 || !check2)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_1.Text = "";
                textBox_2.Text = "";
                textBox_KQ.Text = "";
            }
            else
            {
                int Num1, Num2, Sum;
                Num1 = int.Parse(textBox_1.Text);
                Num2 = int.Parse(textBox_2.Text);
                Sum = Num1 + Num2;
                textBox_KQ.Text = Sum.ToString();
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textBox_1.Text = "";
            textBox_2.Text = "";
            textBox_KQ.Text = "";
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
