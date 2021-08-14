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
    public partial class Form4 : Form
    {
        public int q;
        public int q2;
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

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int i;
            using (StreamReader sr = new StreamReader("Periodic Table of Elements2.txt"))
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


        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control b in this.Controls)
            {
                if (b.BackColor == Color.DarkRed)
                {
                    b.BackColor = Color.White;
                }
            }
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
            t21.Text = "";
            label3.Text = " ";
            label4.Text = " ";
            label5.Text = " ";
            label6.Text = " ";
            label7.Text = " ";
            label8.Text = " ";
            label9.Text = " ";
            label10.Text = " ";
            label11.Text = " ";
            label12.Text = " ";
            label13.Text = " ";
            label14.Text = " ";
            label15.Text = " ";
            label16.Text = " ";
            label18.Text = " ";
            bool yn = false;
            int i = 0;
            int n;
            Random rnd = new Random();
            while (true)
            {
                n = rnd.Next(1,118);
                i = 0;
                while (i < 118)
                {
                    if (n == Element_AtomicNumber[i])
                    {
                        yn = true;
                        break;
                    }
                    else { i++; }
                }

                if (yn == true) { break; }
            }
            foreach (Control b in this.Controls)
            {
                if (b.Name == "P_" + n)
                {
                    b.BackColor = Color.DarkRed;
                }
            }
            string[] news = Element_new1[n-1].Split('#');
            t9.Text = news[0];
            news = Element_new2[n - 1].Split('#');
            t11.Text = news[0];
            news = Element_new3[n - 1].Split('#');
            t13.Text = news[0];
            news = Element_new4[n - 1].Split('#');
            t15.Text = news[0];
            news = Element_new5[n - 1].Split('#');
            t17.Text = news[0];
            news = Element_new6[n - 1].Split('#');
            t19.Text = news[0];

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = "";
            foreach (Control b in this.Controls)
            {
                if (b.BackColor == Color.DarkRed)
                {
                    a = b.Name;
                }
            }
            string[] parts = a.Split('_');
            int f = int.Parse(parts[1]) - 1;
            if (t1.Text == Element_Name[f])
            {
                label6.Text = "✔";
            }
            else { label6.Text = "❌"; }
            if (t2.Text == Element_Symbol[f])
            {
                label3.Text = "✔";
            }
            else { label3.Text = "❌"; }
            if (int.Parse(t3.Text) == Element_AtomicNumber[f])
            {
                label4.Text = "✔";
            }
            else { label4.Text = "❌"; }

            if (t4.Text == Element_Period[f])
            {
                label5.Text = "✔";
            }
            else { label5.Text = "❌"; }
            if (t5.Text == Element_Group[f])
            {
                label7.Text = "✔";
            }
            else { label7.Text = "❌"; }
            if (t6.Text == Element_Category[f])
            {
                label8.Text = "✔";
            }
            else { label8.Text = "❌"; }
            if (t7.Text == Element_Block[f])
            {
                label9.Text = "✔";
            }
            else { label9.Text = "❌"; }
            if (t8.Text == Element_LastUnderLayer[f])
            {
                label10.Text = "✔";
            }
            else { label10.Text = "❌"; }
            string[] u = Element_new1[f].Split('#');
            if (t10.Text == u[1])
            {
                label18.Text = "✔";
            }
            else { label18.Text = "❌"; }
            u = Element_new2[f].Split('#');
            if (t12.Text == u[1])
            {
                label12.Text = "✔";
            }
            else { label12.Text = "❌"; }
            u = Element_new3[f].Split('#');
            if (t14.Text == u[1])
            {
                label13.Text = "✔";
            }
            else { label13.Text = "❌"; }
            u = Element_new4[f].Split('#');
            if (t16.Text == u[1])
            {
                label14.Text = "✔";
            }
            else { label14.Text = "❌"; }
            u = Element_new5[f].Split('#');
            if (t18.Text == u[1])
            {
                label15.Text = "✔";
            }
            else { label15.Text = "❌"; }
            u = Element_new6[f].Split('#');
            if (t20.Text == u[1])
            {
                label16.Text = "✔";
            }
            else { label16.Text = "❌"; }
            if (t21.Text == Element_Address[f])
            {
                label11.Text = "✔";
            }
            else { label11.Text = "❌"; }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            q = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control b in this.Controls)
            {
                if (b.BackColor == Color.DarkRed)
                {
                    b.BackColor = Color.White;
                }
            }
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
            t21.Text = "";
            label3.Text = " ";
            label4.Text = " ";
            label5.Text = " ";
            label6.Text = " ";
            label7.Text = " ";
            label8.Text = " ";
            label9.Text = " ";
            label10.Text = " ";
            label11.Text = " ";
            label12.Text = " ";
            label13.Text = " ";
            label14.Text = " ";
            label15.Text = " ";
            label16.Text = " ";
            label18.Text = " ";
            bool yn = false;
            int i = 0;
            int n;
            Random rnd = new Random();
            
            while (true)
            {
                n = rnd.Next(1, 118);
                i = 0;
                while (i < 118)
                {
                    if (n == Element_AtomicNumber[i])
                    {
                        yn = true;
                        break;
                    }
                    else { i++; }
                }

                if (yn == true) { break; }
            }
            if (q == 1)
            {
                t1.Text = Element_Name[i];
            }
            if (q == 2)
            {
                t2.Text = Element_Symbol[i];
            }
            if (q == 3)
            {
                t3.Text = Convert.ToString(Element_AtomicNumber[i]);
            }
            if (q == 4)
            {
                t4.Text = Convert.ToString(Element_Period[i]);
            }
            if (q == 5)
            {
                t5.Text = Convert.ToString(Element_Group[i]);
            }
            if (q == 6)
            {
                t6.Text = Element_Category[i];
            }
            if (q == 7)
            {
                t7.Text = Element_Block[i];
            }
            if (q == 8)
            {
                t8.Text = Element_LastUnderLayer[i];
            }
            if (q == 9)
            {
                t21.Text = Element_Address[i];
            }
            string[] news = Element_new1[i].Split('#');
            t9.Text = news[0];
            news = Element_new2[i].Split('#');
            t11.Text = news[0];
            news = Element_new3[i].Split('#');
            t13.Text = news[0];
            news = Element_new4[i].Split('#');
            t15.Text = news[0];
            news = Element_new5[i].Split('#');
            t17.Text = news[0];
            news = Element_new6[i].Split('#');
            t19.Text = news[0];
            q2 = i;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            q = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            q = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            q = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            q = 5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            q = 6;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            q = 7;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            q = 8;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            q = 9;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int f = q2;
            if (t1.Text == Element_Name[f])
            {
                label6.Text = "✔";
            }
            else { label6.Text = "❌"; }
            if (t2.Text == Element_Symbol[f])
            {
                label3.Text = "✔";
            }
            else { label3.Text = "❌"; }
            if (int.Parse(t3.Text) == Element_AtomicNumber[f])
            {
                label4.Text = "✔";
            }
            else { label4.Text = "❌"; }

            if (t4.Text == Element_Period[f])
            {
                label5.Text = "✔";
            }
            else { label5.Text = "❌"; }
            if (t5.Text == Element_Group[f])
            {
                label7.Text = "✔";
            }
            else { label7.Text = "❌"; }
            if (t6.Text == Element_Category[f])
            {
                label8.Text = "✔";
            }
            else { label8.Text = "❌"; }
            if (t7.Text == Element_Block[f])
            {
                label9.Text = "✔";
            }
            else { label9.Text = "❌"; }
            if (t8.Text == Element_LastUnderLayer[f])
            {
                label10.Text = "✔";
            }
            else { label10.Text = "❌"; }
            string[] u = Element_new1[f].Split('#');
            if (t10.Text == u[1])
            {
                label18.Text = "✔";
            }
            else { label18.Text = "❌"; }
            u = Element_new2[f].Split('#');
            if (t12.Text == u[1])
            {
                label12.Text = "✔";
            }
            else { label12.Text = "❌"; }
            u = Element_new3[f].Split('#');
            if (t14.Text == u[1])
            {
                label13.Text = "✔";
            }
            else { label13.Text = "❌"; }
            u = Element_new4[f].Split('#');
            if (t16.Text == u[1])
            {
                label14.Text = "✔";
            }
            else { label14.Text = "❌"; }
            u = Element_new5[f].Split('#');
            if (t18.Text == u[1])
            {
                label15.Text = "✔";
            }
            else { label15.Text = "❌"; }
            u = Element_new6[f].Split('#');
            if (t20.Text == u[1])
            {
                label16.Text = "✔";
            }
            else { label16.Text = "❌"; }
            if (t21.Text == Element_Address[f])
            {
                label11.Text = "✔";
            }
            else { label11.Text = "❌"; }
            if (q == 1)
            {
                label6.Text = " ";
            }
            if (q == 2)
            {
                label3.Text = " ";
            }
            if (q == 3)
            {
                label4.Text = " ";
            }
            if (q == 4)
            {
                label5.Text = " ";
            }
            if (q == 5)
            {
                label7.Text = " ";
            }
            if (q == 6)
            {
                label8.Text = " ";
            }
            if (q == 7)
            {
                label9.Text = " ";
            }
            if (q == 8)
            {
                label10.Text = " ";
            }
            if (q == 9)
            {
                label11.Text = " ";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }
    }
}
