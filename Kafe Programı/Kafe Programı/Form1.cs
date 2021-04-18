using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafe_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double tutar = 0;
        double stutar = 0;
        double cay, kahve, tost, su, cikolata;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }
        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox4.Enabled = true;
            }
            else
            {
                textBox4.Enabled = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                textBox5.Enabled = true;
            }
            else
            {
                textBox5.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (checkBox1.Checked)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Çay Adetini Girmediniz.");
                }
                else
                {
                    cay = Convert.ToDouble(textBox1.Text);
                    tutar += cay * 0.75;
                    listBox1.Items.Add(cay + " Adet Çay " + cay * 0.75 + " TL");
                }
            }

            if (checkBox2.Checked)
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Kahve Adetini Girmediniz.");
                }
                else
                {
                    kahve = Convert.ToDouble(textBox2.Text);
                    tutar += kahve * 1;
                    listBox1.Items.Add(kahve + " Adet Kahve " + kahve * 1 + " TL");
                }
            }

            if (checkBox3.Checked)
            {
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Tost Adetini Girmediniz.");
                }
                else
                {
                    tost = Convert.ToDouble(textBox3.Text);
                    tutar += tost * 3;
                    listBox1.Items.Add(tost + " Adet Tost " + tost * 3 + " TL");
                }
            }

            if (checkBox4.Checked)
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("Su Adetini Girmediniz.");
                }
                else
                {
                    su = Convert.ToDouble(textBox4.Text);
                    tutar += su * 1;
                    listBox1.Items.Add(su + " Adet Su " + su * 1 + " TL");
                }
            }

            if (checkBox5.Checked)
            {
                if (textBox5.Text == "")
                {
                    MessageBox.Show("Çikolata Adetini Girmediniz.");
                }
                else
                {
                    cikolata = Convert.ToDouble(textBox5.Text);
                    tutar += cikolata * 3;
                    listBox1.Items.Add(cikolata + " Adet Çikolata " + cikolata * 3 + " TL");
                }
            }

            tutar = cay * 0.75 + kahve * 1 + tost * 3 + su * 1 + cikolata * 3;


            if (checkBox6.Checked)
            {
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("Genel Tutar : " + tutar);
                stutar = tutar * 0.5;
                listBox1.Items.Add("Süper Pazartesi İndirimi : " + stutar);
            }

            if (checkBox7.Checked)
            {
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("Genel Tutar : " + tutar);
                stutar = tutar * 0.1;
                listBox1.Items.Add("Süper Salı İndirimi : " + stutar);
            }

            if (checkBox8.Checked)
            {
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("Genel Tutar : " + tutar);
                stutar = tutar * 0.8;
                listBox1.Items.Add("Süper Çarşamba İndirimi : " + stutar);
            }

            if (checkBox9.Checked)
            {
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("Genel Tutar : " + tutar);
                stutar = tutar * 0.3;
                listBox1.Items.Add("Süper Perşembe İndirimi : " + stutar);
            }

            if (checkBox10.Checked)
            {
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("Genel Tutar : " + tutar);
                stutar = tutar * 0.2;
                listBox1.Items.Add("Süper Cuma İndirimi : " + stutar);
            }

            if (checkBox11.Checked)
            {
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("Genel Tutar : " + tutar);
                stutar = tutar * 0.4;
                listBox1.Items.Add("Süper Cumartesi İndirimi : " + stutar);
            }

            if (checkBox12.Checked)
            {
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("Genel Tutar : " + tutar);
                stutar = tutar * 0.3;
                listBox1.Items.Add("Süper Pazar İndirimi : " + stutar);
            }

            if (tutar >= 20 && tutar < 50)
            {
                tutar = tutar * 0.9;
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("Tutarda %10 indirim yapıldı.");
                listBox1.Items.Add("İndirimli Tutar : " + tutar);
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("Genel Tutar : " + (tutar-stutar));
            }

            else if(tutar >= 50)
            {
                tutar = tutar * 0.8;
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("Tutarda %20 indirim yapıldı.");
                listBox1.Items.Add("İndirimli Tutar : " + tutar);
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("Genel Tutar : " + (tutar - stutar));
            }
            else
            {
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("Genel Tutar : " + tutar);
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("Genel Tutar : " + (tutar - stutar));
            }

        }
    }
}
