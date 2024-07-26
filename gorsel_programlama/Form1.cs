using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorsel_programlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("merhaba Neslihan hanım"); //Buton1 e tıklandığında ekrana mesaj kutusuyla merhaba yazar.
            //button2.BackColor = Color.Pink;
            //button1.BackColor = Color.LightBlue;
            if (button1.BackColor==Color.Magenta)
            {
                button1.BackColor = Color.LightBlue;
                button2.BackColor = Color.Pink;
            }
            else
            {
                button1.BackColor = Color.LightBlue;
                button2.BackColor = Color.Pink;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button1.BackColor = Color.Black;  //Buton 2 ye tıklandığında buton 1 in rengini değiştirir.
            //button2.BackColor = Color.LightBlue;
            //button1.BackColor = Color.Pink;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Magenta;
            button2.BackColor = Color.CornflowerBlue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Magenta;
            button2.BackColor = Color.CornflowerBlue;
        }

        private void button2_BackColorChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Zemin Rengi Değişti"); //Button 2 nin rengi değiştiğinde mesaj verir.
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            this.Text = "Herhangi bir Tuşa Basılıdı";
        }
    }
}
