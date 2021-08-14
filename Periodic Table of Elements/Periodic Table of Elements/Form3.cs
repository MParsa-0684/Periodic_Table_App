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
    public partial class Form3 : Form
    {
        int n;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            textBox3.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
            textBox18.Text = "";
            textBox17.Text = "";
            textBox16.Text = "";
            textBox15.Text = "";
            textBox20.Text = "";
            textBox19.Text = "";
            textBox22.Text = "";
            textBox21.Text = "";
            int user;
            int an;
            using(StreamReader sr = new StreamReader("Periodic Table of Elements2.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line != "") {
                        string[] parts = line.Split('$');
                        user = int.Parse(textBox5.Text);
                        an = int.Parse(parts[0]);
                        if (user == an)
                        {
                            n = user;
                            textBox7.Text = parts[0];
                            textBox1.Text = parts[1];
                            textBox2.Text = parts[2];
                            textBox4.Text = parts[3];
                            textBox6.Text = parts[4];
                            textBox8.Text = parts[5];
                            textBox3.Text = parts[6];
                            textBox9.Text = parts[7];
                            textBox10.Text = parts[8];
                            string[] news;
                            news = parts[9].Split('#');
                            textBox11.Text = news[0];
                            textBox12.Text = news[1];
                            news = parts[10].Split('#');
                            textBox14.Text = news[0];
                            textBox13.Text = news[1];
                            news = parts[11].Split('#');
                            textBox18.Text = news[0];
                            textBox17.Text = news[1];
                            news = parts[12].Split('#');
                            textBox16.Text = news[0];
                            textBox15.Text = news[1];
                            news = parts[13].Split('#');
                            textBox20.Text = news[0];
                            textBox19.Text = news[1];
                            news = parts[14].Split('#');
                            textBox22.Text = news[0];
                            textBox21.Text = news[1];
                        }
                    }
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string all = File.ReadAllText("Periodic Table of Elements2.txt");
            string[] elements = all.Split('\r');
            elements[n - 1] = textBox7.Text + "$" + textBox1.Text + "$" + textBox2.Text + "$" + textBox4.Text + "$" + textBox6.Text + "$" + textBox8.Text + "$" + textBox3.Text + "$" + textBox9.Text + "$" + textBox10.Text + "$" + textBox11.Text + "#" + textBox12.Text + "$" + textBox14.Text + "#" + textBox13.Text + "$" + textBox18.Text + "#" + textBox17.Text + "$" + textBox16.Text + "#" + textBox15.Text + "$" + textBox20.Text + "#" + textBox19.Text + "$" + textBox22.Text + "#" + textBox21.Text + "$";
            File.Delete("Periodic Table of Elements2.txt");
            using (StreamWriter SR = new StreamWriter(File.Create("Periodic Table of Elements2.txt")))
            {
                foreach (string element in elements)
                {

                        SR.Write(element+"\r");
                    
                }
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }
    }
}
