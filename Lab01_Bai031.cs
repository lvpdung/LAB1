using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB1
{
    public partial class Lab01_Bai031 : Form
    {
        public Lab01_Bai031()
        {
            InitializeComponent();
        }

        private void button_Doc_Click(object sender, EventArgs e)
        {
            int j = 0;
            bool check = true;
            while (j < textBox_Nhap.Text.Length)
            {
                if (textBox_Nhap.Text[j] < 48 || textBox_Nhap.Text[j] > 57)
                {
                    check = false;
                    break;
                }
                j++;
            }
            if (!check)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương (không nhiều hơn 12 chữ số)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Nhap.Text = "";
                textBox_KQ.Text = "";
            }
            else
            {
                string donvi = "";
                string nghin = "";
                string trieu = "";
                string ty = "";
                string KQdonvi = "";
                string KQnghin = "";
                string KQtrieu = "";
                string KQty = "";
                int DonVi, Nghin, Trieu, Ty;
                if (textBox_Nhap.Text.Length <= 3)
                {
                    donvi = textBox_Nhap.Text;
                }
                if (textBox_Nhap.Text.Length <= 6 && textBox_Nhap.Text.Length > 3)
                {
                    int i = textBox_Nhap.Text.Length - 3;
                    while (i < textBox_Nhap.Text.Length)
                    {
                        donvi += textBox_Nhap.Text[i];
                        i++;
                    }
                    i = 0;
                    while (i < textBox_Nhap.Text.Length - 3)
                    {
                        nghin += textBox_Nhap.Text[i];
                        i++;
                    }
                }
                if (textBox_Nhap.Text.Length <= 9 && textBox_Nhap.Text.Length > 6)
                {
                    int i = textBox_Nhap.Text.Length - 3;
                    while (i < textBox_Nhap.Text.Length)
                    {
                        donvi += textBox_Nhap.Text[i];
                        i++;
                    }
                    i = textBox_Nhap.Text.Length - 6;
                    while (i < textBox_Nhap.Text.Length - 3)
                    {
                        nghin += textBox_Nhap.Text[i];
                        i++;
                    }
                    i = 0;
                    while (i < textBox_Nhap.Text.Length - 6)
                    {
                        trieu += textBox_Nhap.Text[i];
                        i++;
                    }
                }
                if (textBox_Nhap.Text.Length <= 12 && textBox_Nhap.Text.Length > 9)
                {
                    int i = textBox_Nhap.Text.Length - 3;
                    while (i < textBox_Nhap.Text.Length)
                    {
                        donvi += textBox_Nhap.Text[i];
                        i++;
                    }
                    i = textBox_Nhap.Text.Length - 6;
                    while (i < textBox_Nhap.Text.Length - 3)
                    {
                        nghin += textBox_Nhap.Text[i];
                        i++;
                    }
                    i = textBox_Nhap.Text.Length - 9;
                    while (i < textBox_Nhap.Text.Length - 6)
                    {
                        trieu += textBox_Nhap.Text[i];
                        i++;
                    }
                    i = 0;
                    while (i < textBox_Nhap.Text.Length - 9)
                    {
                        ty += textBox_Nhap.Text[i];
                        i++;
                    }
                    Nghin = int.Parse(nghin);
                    Trieu = int.Parse(trieu);
                    Ty = int.Parse(ty);
                }
                if (textBox_Nhap.Text.Length < 4)
                {
                    DonVi = int.Parse(donvi);
                    Nghin = 0;
                    Trieu = 0;
                    Ty = 0;
                }
                else
                {
                    if (textBox_Nhap.Text.Length < 7)
                    {
                        DonVi = int.Parse(donvi);
                        Nghin = int.Parse(nghin);
                        Trieu = 0;
                        Ty = 0;
                    }
                    else
                    {
                        if (textBox_Nhap.Text.Length < 10)
                        {
                            DonVi = int.Parse(donvi);
                            Nghin = int.Parse(nghin);
                            Trieu = int.Parse(trieu);
                            Ty = 0;
                        }
                        else
                        {
                            DonVi = int.Parse(donvi);
                            Nghin = int.Parse(nghin);
                            Trieu = int.Parse(trieu);
                            Ty = int.Parse(ty);
                        }
                    }
                }
                if (DonVi == 0 && Nghin == 0 && Trieu == 0 && Ty == 0)
                {
                    textBox_KQ.Text = "không";
                }
                else
                {
                    int a = DonVi / 100;
                    DonVi = DonVi % 100;
                    switch (a)
                    {
                        case 0:
                            if ((Nghin != 0 || Trieu != 0 || Ty != 0) && DonVi != 0)
                            {
                                KQdonvi = "không trăm ";
                            }
                            break;
                        case 1:
                            KQdonvi += "một trăm ";
                            break;
                        case 2:
                            KQdonvi += "hai trăm ";
                            break;
                        case 3:
                            KQdonvi += "ba trăm ";
                            break;
                        case 4:
                            KQdonvi += "bốn trăm ";
                            break;
                        case 5:
                            KQdonvi += "năm trăm ";
                            break;
                        case 6:
                            KQdonvi += "sáu trăm ";
                            break;
                        case 7:
                            KQdonvi += "bảy trăm ";
                            break;
                        case 8:
                            KQdonvi += "tám trăm ";
                            break;
                        case 9:
                            KQdonvi += "chín trăm ";
                            break;
                    }
                    a = DonVi / 10;
                    DonVi = DonVi % 10;
                    switch (a)
                    {
                        case 0:
                            if (KQdonvi != "")
                            {
                                KQdonvi += "linh ";
                            }
                            break;
                        case 1:
                            KQdonvi += "mười ";
                            break;
                        case 2:
                            KQdonvi += "hai mươi ";
                            break;
                        case 3:
                            KQdonvi += "ba mươi ";
                            break;
                        case 4:
                            KQdonvi += "bốn mươi ";
                            break;
                        case 5:
                            KQdonvi += "năm mươi ";
                            break;
                        case 6:
                            KQdonvi += "sáu mươi ";
                            break;
                        case 7:
                            KQdonvi += "bảy mươi ";
                            break;
                        case 8:
                            KQdonvi += "tám mươi ";
                            break;
                        case 9:
                            KQdonvi += "chín mươi ";
                            break;
                    }
                    switch (DonVi)
                    {
                        case 1:
                            if (a == 1 || a == 0)
                            {
                                KQdonvi += "một ";
                            }
                            else
                            {
                                KQdonvi += "mốt ";
                            }
                            break;
                        case 2:
                            KQdonvi += "hai ";
                            break;
                        case 3:
                            KQdonvi += "ba ";
                            break;
                        case 4:
                            KQdonvi += "bốn ";
                            break;
                        case 5:
                            KQdonvi += "năm ";
                            break;
                        case 6:
                            KQdonvi += "sáu ";
                            break;
                        case 7:
                            KQdonvi += "bảy ";
                            break;
                        case 8:
                            KQdonvi += "tám ";
                            break;
                        case 9:
                            KQdonvi += "chín ";
                            break;
                    }
                }
                if (Nghin == 0)
                {
                    KQnghin = "";
                }
                else
                {
                    int a = Nghin / 100;
                    Nghin = Nghin % 100;
                    switch (a)
                    {
                        case 0:
                            if (Trieu != 0 || Ty != 0)
                            {
                                KQnghin = "không trăm ";
                            }
                            break;
                        case 1:
                            KQnghin += "một trăm ";
                            break;
                        case 2:
                            KQnghin += "hai trăm ";
                            break;
                        case 3:
                            KQnghin += "ba trăm ";
                            break;
                        case 4:
                            KQnghin += "bốn trăm ";
                            break;
                        case 5:
                            KQnghin += "năm trăm ";
                            break;
                        case 6:
                            KQnghin += "sáu trăm ";
                            break;
                        case 7:
                            KQnghin += "bảy trăm ";
                            break;
                        case 8:
                            KQnghin += "tám trăm ";
                            break;
                        case 9:
                            KQnghin += "chín trăm ";
                            break;
                    }
                    a = Nghin / 10;
                    Nghin = Nghin % 10;
                    switch (a)
                    {
                        case 0:
                            if (KQnghin != "")
                            {
                                KQnghin += "linh ";
                            }
                            break;
                        case 1:
                            KQnghin += "mười ";
                            break;
                        case 2:
                            KQnghin += "hai mươi ";
                            break;
                        case 3:
                            KQnghin += "ba mươi ";
                            break;
                        case 4:
                            KQnghin += "bốn mươi ";
                            break;
                        case 5:
                            KQnghin += "năm mươi ";
                            break;
                        case 6:
                            KQnghin += "sáu mươi ";
                            break;
                        case 7:
                            KQnghin += "bảy mươi ";
                            break;
                        case 8:
                            KQnghin += "tám mươi ";
                            break;
                        case 9:
                            KQnghin += "chín mươi ";
                            break;
                    }
                    switch (Nghin)
                    {
                        case 0:
                            if (KQnghin != null)
                            {
                                KQnghin += "nghìn ";
                            }
                            break;
                        case 1:
                            if (a == 1 || a == 0)
                            {
                                KQnghin += "một nghìn ";
                            }
                            else
                            {
                                KQnghin += "mốt nghìn ";
                            }
                            break;
                        case 2:
                            KQnghin += "hai nghìn ";
                            break;
                        case 3:
                            KQnghin += "ba nghìn ";
                            break;
                        case 4:
                            KQnghin += "bốn nghìn ";
                            break;
                        case 5:
                            KQnghin += "năm nghìn ";
                            break;
                        case 6:
                            KQnghin += "sáu nghìn ";
                            break;
                        case 7:
                            KQnghin += "bảy nghìn ";
                            break;
                        case 8:
                            KQnghin += "tám nghìn ";
                            break;
                        case 9:
                            KQnghin += "chín nghìn ";
                            break;
                    }
                }
                if (Trieu == 0)
                {
                    KQtrieu = "";
                }
                else
                {
                    int a = Trieu / 100;
                    Trieu = Trieu % 100;
                    switch (a)
                    {
                        case 0:
                            if (Ty != 0)
                            {
                                KQtrieu = "không trăm ";
                            }
                            break;
                        case 1:
                            KQtrieu += "một trăm ";
                            break;
                        case 2:
                            KQtrieu += "hai trăm ";
                            break;
                        case 3:
                            KQtrieu += "ba trăm ";
                            break;
                        case 4:
                            KQtrieu += "bốn trăm ";
                            break;
                        case 5:
                            KQtrieu += "năm trăm ";
                            break;
                        case 6:
                            KQtrieu += "sáu trăm ";
                            break;
                        case 7:
                            KQtrieu += "bảy trăm ";
                            break;
                        case 8:
                            KQtrieu += "tám trăm ";
                            break;
                        case 9:
                            KQtrieu += "chín trăm ";
                            break;
                    }
                    a = Trieu / 10;
                    Trieu = Trieu % 10;
                    switch (a)
                    {
                        case 0:
                            if (KQtrieu != "")
                            {
                                KQtrieu += "linh ";
                            }
                            break;
                        case 1:
                            KQtrieu += "mười ";
                            break;
                        case 2:
                            KQtrieu += "hai mươi ";
                            break;
                        case 3:
                            KQtrieu += "ba mươi ";
                            break;
                        case 4:
                            KQtrieu += "bốn mươi ";
                            break;
                        case 5:
                            KQtrieu += "năm mươi ";
                            break;
                        case 6:
                            KQtrieu += "sáu mươi ";
                            break;
                        case 7:
                            KQtrieu += "bảy mươi ";
                            break;
                        case 8:
                            KQtrieu += "tám mươi ";
                            break;
                        case 9:
                            KQtrieu += "chín mươi ";
                            break;
                    }
                    switch (Trieu)
                    {
                        case 0:
                            if (KQtrieu != null)
                            {
                                KQtrieu += "triệu ";
                            }
                            break;
                        case 1:
                            if (a == 1 || a == 0)
                            {
                                KQtrieu += "một triệu ";
                            }
                            else
                            {
                                KQtrieu += "mốt triệu ";
                            }
                            break;
                        case 2:
                            KQtrieu += "hai triệu ";
                            break;
                        case 3:
                            KQtrieu += "ba triệu ";
                            break;
                        case 4:
                            KQtrieu += "bốn triệu ";
                            break;
                        case 5:
                            KQtrieu += "năm triệu ";
                            break;
                        case 6:
                            KQtrieu += "sáu triệu ";
                            break;
                        case 7:
                            KQtrieu += "bảy triệun ";
                            break;
                        case 8:
                            KQtrieu += "tám triệu ";
                            break;
                        case 9:
                            KQtrieu += "chín triệu ";
                            break;
                    }
                }
                if (Ty == 0)
                {
                    KQty = "";
                }
                else
                {
                    int a = Ty / 100;
                    Ty = Ty % 100;
                    switch (a)
                    {
                        case 1:
                            KQty += "một trăm ";
                            break;
                        case 2:
                            KQty += "hai trăm ";
                            break;
                        case 3:
                            KQty += "ba trăm ";
                            break;
                        case 4:
                            KQty += "bốn trăm ";
                            break;
                        case 5:
                            KQty += "năm trăm ";
                            break;
                        case 6:
                            KQty += "sáu trăm ";
                            break;
                        case 7:
                            KQty += "bảy trăm ";
                            break;
                        case 8:
                            KQty += "tám trăm ";
                            break;
                        case 9:
                            KQty += "chín trăm ";
                            break;
                    }
                    a = Ty / 10;
                    Trieu = Ty % 10;
                    switch (a)
                    {
                        case 0:
                            if (KQty != "")
                            {
                                KQty += "linh ";
                            }
                            break;
                        case 1:
                            KQty += "mười ";
                            break;
                        case 2:
                            KQty += "hai mươi ";
                            break;
                        case 3:
                            KQty += "ba mươi ";
                            break;
                        case 4:
                            KQty += "bốn mươi ";
                            break;
                        case 5:
                            KQty += "năm mươi ";
                            break;
                        case 6:
                            KQty += "sáu mươi ";
                            break;
                        case 7:
                            KQty += "bảy mươi ";
                            break;
                        case 8:
                            KQty += "tám mươi ";
                            break;
                        case 9:
                            KQty += "chín mươi ";
                            break;
                    }
                    switch (Ty)
                    {
                        case 0:
                            if (KQty != null)
                            {
                                KQty += "tỷ ";
                            }
                            break;
                        case 1:
                            if (a == 1 || a == 0)
                            {
                                KQty += "một tỷ ";
                            }
                            else
                            {
                                KQty += "mốt tỷ ";
                            }
                            break;
                        case 2:
                            KQty += "hai tỷ ";
                            break;
                        case 3:
                            KQty += "ba tỷ ";
                            break;
                        case 4:
                            KQty += "bốn tỷ ";
                            break;
                        case 5:
                            KQty += "năm tỷ ";
                            break;
                        case 6:
                            KQty += "sáu tỷ ";
                            break;
                        case 7:
                            KQty += "bảy tỷ ";
                            break;
                        case 8:
                            KQty += "tám tỷ ";
                            break;
                        case 9:
                            KQty += "chín tỷ ";
                            break;
                    }
                }
                textBox_KQ.Text = KQty + KQtrieu + KQnghin + KQdonvi;
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
