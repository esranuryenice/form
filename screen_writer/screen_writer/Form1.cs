using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screen_writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> isimler = new List<string>() { "Esranur", "Çeyiz", "Halil", "Bengisu", "Hakan", "Yunus", "Yankı", "OzanK", "Aytekin", "OzanA", "İrfanÇ", "Cemal", "Merve", "Atakan" };
        Random rnd = new Random();
        int sayac = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int index = rnd.Next(0,14);
            string isim =isimler[index];

            Graphics g = CreateGraphics();
            int red = rnd.Next(0,256);
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);
            int x = rnd.Next(10,this.Width-50);
            int y = rnd.Next(10, this.Height - 50);
            int fontsize = rnd.Next(20,40);

            g.DrawString(isim,new Font(FontFamily.GenericSansSerif,fontsize,FontStyle.Bold),new SolidBrush(Color.FromArgb(red,green,blue)),x,y);
            if (sayac==200)
            {
                this.Invalidate();
                sayac = 0;
            }
            sayac++;
        }
    }
}
