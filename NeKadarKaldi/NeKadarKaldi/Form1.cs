using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeKadarKaldi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
            int gunlukSaat = Convert.ToInt32(textBox2.Text);
            if (gunlukSaat <= 24)
            {
                int gun = 1440/ gunlukSaat;
                int ay = gun * 30;
                int yil = gun * 365;
              
                
                // MessageBox.Show("{0} gün , {1} ay , {2} yıl daha yaşıycaksınız:" + gun);\\ay,yil);


            }
            else
            {
               MessageBox.Show("1 Gün 24 saattir !");
            }


           
           
            
         
            
        }
    }
}
