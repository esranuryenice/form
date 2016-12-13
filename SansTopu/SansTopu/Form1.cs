using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SansTopu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        List<int> sayilar = new List<int>(6);
        int rastgeleSayi;
        int sayac = 0;
        int tur = 1;
        private void btn_oyna_Click(object sender, EventArgs e)
        {
            timer1.Start();
            tur = 1;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tur>=15)
            {
                timer1.Interval = 250;
            }
            else
            {
                timer1.Interval = 10;
            }
            if (tur%20==0)
            {
                timer1.Stop();
            }
            else
            {
                sayilar.Clear();
                while (sayac < 6)
                {
                    rastgeleSayi = rnd.Next(1, 50);
                    if (!sayilar.Contains(rastgeleSayi))
                    {
                        sayilar.Add(rastgeleSayi);
                        sayac++;
                    }
                }
                sayilar.Sort();
                label1.Text = sayilar[0].ToString();
                label2.Text = sayilar[1].ToString();
                label3.Text = sayilar[2].ToString();
                label4.Text = sayilar[3].ToString();
                label5.Text = sayilar[4].ToString();
                label6.Text = sayilar[5].ToString();
              

            }
            sayac = 0;
            tur++;
            
        }
    }
   }

