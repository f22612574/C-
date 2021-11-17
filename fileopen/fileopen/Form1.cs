using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace fileopen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("C:\\Users\\roy_shih\\Desktop\\Git\\C#\\fileopen\\temp.txt");
            FileStream fs = fi.Create();
            fs.Close();
            label1.Text = "OK";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
