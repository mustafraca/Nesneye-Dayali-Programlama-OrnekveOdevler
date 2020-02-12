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
    public partial class Guncelleme : Form
    {
        public Guncelleme()
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

        private void Guncelleme_Load(object sender, EventArgs e)
        {
            button1_Click(button1, new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ofis.Arsa.ToList();
            Enbled(false, true, true, true, false, false, false, false, false, false, false);
            Temizle();
            SutunGizle(false, false, false, false, false, false, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ofis.Daire.ToList();
            Enbled(true, false, true, true, true, true, false, true, false, true, true);
            Temizle();
            SutunGizle(true, true, true, false, false, true, true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ofis.Konut.ToList();
            Enbled(true, true, false, true, true, true, true, true, false, false, false);
            Temizle();
            SutunGizle(true, true, true, true, false, false, false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ofis.Apartman.ToList();
            Enbled(true, true, true, false, true, true, false, true, true, false, false);
            Temizle();
            SutunGizle(true, true, true, false, true, false, false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tuvalet = "Yok";
            string banyo = "Yok";
            string kiraliksatilik = "Hiçbiri";
            if (checkBox1.Checked == true) { tuvalet = "Var"; }
            if (checkBox2.Checked == true) { banyo = "Var"; }
            if (radioButton1.Checked == true) { kiraliksatilik = "Kiralık"; }
            else if (radioButton2.Checked == true) { kiraliksatilik = "Satılık"; }
            if (button1.Enabled == false)
            {
                Arsa arsa = new Arsa();
                arsa.ArsaSil(Convert.ToInt32(textBox10.Text));
                arsa.ArsaGuncelle(Convert.ToInt32(textBox10.Text), Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox9.Text), textBox7.Text, textBox8.Text);
                Ofis.Arsa.Add(arsa);
                dataGridView1.DataSource = Ofis.Arsa.ToList();
            }
            else if (button2.Enabled == false)
            {
                Daire daire = new Daire();
                daire.DaireSil(Convert.ToInt32(textBox10.Text));
                daire.DaireGuncelle(Convert.ToInt32(textBox10.Text), Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox9.Text), textBox7.Text, textBox8.Text,
                    Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text), tuvalet, banyo);
                Ofis.Daire.Add(daire);
                dataGridView1.DataSource = Ofis.Daire.ToList();
            }
            else if (button3.Enabled == false)
            {
                Konut konut = new Konut();
                konut.KonutSil(Convert.ToInt32(textBox10.Text));
                konut.KonutGuncelle(Convert.ToInt32(textBox10.Text), Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox9.Text), textBox7.Text, textBox8.Text,
                    Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox4.Text));
                Ofis.Konut.Add(konut);
                dataGridView1.DataSource = Ofis.Konut.ToList();
            }
            else if (button4.Enabled == false)
            {
                Apartman apartman = new Apartman();
                apartman.ApartmanSil(Convert.ToInt32(textBox10.Text));
                apartman.ApartmanGuncelle(Convert.ToInt32(textBox10.Text), Convert.ToDouble(textBox1.Text), kiraliksatilik, Convert.ToDouble(textBox9.Text), textBox7.Text, textBox8.Text,
                    Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                Ofis.Apartman.Add(apartman);
                dataGridView1.DataSource = Ofis.Apartman.ToList();
            }

            Temizle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu menu = (Menu)Application.OpenForms["Menu"];
            menu.Show();
            this.Close();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                textBox10.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string ks = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                if (ks == "Kiralık") radioButton1.Checked = true;
                else if (ks == "Satılık") radioButton2.Checked = true;
                textBox9.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox7.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox8.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                if (button2.Enabled == false || button3.Enabled == false || button4.Enabled == false)
                {
                    textBox2.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    textBox3.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    textBox5.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                }
                if (button2.Enabled == false)
                {
                    string tuvalet = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                    if (tuvalet == "Var") checkBox1.Checked = true;
                    else checkBox1.Checked = false;
                    string banyo = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                    if (banyo == "Var") checkBox2.Checked = true;
                    else checkBox2.Checked = false;
                }
                else if (button3.Enabled == false)
                    textBox4.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                else if (button4.Enabled == false)
                    textBox6.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            }
        }
    }
}
