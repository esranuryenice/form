using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int loop = 1;
        private void rooldice()
        {




        }
        private void ZarAt()
        {
            Random rnd = new Random();
            int rastgelesayi = rnd.Next(1, 7);
            pictureBox1.ImageLocation = System.IO.Path.GetFullPath("resimler/" + rastgelesayi + ".png");
           rastgelesayi = rnd.Next(1, 7);
            pictureBox2.ImageLocation = System.IO.Path.GetFullPath("resimler/" + rastgelesayi + ".png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            ZarAt();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            ZarAt();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }
    }
}
