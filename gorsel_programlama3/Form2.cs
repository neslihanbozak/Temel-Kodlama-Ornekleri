using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorsel_programlama3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal deger = numericUpDown1.Value;
            listBox1.Items.Add(deger);
            this.BackColor = Color.SeaGreen;
            this.BackColor = System.Drawing.Color.FromArgb(0, 0, (Convert.ToInt32(deger)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        int sayac = 0;
        private void button8_Click(object sender, EventArgs e)
        {
            sayac++;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            if (sayac < 9)
            {
                pictureBox2.ImageLocation = @"C:\Users\Neslihan\Desktop\KİTAPLIK\ÜNİ Dersler\Görsel Programlama\image\" + sayac + ".jpg";
            }
            else
                sayac = 0;

        }

        private void button6_Click(object sender, EventArgs e)
        {

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            if (sayac > 0)
            {
                sayac--;
                pictureBox2.ImageLocation = @"C:\Users\Neslihan\Desktop\KİTAPLIK\ÜNİ Dersler\Görsel Programlama\image\" + sayac + ".jpg";
            }
            else
                sayac = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            if (sayac < 9)
            {
                pictureBox2.ImageLocation = @"C:\Users\Neslihan\Desktop\KİTAPLIK\ÜNİ Dersler\Görsel Programlama\image\" + sayac + ".jpg";
                progressBar1.Value += 10;
            }
            else
            { 
                sayac = 0;
                progressBar1.Value = 0;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(numericUpDown2.Value);
            decimal sayi = numericUpDown2.Value;
            //progressBar1.Value += Convert.ToInt32(sayi);
            listBox2.Items.Add(sayi);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string topic = richTextBox1.Text;
            listBox3.Items.Add(topic);
        }


        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void kESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kOPYALAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yAPIŞTIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void gERİALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add( richTextBox1.CanUndo.ToString());
        }

        private void iLERİALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(richTextBox1.CanRedo.ToString());    
        }


        private void button11_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad=textBox2.Text;
            string telefon=textBox3.Text;
            string email=textBox4.Text; 
            string meslek=textBox5.Text;
              
            listBox4.Items.Add(ad); 
            listBox4.Items.Add("\n");
            listBox4.Items.Add(soyad);
            listBox4.Items.Add("\n");
            listBox4.Items.Add(telefon);
            listBox4.Items.Add("\n");
            listBox4.Items.Add(email);
            listBox4.Items.Add("\n------------------------------\n");
            listBox4.Items.Add(meslek);
            listBox4.Items.Add("\n");

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "Lütfen İsim giriniz");
            toolTip1.SetToolTip(textBox2, "Lütfen Soy İsim giriniz");
            toolTip1.SetToolTip(textBox3, "Lütfen Telefon giriniz");
            toolTip1.SetToolTip(textBox4, "Lütfen E-Mail adresinizi giriniz");
            toolTip1.SetToolTip(textBox5, "Lütfen Meslek giriniz");
            toolTip1.SetToolTip(button11, "Verileri Listelemek İçin Tıklayınız");
        }
    }
}
