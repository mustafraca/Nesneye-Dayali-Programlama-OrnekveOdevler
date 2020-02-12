using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B161200304
{
    public class Daire : Emlak
    {
        public int IDgetir()
        {
            if (Ofis.Daire.Count == 0) return ID = 0;
            else return Ofis.Daire.Max(i => i.ID);
        }

        public void DaireEkle(double metrekare, string kiraliksatilik, double fiyat, string adisoyadi, string telefon, int salonsayisi, int odasayisi, 
            int balkonsayisi, string tuvalet, string banyo)
        {
            this.ID = IDgetir() + 1;
            this.MetreKare = metrekare;
            this.KiralikSatilik = kiraliksatilik;
            this.Fiyat = fiyat;
            this.AdiSoyadi = adisoyadi;
            this.Telefon = telefon;
            this.SalonSayisi = salonsayisi;
            this.OdaSayisi = odasayisi;
            this.BalkonSayisi = balkonsayisi;
            this.Tuvalet = tuvalet;
            this.Banyo = banyo;
            MessageBox.Show("Daire Eklendi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DaireGuncelle(int ID, double metrekare, string kiraliksatilik, double fiyat, string adisoyadi, string telefon, int salonsayisi, int odasayisi,
            int balkonsayisi, string tuvalet, string banyo)
        {
            this.ID = ID;
            this.MetreKare = metrekare;
            this.KiralikSatilik = kiraliksatilik;
            this.Fiyat = fiyat;
            this.AdiSoyadi = adisoyadi;
            this.Telefon = telefon;
            this.SalonSayisi = salonsayisi;
            this.OdaSayisi = odasayisi;
            this.BalkonSayisi = balkonsayisi;
            this.Tuvalet = tuvalet;
            this.Banyo = banyo;
            MessageBox.Show("Daire Güncellendi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DaireSil(int ID)
        {
            Ofis.Daire.RemoveAll(i => i.ID == ID);
        }

        public object Ara(double metrekare, string kiraliksatilik, double fiyatmax, double fiyatmin)
        {
            return Ofis.Daire.FindAll(i => i.KiralikSatilik == kiraliksatilik && i.MetreKare == metrekare && i.Fiyat <= fiyatmax && i.Fiyat >= fiyatmin);
        }

        public object Ara(string kiraliksatilik, double fiyatmax, double fiyatmin)
        {
            return Ofis.Daire.FindAll(i => i.KiralikSatilik == kiraliksatilik && i.Fiyat <= fiyatmax && i.Fiyat >= fiyatmin);
        }

        public object Ara(double metrekare, string kiraliksatilik, double fiyatmin)
        {
            return Ofis.Daire.FindAll(i => i.MetreKare == metrekare && i.KiralikSatilik == kiraliksatilik && i.Fiyat >= fiyatmin);
        }

        public object Araa(double metrekare, string kiraliksatilik, double fiyatmax)
        {
            return Ofis.Daire.FindAll(i => i.MetreKare == metrekare && i.KiralikSatilik == kiraliksatilik && i.Fiyat <= fiyatmax);
        }

        public object Ara(double metrekare, double fiyatmax, double fiyatmin)
        {
            return Ofis.Daire.FindAll(i => i.MetreKare == metrekare && i.Fiyat <= fiyatmax && i.Fiyat >= fiyatmin);
        }

        public object Ara(double fiyatmax, double fiyatmin)
        {
            return Ofis.Daire.FindAll(i => i.Fiyat <= fiyatmax && i.Fiyat >= fiyatmin);
        }

        public object Ara(double metrekare)
        {
            return Ofis.Daire.FindAll(i => i.MetreKare == metrekare);
        }

        public object Ara(string kiralıksatilik)
        {
            return Ofis.Daire.FindAll(i => i.KiralikSatilik == kiralıksatilik);
        }
    }
}
