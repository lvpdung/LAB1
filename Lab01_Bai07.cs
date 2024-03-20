using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB1
{
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textBoxSV.Text = "";
            textBoxHoTen.Text = "";
            textBoxDiem.Text = "";
            textBoxDTB.Text = "";
            textBoxMax.Text = "";
            textBoxMin.Text = "";
            textBoxDau.Text = "";
            textBoxRot.Text = "";
            textBoxXepLoai.Text = "";
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            bool check = true;
            string SV = textBoxSV.Text;    
            string HoTen = "";
            int i = 0;
            while (SV[i] != ',')
            {
                HoTen += SV[i];
                i++;
            }
            i += 2;
            string DSDiem = "";
            List<string> Diem = new List<string>();
            List<float> DiemSo = new List<float>();
            while (i < SV.Length)
            {
                string Tam = "";
                while (i < SV.Length && SV[i] != ',' && SV[i] != ' ')
                {
                    Tam += SV[i];
                    i++;
                }
                float tam;
                if (!float.TryParse(Tam, out tam))
                {
                    check = false;
                    break;
                }
                else
                {
                    Diem.Add(Tam);
                    i += 2;
                    DiemSo.Add(float.Parse(Tam));
                    if (DiemSo.Last() < 0 || DiemSo.Last() > 10)
                    {
                        check = false;
                        break;
                    }
                    DSDiem += "Môn " + Diem.Count + ": " + Diem.Last() + Environment.NewLine;
                }
            }
            textBoxDiem.Text = DSDiem;
            float Max = DiemSo.First();
            float Min = DiemSo.First();
            float DTB = 0;
            int Dau = 0, Rot = 0;
            foreach (var tam in DiemSo)
            {
                if (Max < tam)
                {
                    Max = tam;
                }
                if (Min > tam)
                {
                    Min = tam;
                }
                DTB += tam;
                if (tam >= 5)
                {
                    Dau++;
                }
                else
                {
                    Rot++;
                }
            }
            DTB = DTB / DiemSo.Count;
            string XepLoai = "";
            bool Gioi = false, Kha = false, TB = false, Yeu = false;
            if (DTB >= 8)
            {
                Gioi = true;
                foreach (var tam in DiemSo)
                {
                    if (tam < 6.5)
                    {
                        Gioi = false;
                        break;
                    }
                }    
            }
            else
            {
                if (DTB >= 6.5)
                {
                    Kha = true;
                    foreach (var tam in DiemSo)
                    {
                        if (tam < 5)
                        {
                            Kha = false;
                            break;
                        }
                    }
                }
                else
                {
                    if (DTB >= 5)
                    {
                        TB = true;
                        foreach (var tam in DiemSo)
                        {
                            if (tam < 3.5)
                            {
                                TB = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        Yeu = true;
                        if (DTB >= 3.5)
                        {
                            foreach (var tam in DiemSo)
                            {
                                if (tam < 2)
                                {
                                    Yeu = false;
                                    break;
                                }
                            }
                        }
                    
                    }
                }    
                
            }
            if (Gioi)
            {
                XepLoai = "Giỏi";
            }
            else
            {
                if (Kha)
                {
                    XepLoai = "Khá";
                } 
                else
                {
                    if (TB)
                    {
                        XepLoai = "TB";
                    }
                    else
                    {
                        if (Yeu)
                        {
                            XepLoai = "Yếu";
                        }
                        else
                        {
                            XepLoai = "Kém";
                        }
                    }    
                }    
            }

            if (!check)
            {
                textBoxDiem.Text = "";
                MessageBox.Show("Vui lòng đúng định dạng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSV.Text = "";
                textBoxHoTen.Text = "";
                textBoxDTB.Text = "";
                textBoxMax.Text = "";
                textBoxMin.Text = "";
                textBoxDau.Text = "";
                textBoxRot.Text = "";
                textBoxXepLoai.Text = "";
            }    
            else
            {
                textBoxHoTen.Text = HoTen;
                textBoxMax.Text = Max.ToString();
                textBoxMin.Text = Min.ToString();
                textBoxMax.Text = Max.ToString();
                textBoxDTB.Text = DTB.ToString();
                textBoxDau.Text = Dau.ToString();
                textBoxRot.Text = Rot.ToString();
                textBoxXepLoai.Text = XepLoai;
            }    
        }
    }
}
