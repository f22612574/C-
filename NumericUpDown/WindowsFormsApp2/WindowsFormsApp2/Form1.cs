using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<string> data = new List<string>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView2.View = View.Details;
            listView1.GridLines = true;
            listView1.LabelEdit = false;
            listView2.GridLines = true;
            listView2.LabelEdit = false;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("SN", 100);
            listView1.Columns.Add("CSN", 100);
            listView1.Columns.Add("PAN", 100);
            listView1.Columns.Add("PNN", 100);
            listView2.Columns.Add("SN", 100);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a,b; int x;
            a = textBox1.Text;
            textBox2.Text = "";
                        

            string goal = "SERIAL_NUMBER";
            string strReplace = a.Replace(goal, "");
            int times = (a.Length - strReplace.Length) / goal.Length; //計算出現幾次SERIAL_NUMBER
            label1.Text = times.ToString();
            string[] sArray = a.Split(new string[] { "{\"code\":\"0\",\"msg\":\"OK\",\"value\":[" }, StringSplitOptions.RemoveEmptyEntries);
            b = sArray[0];
            //移除字串全部,]}3個符號
            string[] charsToRemove = new string[] { ",","]","}" };
            foreach (var c in charsToRemove)
            {
                b= b.Replace(c, string.Empty);
            }
            //////

            string[] sArray1 = b.Split(new string[] { "{\"SERIAL_NUMBER\":", "\"CUSTOMER_SN\":" , "\"PANEL_NO\":", "\"PART_NO\":"}, StringSplitOptions.RemoveEmptyEntries);
            /////驗證用
            x = 4 * times-1;  //計算全部的陣列
            for (int i = 0; i <= x; i++)
            {
               textBox2.Text = textBox2.Text + sArray1[i];
            }
           
           Debug.Print("It is ok.");
            
            for (int i = 0; i <= times; i++)
            {
                if (x<i*4+3)
                { break; }
               
                    var item = new ListViewItem($"{sArray1[0 + (i * 4)]}");
                    item.SubItems.Add($"{sArray1[1 + (i * 4)]}");
                    item.SubItems.Add($"{sArray1[2 + (i * 4)]}");
                    item.SubItems.Add($"{sArray1[3 + (i * 4)]}");
                    listView1.Items.Add(item);
             }


            
        }

        public  void InitialListView(int i,string array)
        {
            

            
            

        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
           
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //精華部分
            listView2.Items.Clear();
            int m = listView1.CheckedItems.Count;
            string[] a = new string[m];
            Queue<string> Q = new Queue<string>();
            
            for (int i = 0; i < m; i++)
            { 
                if (listView1.CheckedItems[i].Checked)
                { 
                    //Q.Enqueue(listView1.CheckedItems[i].SubItems[1].Text);
                    var item = new ListViewItem();
                    
                    string x= listView1.CheckedItems[i].ToString();
                    x = string.Join("", x.Split('"', '{','}','\'',':'));
                    string[] subs=x.Split(new string[] { "ListViewItem"}, StringSplitOptions.RemoveEmptyEntries);
                    
                    //string b=item.SubItems.Add(x).ToString();
                    listView2.Items.Add(subs[0]);
                }
            }
          

        }
    }
}



