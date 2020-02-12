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
    
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
            Ofis.Arsa = new List<Emlak>();
            Ofis.Daire = new List<Emlak>();
            Ofis.Konut = new List<Emlak>();
            Ofis.Apartman = new List<Emlak>();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arama arama = new Arama();
            arama.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guncelleme guncelleme = new Guncelleme();
            guncelleme.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sil sil = new Sil();
            sil.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = false;
        }
    }
}
