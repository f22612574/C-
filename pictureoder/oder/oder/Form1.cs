using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace oder
{
   

    public partial class Form1 : Form
    {
        int a, b, c;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = a - 1;
            textBox2.Text = a.ToString();
            if (a <= 0)
                textBox2.Text = "0";
                a = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b = b - 1;
            textBox3.Text = b.ToString();
            if (b <= 0)
                textBox3.Text = "0";
                b = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            c = c + 1;
            textBox4.Text = c.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            c = c - 1;
            textBox4.Text = c.ToString();
            if (c <= 0)
                textBox4.Text = "0";
                c = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (a > 0)
            {
                listBox1.Items.Add("炒麵共 " + a.ToString() + "份");
            }
            if (b > 0)
            {
                listBox1.Items.Add("炒飯共 " + b.ToString() + "份");
            }
            if (c > 0)
            {
                listBox1.Items.Add("皮蛋共 " + c.ToString() + "份");
            }
            button8.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button9.Enabled = true;

            int d = a * 100 + b * 200 + c*10;

            textBox1.Text = d.ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button9.Enabled = false;
            listBox1.Items.Clear();

            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            b = b + 1;
            textBox3.Text = b.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = a + 1;
            textBox2.Text = a.ToString();

        }
    }
}
