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
    public partial class Sil : Form
    {
        public Sil()
        {
            InitializeComponent();
        }

        private void Enbled(bool a, bool b, bool c, bool d)
        {
            button1.Enabled = a;
            button2.Enabled = b;
            button3.Enabled = c;
            button4.Enabled = d;
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

        private void Sil_Load(object sender, EventArgs e)
        {
            button1_Click(button1, new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ofis.Arsa.ToList();
            Enbled(false, true, true, true);
            SutunGizle(false, false, false, false, false, false, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ofis.Daire.ToList();
            Enbled(true, false, true, true);
            SutunGizle(true, true, true, false, false, true, true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ofis.Konut.ToList();
            Enbled(true, true, false, true);
            SutunGizle(true, true, true, true, false, false, false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ofis.Apartman.ToList();
            Enbled(true, true, true, false);
            SutunGizle(true, true, true, false, true, false, false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int indis = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            if (button1.Enabled == false)
            {
                Arsa arsa = new Arsa();
                arsa.ArsaSil(indis);
                dataGridView1.DataSource = Ofis.Arsa.ToList();
            }
            else if (button2.Enabled == false)
            {
                Daire daire = new Daire();
                daire.DaireSil(indis);
                dataGridView1.DataSource = Ofis.Daire.ToList();
            }
            else if (button3.Enabled == false)
            {
                Konut konut = new Konut();
                konut.KonutSil(indis);
                dataGridView1.DataSource = Ofis.Konut.ToList();
            }
            else if (button4.Enabled == false)
            {
                Apartman apartman = new Apartman();
                apartman.ApartmanSil(indis);
                dataGridView1.DataSource = Ofis.Apartman.ToList();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu menu = (Menu)Application.OpenForms["Menu"];
            menu.Show();
            this.Close();
        }
    }
}
