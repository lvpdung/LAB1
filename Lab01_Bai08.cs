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
    public partial class Lab01_Bai08 : Form
    {
        List<string> DS = new List<string>();

        public Lab01_Bai08()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            DS.Add(textBoxNhap.Text);
            textBoxNhap.Text = "";
            string DSMon = "";
            foreach (var tam in DS)
            {
                DSMon += tam + Environment.NewLine;
            }
            textBoxDS.Text = DSMon;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textBoxNhap.Text = "";
            textBoxDS.Text = "";
            textBoxMonAn.Text = "";
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomIndex = random.Next(DS.Count);
            string randomMonAn = DS[randomIndex];
            textBoxMonAn.Text = randomMonAn;
        }
    }
}
