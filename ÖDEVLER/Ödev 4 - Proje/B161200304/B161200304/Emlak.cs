using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B161200304
{
    public abstract class Emlak
    {
        private int id = 0;
        public int ID
        {
            set { id = value; }
            get { return id; }
        }

        private double metrekare = 0;
        public double MetreKare
        {
            set { metrekare = value; }
            get { return metrekare; }
        }

        private string kiraliksatilik = "Hiçbiri";
        public string KiralikSatilik
        {
            set { kiraliksatilik = value; }
            get { return kiraliksatilik; }
        }

        private double fiyat = 0;
        public double Fiyat
        {
            set { fiyat = value; }
            get { return fiyat; }
        }

        private string adisoyadi = "Belirtilmemiş";
        public string AdiSoyadi
        {
            set { adisoyadi = value; }
            get { return adisoyadi; }
        }

        private string telefon = "Belirtilmemiş";
        public string Telefon
        {
            set { telefon = value; }
            get { return telefon; }
        }

        private int salonsayisi = 0;
        public int SalonSayisi
        {
            set { salonsayisi = value; }
            get { return salonsayisi; }
        }

        private int odasayisi = 0;
        public int OdaSayisi
        {
            set { odasayisi = value; }
            get { return odasayisi; }
        }

        private int balkonsayisi = 0;
        public int BalkonSayisi
        {
            set { balkonsayisi = value; }
            get { return balkonsayisi; }
        }

        private int katsayisi = 0;
        public int KatSayisi
        {
            set { katsayisi = value; }
            get { return katsayisi; }
        }

        private int dairesayisi = 0;
        public int DaireSayisi
        {
            set { dairesayisi = value; }
            get { return dairesayisi; }
        }

        private string tuvalet = "Yok";
        public string Tuvalet
        {
            set { tuvalet = value; }
            get { return tuvalet; }
        }
        private string banyo = "Yok";
        public string Banyo
        {
            set { banyo = value; }
            get { return banyo; }
        }
    }
}
