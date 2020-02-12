using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace B161200304
{
    public class Konut:Emlak
    {
        public int IDgetir()
        {
            if (Ofis.Konut.Count == 0) return ID = 0;
            else return Ofis.Konut.Max(i => i.ID);
        }

        public void KonutEkle(double metrekare, string kiraliksatilik, double fiyat, string adisoyadi, string telefon, int salon, int oda, int balkon, int katsayisi)
        {
            this.ID = IDgetir() + 1;
            this.MetreKare = metrekare;
            this.KiralikSatilik = kiraliksatilik;
            this.Fiyat = fiyat;
            this.AdiSoyadi = adisoyadi;
            this.Telefon = telefon;
            this.SalonSayisi = salon;
            this.OdaSayisi = oda;
            this.BalkonSayisi = balkon;
            this.KatSayisi = katsayisi;
            MessageBox.Show("Konut Eklendi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void KonutGuncelle(int ID, double metrekare, string kiraliksatilik, double fiyat, string adisoyadi, string telefon, int salon, int oda, int balkon, 
            int katsayisi)
        {
            this.ID = ID;
            this.MetreKare = metrekare;
            this.KiralikSatilik = kiraliksatilik;
            this.Fiyat = fiyat;
            this.AdiSoyadi = adisoyadi;
            this.Telefon = telefon;
            this.SalonSayisi = salon;
            this.OdaSayisi = oda;
            this.BalkonSayisi = balkon;
            this.KatSayisi = katsayisi;
            MessageBox.Show("Konut Güncellendi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void KonutSil(int ID)
        {
            Ofis.Konut.RemoveAll(i => i.ID == ID);
        }

        public object Ara(double metrekare, string kiraliksatilik, double fiyatmax, double fiyatmin)
        {
            return Ofis.Konut.FindAll(i => i.KiralikSatilik == kiraliksatilik && i.MetreKare == metrekare && i.Fiyat <= fiyatmax && i.Fiyat >= fiyatmin);
        }

        public object Ara(string kiraliksatilik, double fiyatmax, double fiyatmin)
        {
            return Ofis.Konut.FindAll(i => i.KiralikSatilik == kiraliksatilik && i.Fiyat <= fiyatmax && i.Fiyat >= fiyatmin);
        }

        public object Ara(double metrekare, string kiraliksatilik, double fiyatmin)
        {
            return Ofis.Konut.FindAll(i => i.MetreKare == metrekare && i.KiralikSatilik == kiraliksatilik && i.Fiyat >= fiyatmin);
        }

        public object Araa(double metrekare, string kiraliksatilik, double fiyatmax)
        {
            return Ofis.Konut.FindAll(i => i.MetreKare == metrekare && i.KiralikSatilik == kiraliksatilik && i.Fiyat <= fiyatmax);
        }

        public object Ara(double metrekare, double fiyatmax, double fiyatmin)
        {
            return Ofis.Konut.FindAll(i => i.MetreKare == metrekare && i.Fiyat <= fiyatmax && i.Fiyat >= fiyatmin);
        }

        public object Ara(double fiyatmax, double fiyatmin)
        {
            return Ofis.Konut.FindAll(i => i.Fiyat <= fiyatmax && i.Fiyat >= fiyatmin);
        }

        public object Ara(double metrekare)
        {
            return Ofis.Konut.FindAll(i => i.MetreKare == metrekare);
        }

        public object Ara(string kiralıksatilik)
        {
            return Ofis.Konut.FindAll(i => i.KiralikSatilik == kiralıksatilik);
        }
    }
}
