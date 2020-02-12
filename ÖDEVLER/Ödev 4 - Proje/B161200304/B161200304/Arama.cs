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
    public partial class Arama : Form
    {
        public Arama()
        {
            InitializeComponent();
        }

        private void Enbled(bool a, bool b, bool c, bool d)
        {
            textBox1.Focus();
            button1.Enabled = a;
            button2.Enabled = b;
            button3.Enabled = c;
            button4.Enabled = d;
        }

        private void Temizle()
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void SutunGizle(bool a, bool b, bool c, bool d, bool e, bool f, bool g)
        {
            dataGridView1.Columns[6].Visible = a;
            dataGridView1.Columns[7].Visible = b;
            dataGridView1.Columns[8].Visible = c;
            dataGridView1.Columns[9].Visible = d;
            dataGridView1.Columns[10].Visible = e;
            dataGridView1.Columns[11].Visible = f;
            dataGridView1.Columns[12].Visible = g;
        }

        private void Arama_Load(object sender, EventArgs e)
        {
            button1_Click(button1, new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ofis.Arsa.ToList();
            Enbled(false, true, true, true);
            Temizle();
            SutunGizle(false, false, false, false, false, false, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ofis.Daire.ToList();
            Enbled(true, false, true, true);
            Temizle();
            SutunGizle(true, true, true, false, false, true, true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ofis.Konut.ToList();
            Enbled(true, true, false, true);
            Temizle();
            SutunGizle(true, true, true, true, false, false, false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ofis.Apartman.ToList();
            Enbled(true, true, true, false);
            Temizle();
            SutunGizle(true, true, true, false, true, false, false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string kiraliksatilik = "Hiçbiri";
            if (radioButton1.Checked == true) { kiraliksatilik = "Kiralık"; }
            else if (radioButton2.Checked == true) { kiraliksatilik = "Satılık"; }

            if (button1.Enabled == false)
            {
                Arsa x = new Arsa();
                if (textBox1.Text != "" && textBox4.Text != "" && textBox5.Text != "" && kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                else if (textBox4.Text != "" && textBox5.Text != "" && kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Ara(kiraliksatilik, Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                else if (textBox1.Text != "" && textBox5.Text != "" && kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox5.Text));
                else if (textBox1.Text != "" && textBox4.Text != "" && kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Araa(Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox4.Text));
                else if (textBox1.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                else if (textBox4.Text != "" && textBox5.Text != "")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                else if (textBox1.Text != "")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox1.Text));
                else if (kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Ara(kiraliksatilik);
            }
            else if (button2.Enabled == false)
            {
                Daire x = new Daire();
                if (textBox1.Text != "" && textBox4.Text != "" && textBox5.Text != "" && kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                else if (textBox4.Text != "" && textBox5.Text != "" && kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Ara(kiraliksatilik, Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                else if (textBox1.Text != "" && textBox5.Text != "" && kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox5.Text));
                else if (textBox1.Text != "" && textBox4.Text != "" && kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Araa(Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox4.Text));
                else if (textBox1.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                else if (textBox4.Text != "" && textBox5.Text != "")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                else if (textBox1.Text != "")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox1.Text));
                else if (kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Ara(kiraliksatilik);
            }
            else if (button3.Enabled == false)
            {
                Konut x = new Konut();
                if (textBox1.Text != "" && textBox4.Text != "" && textBox5.Text != "" && kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                else if (textBox4.Text != "" && textBox5.Text != "" && kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Ara(kiraliksatilik, Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                else if (textBox1.Text != "" && textBox5.Text != "" && kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox5.Text));
                else if (textBox1.Text != "" && textBox4.Text != "" && kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Araa(Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox4.Text));
                else if (textBox1.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                else if (textBox4.Text != "" && textBox5.Text != "")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                else if (textBox1.Text != "")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox1.Text));
                else if (kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Ara(kiraliksatilik);
            }
            else if (button4.Enabled == false)
            {
                Apartman x = new Apartman();
                if (textBox1.Text != "" && textBox4.Text != "" && textBox5.Text != "" && kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                else if (textBox4.Text != "" && textBox5.Text != "" && kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Ara(kiraliksatilik, Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                else if (textBox1.Text != "" && textBox5.Text != "" && kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox5.Text));
                else if (textBox1.Text != "" && textBox4.Text != "" && kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Araa(Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox4.Text));
                else if (textBox1.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                else if (textBox4.Text != "" && textBox5.Text != "")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                else if (textBox1.Text != "")
                    dataGridView1.DataSource = x.Ara(Convert.ToDouble(textBox1.Text));
                else if (kiraliksatilik != "Hiçbiri")
                    dataGridView1.DataSource = x.Ara(kiraliksatilik);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu menu = (Menu)Application.OpenForms["Menu"];
            menu.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == false) dataGridView1.DataSource = Ofis.Arsa.ToList();
            else if (button2.Enabled == false) dataGridView1.DataSource = Ofis.Daire.ToList();
            else if (button3.Enabled == false) dataGridView1.DataSource = Ofis.Konut.ToList();
            else if (button4.Enabled == false) dataGridView1.DataSource = Ofis.Apartman.ToList();
        }
    }
}
