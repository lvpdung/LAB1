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
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            string Ngay = "", Thang = "", Nam = "";
            int dem = 0, i  = 0;
            while (i < textBoxNgaySinh.Text.Length)
            {
                if (textBoxNgaySinh.Text[i] == '/')
                {
                    dem++;
                }
                i++;
            }   
            if (dem != 2)
            {
                MessageBox.Show("Vui lòng nhập đúng ngày sinh!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNgaySinh.Text = "";
                textBoxCHD.Text = "";
            }
            else
            {
                i = 0;
                while (textBoxNgaySinh.Text[i] != '/')
                {
                    Ngay += textBoxNgaySinh.Text[i];
                    i++;
                }
                while (textBoxNgaySinh.Text[i] != '/')
                {
                    Ngay += textBoxNgaySinh.Text[i];
                    i++;
                }
                i++;
                while (textBoxNgaySinh.Text[i] != '/')
                {
                    Thang += textBoxNgaySinh.Text[i];
                    i++;
                }
                i++;
                while (i < textBoxNgaySinh.Text.Length)
                {
                    Nam += textBoxNgaySinh.Text[i];
                    i++;
                }
                int ngay = int.Parse(Ngay);
                int thang = int.Parse(Thang);
                int nam = int.Parse(Nam);
                bool check2 = false;
                switch (thang)
                {
                    case 1:
                        if (ngay >= 1 && ngay <= 20)
                        {
                            textBoxCHD.Text = "Ma Kết";
                            check2 = true;
                        }
                        else
                        {
                            if (ngay >= 21 && ngay <= 31)
                            {
                                textBoxCHD.Text = "Bảo Bình";
                                check2 = true;
                            }
                        }
                        break;
                    case 2:
                        bool nhuan = false;
                        if (nam % 400 == 0)
                        {
                            nhuan = true;
                        }
                        else
                        {
                            if (nam % 4 == 0 && nam % 100 != 0)
                            {
                                nhuan = true;
                            }
                        }
                        if (ngay >= 1 && ngay <= 18)
                        {
                            textBoxCHD.Text = "Bảo Bình";
                            check2 = true;
                        }
                        else
                        {
                            if (ngay >= 19 && ngay <= 29 && nhuan)
                            {
                                textBoxCHD.Text = "Song Ngư";
                                check2 = true;
                            }
                            else
                            {
                                if (ngay >= 19 && ngay <= 28 && !nhuan)
                                {
                                    textBoxCHD.Text = "Song Ngư";
                                    check2 = true;
                                }
                            }
                        }
                        break;
                    case 3:
                        if (ngay >= 1 && ngay <= 20)
                        {
                            textBoxCHD.Text = "Song Ngư";
                            check2 = true;
                        }
                        else
                        {
                            if (ngay >= 21 && ngay <= 31)
                            {
                                textBoxCHD.Text = "Bạch Dương";
                                check2 = true;
                            }
                        }
                        break;
                    case 4:
                        if (ngay >= 1 && ngay <= 20)
                        {
                            textBoxCHD.Text = "Bạch Dương";
                            check2 = true;
                        }
                        else
                        {
                            if (ngay >= 21 && ngay <= 30)
                            {
                                textBoxCHD.Text = "Kim Ngưu";
                                check2 = true;
                            }
                        }
                        break;
                    case 5:
                        if (ngay >= 1 && ngay <= 21)
                        {
                            textBoxCHD.Text = "Kim Ngưu";
                            check2 = true;
                        }
                        else
                        {
                            if (ngay >= 22 && ngay <= 31)
                            {
                                textBoxCHD.Text = "Song Tư";
                                check2 = true;
                            }
                        }
                        break;
                    case 6:
                        if (ngay >= 1 && ngay <= 21)
                        {
                            textBoxCHD.Text = "Song Tử";
                            check2 = true;
                        }
                        else
                        {
                            if (ngay >= 22 && ngay <= 30)
                            {
                                textBoxCHD.Text = "Cự Giải";
                                check2 = true;
                            }
                        }
                        break;
                    case 7:
                        if (ngay >= 1 && ngay <= 22)
                        {
                            textBoxCHD.Text = "Cự Giải";
                            check2 = true;
                        }
                        else
                        {
                            if (ngay >= 23 && ngay <= 31)
                            {
                                textBoxCHD.Text = "Sư Tử";
                                check2 = true;
                            }
                        }
                        break;
                    case 8:
                        if (ngay >= 1 && ngay <= 22)
                        {
                            textBoxCHD.Text = "Sư Tử";
                            check2 = true;
                        }
                        else
                        {
                            if (ngay >= 23 && ngay <= 31)
                            {
                                textBoxCHD.Text = "Xử Nữ";
                                check2 = true;
                            }
                        }
                        break;
                    case 9:
                        if (ngay >= 1 && ngay <= 23)
                        {
                            textBoxCHD.Text = "Xử Nữ";
                            check2 = true;
                        }
                        else
                        {
                            if (ngay >= 24 && ngay <= 30)
                            {
                                textBoxCHD.Text = "Thiên Bình";
                                check2 = true;
                            }
                        }
                        break;
                    case 10:
                        if (ngay >= 1 && ngay <= 23)
                        {
                            textBoxCHD.Text = "Thiên Bình";
                            check2 = true;
                        }
                        else
                        {
                            if (ngay >= 24 && ngay <= 31)
                            {
                                textBoxCHD.Text = "Thần Nông";
                                check2 = true;
                            }
                        }
                        break;
                    case 11:
                        if (ngay >= 1 && ngay <= 22)
                        {
                            textBoxCHD.Text = "Thần Nông"; 
                            check2 = true;
                        }
                        else
                        {
                            if (ngay >= 23 && ngay <= 30)
                            {
                                textBoxCHD.Text = "Nhân Mã";
                                check2 = true;
                            }
                        }
                        break;
                    case 12:
                        if (ngay >= 1 && ngay <= 21)
                        {
                            textBoxCHD.Text = "Nhân Mã";
                            check2 = true;
                        }
                        else
                        {
                            if (ngay >= 22 && ngay <= 31)
                            {
                                textBoxCHD.Text = "Bảo Bình";
                                check2 = true;
                            }
                        }
                        break;
                }
                if (!check2)
                {
                    MessageBox.Show("Vui lòng nhập đúng ngày sinh!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxNgaySinh.Text = "";
                    textBoxCHD.Text = "";
                }
            } 
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textBoxNgaySinh.Text = "";
            textBoxCHD.Text = "";
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
