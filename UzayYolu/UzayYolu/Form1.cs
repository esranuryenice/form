using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UzayYolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bomba_atma.Visible = false;
        }
        int genislik;
        int yükseklik;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            genislik = Form1.ActiveForm.Width;
            yükseklik = Form1.ActiveForm.Height;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    //case Keys.A:
                    heart_box.Left -= 10;
                    break;
                case Keys.Right:
                    // case Keys.D:
                    heart_box.Left += 10;
                    break;
                case Keys.Up:
                    // case Keys.W:
                    heart_box.Top -= 10;
                    break;
                case Keys.Down:
                    // case Keys.S:
                    heart_box.Top += 10;
                    break;
                case Keys.Space:
                    int x = heart_box.Location.X + heart_box.Width / 2;
                    int y = heart_box.Location.Y + heart_box.Height / 2;
                    bomba_atma.Location = new Point(x, y);
                    bomba_atma.Visible = true;
                    timer1.Start();
                    break;
                default:
                    break;
            }

            int SpaceX = heart_box.Location.X;
            int SpaceY = heart_box.Location.Y;
            if (SpaceX > genislik - heart_box.Width || SpaceX <= 0)
            {
                MessageBox.Show("Lanet olsun!Oyun bitti.");
                Application.Exit();
            }
            else if (SpaceY > yükseklik - heart_box.Height || SpaceY <= 0)
            {
                MessageBox.Show("Lanet olsun!Oyun bitti.");
                heart_box.Location = new Point(10,10);
               // Application.Exit();
            }



        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            genislik = Form1.ActiveForm.Width;
            yükseklik = Form1.ActiveForm.Height;
            
                if (bomba_atma.Location.X < genislik - bomba_atma.Width * 2)
                {
                    bomba_atma.Left += 10;
                }
                else
                {
                    timer1.Stop();
                }
            
            

        }
    }
}
