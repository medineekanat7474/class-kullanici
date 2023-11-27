using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_kullanici
{
    internal class Kullanici
    {
        string ad;
        string soyAd;
        string telefon;
        string eposta;
        string sifre;
        string adres;

        public string Ad { get => ad; set => ad = value; }
        public string SoyAd { get => soyAd; set => soyAd = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Eposta { get => eposta; set => eposta = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public string Adres { get => adres; set => adres = value; }

        public Kullanici(string ad, string soyAd, string telefon, string eposta, string sifre, string adres)
        {
            this.ad = ad;
            this.soyAd = soyAd;
            this.telefon = telefon;
            this.eposta = eposta;
            this.sifre = sifre;
            this.adres = adres;
        }
    }
}
