using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP7_FormUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            textBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1)
                label3.Text = "Hata: En az bir rakam girmelisiniz.";
            else if (textBox1.Text.Length > 1)
                label3.Text = "Hata: En fazla bir rakam girebilirsiniz.";
            else
            {
                if (textBox2.Text.Length < 1)
                    textBox2.Text += textBox1.Text;
                else
                    textBox2.Text += ", " + textBox1.Text;
                label3.Text = "";
                button2.Visible = true;
            }
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 1)
                label4.Text = "Hata: En az bir rakam girmelisiniz.";
            else
            {
                string[] sayilar = textBox2.Text.Split(',');
                int toplam = 0;
                foreach (var deger in sayilar)
                {
                    toplam += int.Parse(deger);
                    label4.Text = "Sonuç: " + ((double)toplam / sayilar.Length);
                }
            }
        }
    }
}
