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
    public partial class LAB01 : Form
    {
        public LAB01()
        {
            InitializeComponent();
        }

        private void buttonBai1_Click(object sender, EventArgs e)
        {
            Lab01_Bai01 Bai1 = new Lab01_Bai01();
            Bai1.Show();
        }

        private void buttonBai2_Click(object sender, EventArgs e)
        {
            Lab01_Bai02 Bai2 = new Lab01_Bai02();
            Bai2.Show();
        }

        private void buttonBai3_Click(object sender, EventArgs e)
        {
            Lab01_Bai03 Bai3 = new Lab01_Bai03();
            Bai3.Show();
        }

        private void buttonBai5_Click(object sender, EventArgs e)
        {
            Lab01_Bai05 Bai5 = new Lab01_Bai05();
            Bai5.Show();
        }

        private void buttonBai6_Click(object sender, EventArgs e)
        {
            Lab01_Bai06 Bai6 = new Lab01_Bai06();
            Bai6.Show();
        }

        private void buttonBai7_Click(object sender, EventArgs e)
        {
            Lab01_Bai07 Bai7 = new Lab01_Bai07();
            Bai7.Show();
        }

        private void buttonBai8_Click(object sender, EventArgs e)
        {
            Lab01_Bai08 Bai8 = new Lab01_Bai08();
            Bai8.Show();
        }

        private void buttonBai031_Click(object sender, EventArgs e)
        {
            Lab01_Bai031 Bai31 = new Lab01_Bai031();
            Bai31.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
