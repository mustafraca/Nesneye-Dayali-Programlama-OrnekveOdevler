using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B161200304
{
    public class Arsa:Emlak
    {
        public int IDgetir()
        {
            if (Ofis.Arsa.Count == 0) return ID = 0;
            else return Ofis.Arsa.Max(i => i.ID);
        }

        public void ArsaEkle(double metrekare, string kiraliksatilik, double fiyat, string adisoyadi, string telefon)
        {
            this.ID = IDgetir() + 1;
            this.MetreKare = metrekare;
            this.KiralikSatilik = kiraliksatilik;
            this.Fiyat = fiyat;
            this.AdiSoyadi = adisoyadi;
            this.Telefon = telefon;
            MessageBox.Show("Arsa Eklendi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ArsaGuncelle(int ID, double metrekare, string kiraliksatilik, double fiyat, string adisoyadi, string telefon)
        {
            this.ID = ID;
            this.MetreKare = metrekare;
            this.KiralikSatilik = kiraliksatilik;
            this.Fiyat = fiyat;
            this.AdiSoyadi = adisoyadi;
            this.Telefon = telefon;
            MessageBox.Show("Arsa Güncellendi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ArsaSil(int ID)
        {
            Ofis.Arsa.RemoveAll(i => i.ID == ID);
        }

        public object Ara(double metrekare, string kiraliksatilik, double fiyatmax, double fiyatmin)
        {
            return Ofis.Arsa.FindAll(i => i.KiralikSatilik == kiraliksatilik && i.MetreKare == metrekare && i.Fiyat <= fiyatmax && i.Fiyat >= fiyatmin);
        }

        public object Ara(string kiraliksatilik, double fiyatmax, double fiyatmin)
        {
            return Ofis.Arsa.FindAll(i => i.KiralikSatilik == kiraliksatilik && i.Fiyat <= fiyatmax && i.Fiyat >= fiyatmin);
        }

        public object Ara(double metrekare, string kiraliksatilik, double fiyatmin)
        {
            return Ofis.Arsa.FindAll(i => i.MetreKare == metrekare && i.KiralikSatilik == kiraliksatilik && i.Fiyat >= fiyatmin);
        }

        public object Araa(double metrekare, string kiraliksatilik, double fiyatmax)
        {
            return Ofis.Arsa.FindAll(i => i.MetreKare == metrekare && i.KiralikSatilik == kiraliksatilik && i.Fiyat <= fiyatmax);
        }

        public object Ara(double metrekare, double fiyatmax, double fiyatmin)
        {
            return Ofis.Arsa.FindAll(i => i.MetreKare == metrekare && i.Fiyat <= fiyatmax && i.Fiyat >= fiyatmin);
        }

        public object Ara(double fiyatmax, double fiyatmin)
        {
            return Ofis.Arsa.FindAll(i => i.Fiyat <= fiyatmax && i.Fiyat >= fiyatmin);
        }

        public object Ara(double metrekare)
        {
            return Ofis.Arsa.FindAll(i => i.MetreKare == metrekare);
        }

        public object Ara(string kiralıksatilik)
        {
            return Ofis.Arsa.FindAll(i => i.KiralikSatilik == kiralıksatilik);
        }
    }
}
