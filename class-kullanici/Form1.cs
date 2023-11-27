using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_kullanici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            string ad = Convert.ToString(txtAd.Text);
            string soyAd = Convert.ToString(txtSoyAd.Text);
            string telefon=Convert.ToString(txtTelefon.Text);
            string Eposta = Convert.ToString(txtEPosta.Text);
            string sifre=Convert.ToString(txtSifre.Text);
            string adres=Convert.ToString(txtAdres.Text);

            Kullanici kullanici=new Kullanici(ad,soyAd,telefon,Eposta,sifre,adres);
        }
    }
}
