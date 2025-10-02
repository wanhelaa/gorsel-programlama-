using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.DeepPink; //moosu butona getirince
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Yellow; 
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            int sayi = 0;  //font büyütür 
            sayi = Convert.ToInt32(label1.Font.Size); sayi += 5;
            label1.Font = new Font("Arial", sayi);
        }

        bool surukleniyor = false;
        Point baslangicNoktasi = new Point(0, 0);
        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Sol tuş ile sürükleme başlasın
            {
                surukleniyor = true;
                baslangicNoktasi = e.Location; // tıklandığı noktayı kaydet
            }
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            if (surukleniyor)
            {
                button5.Left += e.X - baslangicNoktasi.X;
                button5.Top += e.Y - baslangicNoktasi.Y;
            }
        }
        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            surukleniyor = false; // sürükleme bitti
        }
    }
}
