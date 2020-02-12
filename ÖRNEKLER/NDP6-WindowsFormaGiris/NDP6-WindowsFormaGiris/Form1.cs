using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP6_WindowsFormaGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
            int sayi = int.Parse(textBox1.Text);
            textBox1.Text = (sayi * sayi).ToString() + "  -> Girdiğiniz Sayının Karesidir.";
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Text = textBox1.Text;
            int sayi = int.Parse(textBox1.Text);
            textBox1.Text = (sayi + sayi).ToString();
        }
    }
}
