using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAcsessLayer;
using ControlLayer;
using System.Xml;

namespace FlimLibaryForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Result Islem = new Result();
        Clean Temizlikci = new Clean();

        public void cmbDoldur()
        {
            cmbKayitliflimler.Items.Clear();
            FlimRepository fr = new FlimRepository();
            List<Flimlerim> FlimList = fr.GetAll();
            foreach (Flimlerim item in FlimList)
            {
                cmbKayitliflimler.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDoldur();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Flimlerim f = new Flimlerim();
            f.FlimAdi = txtflimAdi.Text;
            f.FlimTuru = txtFlimTuru.Text;
            f.Yonetmen = txtYonetmen.Text;
            f.Senarist = txtSenarist.Text;
            f.ImdbPuani = txtImdbPuani.Text;
            f.ResimUrl = txtResimUrl.Text;
            f.Oyuncular = txtOyuncular.Text;
            f.Konusu = txtKonusu.Text;
            f.FlimTarihi = Convert.ToDateTime(dtpFlimTarihi.Value);
            bool sonuc = FlimProcess.controlToSaveFlim(f);
            Islem.IslemKontrolu(sonuc);
            Temizlikci.Temizle(groupBox2);
            cmbDoldur();
        }

        private void cmbKayitliflimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Flimlerim seciliCmb = (Flimlerim)cmbKayitliflimler.SelectedItem;
            txtflimAdi.Text = seciliCmb.FlimAdi;
            txtFlimTuru.Text = seciliCmb.FlimTuru;
            txtYonetmen.Text = seciliCmb.Yonetmen;
            txtSenarist.Text = seciliCmb.Senarist;
            txtImdbPuani.Text = seciliCmb.ImdbPuani;
            txtResimUrl.Text = seciliCmb.ResimUrl;
            txtOyuncular.Text = seciliCmb.Oyuncular;
            txtKonusu.Text = seciliCmb.Konusu;
            dtpFlimTarihi.Value = Convert.ToDateTime(seciliCmb.FlimTarihi);
            pcbResim.ImageLocation = seciliCmb.ResimUrl;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Flimlerim seciliCmb = (Flimlerim)cmbKayitliflimler.SelectedItem;
            bool sonuc = FlimProcess.controlToDeleteFlim(seciliCmb);
            Islem.IslemKontrolu(sonuc);
            Temizlikci.Temizle(groupBox2);
            cmbDoldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Flimlerim seciliCmb = (Flimlerim)cmbKayitliflimler.SelectedItem;
            seciliCmb.FlimAdi = txtflimAdi.Text;
            seciliCmb.FlimTuru = txtFlimTuru.Text;
            seciliCmb.Yonetmen = txtYonetmen.Text;
            seciliCmb.Senarist = txtSenarist.Text;
            seciliCmb.ImdbPuani = txtImdbPuani.Text;
            seciliCmb.ResimUrl = txtResimUrl.Text;
            seciliCmb.Oyuncular = txtOyuncular.Text;
            seciliCmb.Konusu = txtKonusu.Text;
            seciliCmb.FlimTarihi = Convert.ToDateTime(dtpFlimTarihi.Value);
            bool sonuc = FlimProcess.controlToUpdateFlim(seciliCmb);
            Islem.IslemKontrolu(sonuc);
            Temizlikci.Temizle(groupBox2);
            cmbDoldur();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAraFlimAdi.Text))
            {
                MessageBox.Show("Flim Adi boş bırakılamaz!");
                return;
            }

            string apiUrl = string.Format("http://www.omdbapi.com/?t={0}&y={1}&apikey=e4e3c8dd&r=xml", txtAraFlimAdi.Text,dtpAraFlimTarihi.Value.Year);//https://kodzilla.wordpress.com/2012/07/31/c-ile-imdb-film-bilgilerini-cekme/ sitesinden yaralandım bu kısımda ve omdb den api aldım api süresi gecebilir yada site koşulları değişeblir proje yapımı 02.07.2019
            XmlDocument xml = new XmlDocument();
            xml.Load(apiUrl);

            if (xml.SelectNodes(@"root/movie").Count <= 0)
            {
                lblFlimAdi.Text = "Aradığınız flim bulunamadı";
                return;
            }
            foreach (XmlElement item in xml.SelectNodes(@"root/movie"))
            {
                pcbResim.ImageLocation = item.GetAttribute("poster");
                lblFlimAdi.Text = item.GetAttribute("title");
                txtSonucOyuncular.Text = item.GetAttribute("actors");
                txtSonucKonusu.Text = item.GetAttribute("plot");
                lblYonetmen.Text = item.GetAttribute("director");
                lblSenarist.Text = item.GetAttribute("writer");
                lblImdb.Text = item.GetAttribute("imdbRating");
                lblFlimTuru.Text = item.GetAttribute("genre");
                dtpAraFlimTarihi.Value = Convert.ToDateTime(item.GetAttribute("released"));
            }
        }

        private void btnFilmiKaydet_Click(object sender, EventArgs e)
        {
            Flimlerim f = new Flimlerim();
            f.FlimAdi = lblFlimAdi.Text;
            f.FlimTuru = lblFlimTuru.Text;
            f.ImdbPuani = lblImdb.Text;
            f.Konusu = txtSonucKonusu.Text;
            f.Oyuncular = txtSonucOyuncular.Text;
            f.Senarist = lblSenarist.Text;
            f.Yonetmen = lblYonetmen.Text;
            f.FlimTarihi = dtpAraFlimTarihi.Value;
            f.ResimUrl = pcbResim.ImageLocation;
            bool sonuc = FlimProcess.controlToSaveFlim(f);
            Islem.IslemKontrolu(sonuc);
            Control[] Temizlenecek= { lblFlimAdi, lblFlimTuru, lblImdb, lblSenarist, lblYonetmen, txtSonucKonusu, txtSonucOyuncular };
            Temizlikci.OzelTemizlik(Temizlenecek, pcbResim);
            cmbDoldur();
        }
    }
}
