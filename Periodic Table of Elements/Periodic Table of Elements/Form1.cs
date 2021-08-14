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

namespace Periodic_Table_of_Elements
{
    public partial class Form1 : Form
    {
        public int[] Element_AtomicNumber = new int[118];
        public string[] Element_Name = new string[118];
        public string[] Element_Symbol = new string[118];
        public string[] Element_Period = new string[118];
        public string[] Element_Group = new string[118];
        public string[] Element_Category = new string[118];
        public string[] Element_Block = new string[118];
        public string[] Element_LastUnderLayer = new string[118];
        public string[] Element_Address = new string[118];
        public string[] Element_new1 = new string[118];
        public string[] Element_new2 = new string[118];
        public string[] Element_new3 = new string[118];
        public string[] Element_new4 = new string[118];
        public string[] Element_new5 = new string[118];
        public string[] Element_new6 = new string[118];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            using(StreamReader sr = new StreamReader("Periodic Table of Elements2.txt"))
            {
                
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line != "")
                    {
                        string[] parts = line.Split('$');
                        i = int.Parse(parts[0]) - 1;
                        Element_AtomicNumber[i] = int.Parse(parts[0]);
                        Element_Name[i] = parts[1];
                        Element_Symbol[i] = parts[2];
                        Element_Period[i] = parts[3];
                        Element_Group[i] = parts[4];
                        Element_Category[i] = parts[5];
                        Element_Block[i] = parts[6];
                        Element_LastUnderLayer[i] = parts[7];
                        Element_Address[i] = parts[8];
                        Element_new1[i] = parts[9];
                        Element_new2[i] = parts[10];
                        Element_new3[i] = parts[11];
                        Element_new4[i] = parts[12];
                        Element_new5[i] = parts[13];
                        Element_new6[i] = parts[14];

                    }
                }
}
            for(int m =1; m < 119; m++)
            {
                foreach (Control c in this.Controls)
                {
                    if (c.Name == "P_" + m)
                    {
                        c.Text = Element_AtomicNumber[m - 1] + "\n" + Element_Symbol[m - 1] + "\n" + Element_Name[m - 1];

                    }
                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Element_Click(object sender, EventArgs e)
        {
            foreach (Control b in this.Controls)
            {
                if (b.BackColor == Color.DarkRed)
                {
                    b.BackColor = Color.White;
                }
            }
            var parts = ((Button)sender).Name.Split('_');
            int i = int.Parse(parts[1]) - 1;
            t3.Text = parts[1];
            t1.Text = Element_Name[i];
            t2.Text = Element_Symbol[i];
            t4.Text = Convert.ToString(Element_Period[i]);
            t5.Text = Convert.ToString(Element_Group[i]);
            t6.Text = Element_Category[i];
            t7.Text = Element_Block[i];
            t8.Text = Element_LastUnderLayer[i];
            string[] news = Element_new1[i].Split('#');
            t9.Text = news[0];
            t10.Text = news[1];
            news = Element_new2[i].Split('#');
            t11.Text = news[0];
            t12.Text = news[1];
            news = Element_new3[i].Split('#');
            t13.Text = news[0];
            t14.Text = news[1];
            news = Element_new4[i].Split('#');
            t15.Text = news[0];
            t16.Text = news[1];
            news = Element_new5[i].Split('#');
            t17.Text = news[0];
            t18.Text = news[1];
            news = Element_new6[i].Split('#');
            t19.Text = news[0];
            t20.Text = news[1];

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
            t5.Text = "";
            t6.Text = "";
            t7.Text = "";
            t8.Text = "";
            t9.Text = "";
            t10.Text = "";
            t11.Text = "";
            t12.Text = "";
            t13.Text = "";
            t14.Text = "";
            t15.Text = "";
            t16.Text = "";
            t17.Text = "";
            t18.Text = "";
            t19.Text = "";
            t20.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }
    }
}
