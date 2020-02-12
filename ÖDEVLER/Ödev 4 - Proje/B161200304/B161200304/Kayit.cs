using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B161200304
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        private void Enbled(bool a, bool b, bool c, bool d, bool f, bool g, bool h, bool j, bool k, bool l, bool i)
        {
            textBox1.Focus();
            button1.Enabled = a;
            button2.Enabled = b;
            button3.Enabled = c;
            button4.Enabled = d;
            textBox2.Enabled = f;
            textBox3.Enabled = g;
            textBox4.Enabled = h;
            textBox5.Enabled = j;
            textBox6.Enabled = k;
            checkBox1.Enabled = l;
            checkBox2.Enabled = i;
        }

        private void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            button1_Click(button1, new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enbled(false, true, true, true, false, false, false, false, false, false, false);
            Temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enbled(true, false, true, true, true, true, false, true, false, true, true);
            Temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Enbled(true, true, false, true, true, true, true, true, false, false, false);
            Temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Enbled(true, true, true, false, true, true, false, true, true, false, false);
            Temizle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tuvalet = "Yok";
            string banyo = "Yok";
            string kiraliksatilik = "Hiçbiri";
            if (checkBox1.Checked == true) { tuvalet = "Var"; }
            if (checkBox2.Checked == true) { banyo = "Var"; }
            if (radioButton1.Checked == true) { kiraliksatilik = "Kiralık"; }
            else if (radioButton2.Checked == true ) { kiraliksatilik = "Satılık"; }

            if (button1.Enabled == false)
            {
                Arsa arsa = new Arsa();
                arsa.ArsaEkle(Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox9.Text), textBox7.Text, textBox8.Text);
                Ofis.Arsa.Add(arsa);
            }
            else if (button2.Enabled == false)
            {
                Daire daire = new Daire();
                daire.DaireEkle(Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox9.Text), textBox7.Text, textBox8.Text,
                    Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text), tuvalet, banyo);
                Ofis.Daire.Add(daire);
            }
            else if (button3.Enabled == false)
            {
                Konut konut = new Konut();
                konut.KonutEkle(Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox9.Text), textBox7.Text, textBox8.Text,
                    Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox4.Text));
                Ofis.Konut.Add(konut);
            }
            else if (button4.Enabled == false)
            {
                Apartman apartman = new Apartman();
                apartman.ApartmanEkle(Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox9.Text), textBox7.Text, textBox8.Text,
                    Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                Ofis.Apartman.Add(apartman);
            }

            Temizle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu menu = (Menu)Application.OpenForms["Menu"];
            menu.Show();
            this.Close();
        }
    }
}
