/****************************************************************************
**							      SAKARYA ÜNİVERSİTESİ 
**					    BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ 
**						 BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ 
**							 NESNEYE DAYALI PROGRAMLAMA 
**							   2017-2018 BAHAR DÖNEMİ 
**  
**							ÖDEV NUMARASI..........: 1
**							ÖĞRENCİ ADI............: Mustafa ACAR
**							ÖĞRENCİ NUMARASI.......: B161200304
**                          DERSİN ALINDIĞI GRUP...: A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Dosyalama Kütüphanesi.
namespace B161200304
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //Uygulama çalıştığından dosya var mı?
            //Dosya var ise herhangi bir işlem yapmaz. Dosya yok ise "veriler.txt" adında belge oluşturur.
            try
            {
                StreamReader dosya = File.OpenText("veriler.txt");
                dosya.Close();
            }
            catch
            {
                StreamWriter dosya = File.CreateText("veriler.txt");
                dosya.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ad, Soyad, Telefon numarası kısımları boş mu kontrolü yapar.
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                label7.Text = "Boş Kısım Bırakmayınız!";
                return;
            }
            //Renk kısımlarında seçim yapıldı mı?
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {
                label7.Text = "";
                label8.Text = "Boş Kısım Bırakmayınız!";
                return;
            }
            //Herhangi bir sorun yok ise işlemleri yapar. Bilgileri "veriler.txt" belgesine kaydeder.
            else
            {
                label7.Text = "";
                label8.Text = "";
                StreamWriter Yaz = File.AppendText("veriler.txt");

                if (comboBox1.SelectedItem.ToString() == "Kırmızı")
                    Yaz.Write("k");
                else if (comboBox1.SelectedItem.ToString() == "Mavi")
                    Yaz.Write("m");
                else if (comboBox1.SelectedItem.ToString() == "Yeşil")
                    Yaz.Write("y");

                if (comboBox2.SelectedItem.ToString() == "Kırmızı")
                    Yaz.Write("k");
                else if (comboBox2.SelectedItem.ToString() == "Mavi")
                    Yaz.Write("m");
                else if (comboBox2.SelectedItem.ToString() == "Yeşil")
                    Yaz.Write("y");

                if (comboBox3.SelectedItem.ToString() == "Kırmızı")
                    Yaz.Write("k");
                else if (comboBox3.SelectedItem.ToString() == "Mavi")
                    Yaz.Write("m");
                else if (comboBox3.SelectedItem.ToString() == "Yeşil")
                    Yaz.Write("y");
                Yaz.WriteLine(" " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
                Yaz.Close();
                textBox1.Clear();
                comboBox1.SelectedIndex = -1;
                textBox2.Clear();
                comboBox2.SelectedIndex = -1;
                textBox3.Clear();
                comboBox3.SelectedIndex = -1;
                MessageBox.Show("Kayıt Eklendi.", "Bilgilendirme", MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            StreamReader dosya = File.OpenText("veriler.txt");
            //Belgenin ilk satırını okur ve satir adlı stringe aktarır.
            string satir = dosya.ReadLine();
            //"sayac" adlı integer değişken satırın tek ve çift olmasında kullanılır.
            int sayac = 0;
            while (satir != null)
            {
                string adrengi = satir.Substring(0, 1);     //"satir" değişkeninin ilk karakterini alır.
                string soyadrengi = satir.Substring(1, 1);  //"satir" değişkeninin ikinci karakterini alır.
                string numararengi = satir.Substring(2, 1); //"satir" değişkeninin üçüncü karakterini alır.

                if (sayac % 2 == 0) //"sayac" değişkenin modu alınır. Eğer 0 ise satırdaki yazılar kalın tip yapılır.
                                    //Eğer 0 değil ise normal (regular) tip kalır.
                    richTextBox1.SelectionFont = new Font("Tahoma", 8, FontStyle.Bold);

                string Metin = satir.Substring(4);    //"satir" değişkeninin renk kodlarından sonraki karakter başlangıçından itibaren "Metin" stringine aktarılır.
                string[] parcalar = Metin.Split(' '); //"Metin" değişkeni içerisindeki boşluklara kadar mevcut cümleler parçalara ayrılır. Diziye atılır.
                int sayac2 = 1;                       //"sayac2" integer değişkeni cümlelerin renklendirme sırasını belirler.
                foreach (string parca in parcalar)    //Foreach ile parcalar dizisini sırası ile döndürür.
                {
                    if (sayac2 == 1)    //Ad kısmının renklenmesi işlemini yapar.
                    {
                        if (adrengi == "k")
                            richTextBox1.SelectionColor = Color.Red;
                        else if (adrengi == "m")
                            richTextBox1.SelectionColor = Color.Blue;
                        else if (adrengi == "y")
                            richTextBox1.SelectionColor = Color.Green;
                        richTextBox1.AppendText(parca + " ");   //RichTextBoxa parca değikenini ekler, boşluk bırakır.
                    }
                    if (sayac2 == 2)    //Soyad kısmının renklenmesi işlemini yapar.
                    {
                        if (soyadrengi == "k")
                            richTextBox1.SelectionColor = Color.Red;
                        else if (soyadrengi == "m")
                            richTextBox1.SelectionColor = Color.Blue;
                        else if (soyadrengi == "y")
                            richTextBox1.SelectionColor = Color.Green;
                        richTextBox1.AppendText(parca + " ");   //RichTextBoxa parca değikenini ekler, boşluk bırakır.
                    }
                    if (sayac2 == 3)    //Numara kısmının renklenmesi işlemini yapar.
                    {
                        if (numararengi == "k")
                            richTextBox1.SelectionColor = Color.Red;
                        else if (numararengi == "m")
                            richTextBox1.SelectionColor = Color.Blue;
                        else if (numararengi == "y")
                            richTextBox1.SelectionColor = Color.Green;
                        sayac2 = 0;
                        richTextBox1.AppendText(parca + "\n");  //RichTextBoxa parca değikenini ekler, boşluk bırakır.
                    }
                    sayac2++;
                }
                sayac++;
                satir = dosya.ReadLine();
            }
            dosya.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 0 && (int)e.KeyChar <= 7 || (int)e.KeyChar >= 9 && (int)e.KeyChar <= 32 || (int)e.KeyChar >= 33 && (int)e.KeyChar <= 64 || (int)e.KeyChar >= 91 && (int)e.KeyChar <= 96 || (int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 0 && (int)e.KeyChar <= 7 || (int)e.KeyChar >= 9 && (int)e.KeyChar <= 32 || (int)e.KeyChar >= 33 && (int)e.KeyChar <= 64 || (int)e.KeyChar >= 91 && (int)e.KeyChar <= 96 || (int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
