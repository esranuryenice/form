using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otobusfirmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbox_otobüstürü_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_otobüstürü.SelectedItem.ToString() == "Travego")
            {
                #region travego


                int counter = 1;
                panel_travego.Visible = true;
                panel_setra.Visible = false;

                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((j != 2 || i == 11) && (i != 5 || j < 2))
                        {
                            Button btn = new Button();
                            btn.Click += Button_Click;
                            btn.Width = 30;
                            btn.Height = 30;
                            btn.Text = counter + " ";
                            btn.BackColor = Color.Aqua;
                            btn.Left = (btn.Width * j) /*+ 250*/;
                            btn.Top = (btn.Height * i) /*+ 100*/;
                            panel_travego.Controls.Add(btn);
                            counter++;


                        }



                    }
                }
                #endregion
            }

            else
            {
                #region setra
                int counter = 1;
                panel_travego.Visible = false;
                panel_setra.Visible = true;

                for (int i = 0; i < 13; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((j != 2 || i == 12) && (i != 6 || j < 2))
                        {
                            Button btn = new Button();
                            btn.Click += Button_Click;
                            btn.Width = 30;
                            btn.Height = 30;
                            btn.Text = counter + " ";
                            btn.BackColor = Color.Aqua;
                            btn.Left = (btn.Width * j) /*+ 250*/;
                            btn.Top = (btn.Height * i) /*+ 100*/;
                            panel_setra.Controls.Add(btn);
                            counter++;


                        }



                    }

                }
                #endregion
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button secilenkoltuk = sender as Button;
            lblKoltuk_No.Text = secilenkoltuk.Text;
            lbl_otobusTürü.Text = cbox_otobüstürü.SelectedItem.ToString();

            if (lbl_otobusTürü.Text == "Travego")
            {
                string yolcu = travegoyolcularIsim[int.Parse(secilenkoltuk.Text) - 1];
                if (yolcu != " ")
                {
                    txt_ad_soyad.Text = yolcu;
                    string cinsiyet = travegoyolcularcinsiyet[int.Parse(lblKoltuk_No.Text) - 1];
                    if (cinsiyet == "Erkek")
                    {
                        rdbtn_erkek.Checked = true;
                    }
                    else
                    {
                        rdbtn_kadin.Checked = true;

                    }
                }

                else
                {

                }
            }
            else
            {

            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel_travego.Visible = false; ;
            panel_setra.Visible = false; ;
        }
        string[] travegoyolcularIsim = new string[60];
        string[] setrayolcularIsim = new string[60];
        string[] travegoyolcularcinsiyet = new string[60];
        string[] setrayolcularcinsiyet = new string[60];
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (lbl_otobusTürü.Text == "Travego")
            {
                travegoyolcularIsim[int.Parse(lblKoltuk_No.Text) - 1] = txt_ad_soyad.Text;
                string cinsiyet;
                if (rdbtn_erkek.Checked)
                {
                    cinsiyet = "Erkek";
                }
                else
                {
                    cinsiyet = "Kadın";
                }
                travegoyolcularcinsiyet[int.Parse(lblKoltuk_No.Text) - 1] = cinsiyet;
            }
            else
            {
                setrayolcularIsim[int.Parse(lblKoltuk_No.Text) - 1] = txt_ad_soyad.Text;
                string cinsiyet;
                if (rdbtn_erkek.Checked)
                {
                    cinsiyet = "Erkek";
                }
                else
                {
                    cinsiyet = "Kadın";
                }
                setrayolcularcinsiyet[int.Parse(lblKoltuk_No.Text) - 1] = cinsiyet;
            }
            txt_ad_soyad.Text = "";
            lblKoltuk_No.Text = "0";
            lbl_otobusTürü.Text = "-";
        }

    }
}
