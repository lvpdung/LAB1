using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        private void buttonTinh_Click(object sender, EventArgs e)
        {
            int k = 0, j = 0;
            bool checkA = true, checkB = true;
            while (k < textBox_A.Text.Length)
            {
                if (textBox_A.Text[k] < 48 || textBox_A.Text[k] > 57)
                {
                    checkA = false;
                    break;
                }
                k++;
            }
            while (j < textBox_B.Text.Length)
            {
                if (textBox_B.Text[j] < 48 || textBox_B.Text[j] > 57)
                {
                    checkB = false;
                    break;
                }
                j++;
            }
            if (!checkA || !checkB)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_A.Text = "";
                textBox_B.Text = "";
                textBoxKQ.Text = "";
            }
            else
            {
                int numA = int.Parse(textBox_A.Text);
                int numB = int.Parse(textBox_B.Text);
                if (comboBox.Text == "Bảng cửu chương")
                {
                    int KQ = numB - numA;
                    textBoxKQ.Text = "B - A = " + KQ.ToString();
                }
                else
                {
                    if (comboBox.Text == "Tính toán giá trị")
                    {
                        long GiaiThua = 1;
                        int Hieu = numA - numB;
                        int i = 1;
                        while (i <= Hieu)
                        {
                            GiaiThua *= i;
                            i++;
                        }
                        long S = 0;
                        long LuyThua = 1;
                        i = 1;
                        while (i <= numB)
                        {
                            LuyThua *= numA;
                            S += LuyThua;
                            i++;
                        }
                        string KQ = "(A - B)! = " + GiaiThua.ToString() + Environment.NewLine;
                        KQ += "Tổng S = A^1 + A^2 + A^3 + A^4 + … +A^B = " + S.ToString();
                        textBoxKQ.Text = KQ;
                    }
                }
            }    
    
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textBox_A.Text = "";
            textBox_B.Text = "";
            textBoxKQ.Text = "";
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
