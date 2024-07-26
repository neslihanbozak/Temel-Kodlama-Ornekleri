using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorsel_programlama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = "";
            if (checkBox1.Checked == true)
            {
                metin = metin + checkBox1.Text + "\n";
            }
            if (checkBox2.Checked == true)
            {
                metin = metin + checkBox2.Text + "\n";
            }
            if (checkBox3.Checked == true)
            {
                metin = metin + checkBox3.Text + "\n";
            }
            if (checkBox4.Checked == true)
            {
                metin = metin + checkBox4.Text + "\n";
            }
            label1.Text = metin;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            checkBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox1.Text);
            //checkedListBox1.Items.Add("Mersin");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem.ToString());
            //checkedListBox1.Items.Remove("Sakarya");    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
        }
    }
}
