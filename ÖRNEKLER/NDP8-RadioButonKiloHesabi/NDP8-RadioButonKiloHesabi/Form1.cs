using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP8_RadioButonKiloHesabi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int boy = int.Parse(textBox1.Text);
            int yas = int.Parse(textBox2.Text);
            int kilo = int.Parse(textBox3.Text);
            double idealkilo = 0;
            if (radioButton1.Checked)
                idealkilo = (boy - 100) * 0.8 + (yas / 10.0);
            else
                idealkilo = (boy - 100) * 0.9 + (yas / 10.0);
            label5.Text = "İdeal Kilonuz: " + idealkilo;
            double fark = kilo - idealkilo;
            if (fark > 0) label6.Text = "Durum: " + fark + " kadar kilo vermeniz gerekiyor.";
            else if (fark < 0) label6.Text = "Durum: " + (-1 * fark) + " kadar kilo almanız gerekiyor.";
            else label6.Text = "Durum: İdeal Kilodasınız.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
