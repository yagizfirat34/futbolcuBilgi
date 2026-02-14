using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futbolcuBilgi
{
    public partial class formBilgi : Form
    {
        public formBilgi()
        {
            InitializeComponent();
        }



        akanji Nesnefutbolcu = new akanji();
        arnold AArnold = new arnold();
        calhanoglu HCalhanoglu = new calhanoglu();
        courtois TCourtois = new courtois();
        dembele ODembele = new dembele();
        dijk Vdijk = new dijk();
        doue DDoue = new doue();
        foden PFoden = new foden();
        guler AGuler = new guler();
        haaland EHaaland = new haaland();
        kane HKane = new kane();
        kimmich JKimmich = new kimmich();
        lewandowski RLewandowski = new lewandowski();
        lookman ALookman = new lookman();
        mbappe KMbappe = new mbappe();
        messi LMessi = new messi();
        neymar NeymarJ = new neymar();
        osimhen VOsimhen = new osimhen();
        pogba PPogba = new pogba();
        rice DRice = new rice();
        ronaldo CRonaldo = new ronaldo();
        sane LSane = new sane();
        silva BSilva = new silva();
        sorlock ASorlock = new sorlock();
        yamal LYamal = new yamal();
        yildiz KYildiz = new yildiz();
        gundogan IGundogan = new gundogan();
        bruyne KBruyne = new bruyne();



        private void undo_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();

            anasayfa.Show();
            this.Hide();


        }

        private void formBilgi_Load(object sender, EventArgs e)
        {
            if (futbolcu.oyuncu == "akanji")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[0];

                lblAd.Text = Nesnefutbolcu.ad;
                lblFiyat.Text = Nesnefutbolcu.fiyat.ToString() + " €";
                lblMevki.Text = Nesnefutbolcu.mevki;
                lblNumara.Text = Nesnefutbolcu.formaNo.ToString();
                lblTakim.Text = Nesnefutbolcu.takim;
                lblUlke.Text = Nesnefutbolcu.ulke;
                lblYas.Text = Nesnefutbolcu.yas;

            }
            else if (futbolcu.oyuncu == "arnold")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[1];
                lblAd.Text = AArnold.ad;
                lblFiyat.Text = AArnold.fiyat.ToString() + " €";
                lblMevki.Text = AArnold.mevki;
                lblNumara.Text = AArnold.formaNo.ToString();
                lblTakim.Text = AArnold.takim;
                lblUlke.Text = AArnold.ulke;
                lblYas.Text = AArnold.yas;
            }
            else if (futbolcu.oyuncu == "calhanoglu")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[3];
                lblAd.Text = HCalhanoglu.ad;
                lblFiyat.Text = HCalhanoglu.fiyat.ToString() + " €";
                lblMevki.Text = HCalhanoglu.mevki;
                lblNumara.Text = HCalhanoglu.formaNo.ToString();
                lblTakim.Text = HCalhanoglu.takim;
                lblUlke.Text = HCalhanoglu.ulke;
                lblYas.Text = HCalhanoglu.yas;
            }
            else if (futbolcu.oyuncu == "courtuas")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[4];
                lblAd.Text = TCourtois.ad;
                lblFiyat.Text = TCourtois.fiyat.ToString() + " €";
                lblMevki.Text = TCourtois.mevki;
                lblNumara.Text = TCourtois.formaNo.ToString();
                lblTakim.Text = TCourtois.takim;
                lblUlke.Text = TCourtois.ulke;
                lblYas.Text = TCourtois.yas;
            }
            else if (futbolcu.oyuncu == "dembele")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[5];
                lblAd.Text = ODembele.ad;
                lblFiyat.Text = ODembele.fiyat.ToString() + " €";
                lblMevki.Text = ODembele.mevki;
                lblNumara.Text = ODembele.formaNo.ToString();
                lblTakim.Text = ODembele.takim;
                lblUlke.Text = ODembele.ulke;
                lblYas.Text = ODembele.yas;


            }
            else if (futbolcu.oyuncu == "dijk")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[6];
                lblAd.Text = Vdijk.ad;
                lblFiyat.Text = Vdijk.fiyat.ToString() + " €";
                lblMevki.Text = Vdijk.mevki;
                lblNumara.Text = Vdijk.formaNo.ToString();
                lblTakim.Text = Vdijk.takim;
                lblUlke.Text = Vdijk.ulke;
                lblYas.Text = Vdijk.yas;
            }
            else if (futbolcu.oyuncu == "doue")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[7];
                lblAd.Text = DDoue.ad;
                lblFiyat.Text = DDoue.fiyat.ToString() + " €";
                lblMevki.Text = DDoue.mevki;
                lblNumara.Text = DDoue.formaNo.ToString();
                lblTakim.Text = DDoue.takim;
                lblUlke.Text = DDoue.ulke;
                lblYas.Text = DDoue.yas;
            }
            else if (futbolcu.oyuncu == "foden")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[8];
                lblAd.Text = PFoden.ad;
                lblFiyat.Text = PFoden.fiyat.ToString() + " €";
                lblMevki.Text = PFoden.mevki;
                lblNumara.Text = PFoden.formaNo.ToString();
                lblTakim.Text = PFoden.takim;
                lblUlke.Text = PFoden.ulke;
                lblYas.Text = PFoden.yas;
            }
            else if (futbolcu.oyuncu == "guler")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[9];
                lblAd.Text = AGuler.ad;
                lblFiyat.Text = AGuler.fiyat.ToString() + " €";
                lblMevki.Text = AGuler.mevki;
                lblNumara.Text = AGuler.formaNo.ToString();
                lblTakim.Text = AGuler.takim;
                lblUlke.Text = AGuler.ulke;
                lblYas.Text = AGuler.yas;
            }
            else if (futbolcu.oyuncu == "haaland")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[11];
                lblAd.Text = EHaaland.ad;
                lblFiyat.Text = EHaaland.fiyat.ToString() + " €";
                lblMevki.Text = EHaaland.mevki;
                lblNumara.Text = EHaaland.formaNo.ToString();
                lblTakim.Text = EHaaland.takim;
                lblUlke.Text = EHaaland.ulke;
                lblYas.Text = EHaaland.yas;
            }
            else if (futbolcu.oyuncu == "kane")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[12];
                lblAd.Text = HKane.ad;
                lblFiyat.Text = HKane.fiyat.ToString() + " €";
                lblMevki.Text = HKane.mevki;
                lblNumara.Text = HKane.formaNo.ToString();
                lblTakim.Text = HKane.takim;
                lblUlke.Text = HKane.ulke;
                lblYas.Text = HKane.yas;
            }
            else if (futbolcu.oyuncu == "kimmich")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[14];
                lblAd.Text = JKimmich.ad;
                lblFiyat.Text = JKimmich.fiyat.ToString() + " €";
                lblMevki.Text = JKimmich.mevki;
                lblNumara.Text = JKimmich.formaNo.ToString();
                lblTakim.Text = JKimmich.takim;
                lblUlke.Text = JKimmich.ulke;
                lblYas.Text = JKimmich.yas;
            }
            else if (futbolcu.oyuncu == "lewandowski")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[15];
                lblAd.Text = RLewandowski.ad;
                lblFiyat.Text = RLewandowski.fiyat.ToString() + " €";
                lblMevki.Text = RLewandowski.mevki;
                lblNumara.Text = RLewandowski.formaNo.ToString();
                lblTakim.Text = RLewandowski.takim;
                lblUlke.Text = RLewandowski.ulke;
                lblYas.Text = RLewandowski.yas;
            }
            else if (futbolcu.oyuncu == "lookman")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[16];
                lblAd.Text = ALookman.ad;
                lblFiyat.Text = ALookman.fiyat.ToString() + " €";
                lblMevki.Text = ALookman.mevki;
                lblNumara.Text = ALookman.formaNo.ToString();
                lblTakim.Text = ALookman.takim;
                lblUlke.Text = ALookman.ulke;
                lblYas.Text = ALookman.yas;
            }
            else if (futbolcu.oyuncu == "mbappe")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[17];
                lblAd.Text = KMbappe.ad;
                lblFiyat.Text = KMbappe.fiyat.ToString() + " €";
                lblMevki.Text = KMbappe.mevki;
                lblNumara.Text = KMbappe.formaNo.ToString();
                lblTakim.Text = KMbappe.takim;
                lblUlke.Text = KMbappe.ulke;
                lblYas.Text = KMbappe.yas;
            }
            else if (futbolcu.oyuncu == "messi")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[18];
                lblAd.Text = LMessi.ad;
                lblFiyat.Text = LMessi.fiyat.ToString() + " €";
                lblMevki.Text = LMessi.mevki;
                lblNumara.Text = LMessi.formaNo.ToString();
                lblTakim.Text = LMessi.takim;
                lblUlke.Text = LMessi.ulke;
                lblYas.Text = LMessi.yas;
            }
            else if (futbolcu.oyuncu == "neymar")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[19];
                lblAd.Text = NeymarJ.ad;
                lblFiyat.Text = NeymarJ.fiyat.ToString() + " €";
                lblMevki.Text = NeymarJ.mevki;
                lblNumara.Text = NeymarJ.formaNo.ToString();
                lblTakim.Text = NeymarJ.takim;
                lblUlke.Text = NeymarJ.ulke;
                lblYas.Text = NeymarJ.yas;
            }
            else if (futbolcu.oyuncu == "osimhen")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[20];
                lblAd.Text = VOsimhen.ad;
                lblFiyat.Text = VOsimhen.fiyat.ToString() + " €";
                lblMevki.Text = VOsimhen.mevki;
                lblNumara.Text = VOsimhen.formaNo.ToString();
                lblTakim.Text = VOsimhen.takim;
                lblUlke.Text = VOsimhen.ulke;
                lblYas.Text = VOsimhen.yas;
            }
            else if (futbolcu.oyuncu == "pogba")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[21];
                lblAd.Text = PPogba.ad;
                lblFiyat.Text = PPogba.fiyat.ToString() + " €";
                lblMevki.Text = PPogba.mevki;
                lblNumara.Text = PPogba.formaNo.ToString();
                lblTakim.Text = PPogba.takim;
                lblUlke.Text = PPogba.ulke;
                lblYas.Text = PPogba.yas;
            }
            else if (futbolcu.oyuncu == "rice")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[22];
                lblAd.Text = DRice.ad;
                lblFiyat.Text = DRice.fiyat.ToString() + " €";
                lblMevki.Text = DRice.mevki;
                lblNumara.Text = DRice.formaNo.ToString();
                lblTakim.Text = DRice.takim;
                lblUlke.Text = DRice.ulke;
                lblYas.Text = DRice.yas;
            }
            else if (futbolcu.oyuncu == "ronaldo")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[23];
                lblAd.Text = CRonaldo.ad;
                lblFiyat.Text = CRonaldo.fiyat.ToString() + " €";
                lblMevki.Text = CRonaldo.mevki;
                lblNumara.Text = CRonaldo.formaNo.ToString();
                lblTakim.Text = CRonaldo.takim;
                lblUlke.Text = CRonaldo.ulke;
                lblYas.Text = CRonaldo.yas;
            }
            else if (futbolcu.oyuncu == "sane")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[24];
                lblAd.Text = LSane.ad;
                lblFiyat.Text = LSane.fiyat.ToString() + " €";
                lblMevki.Text = LSane.mevki;
                lblNumara.Text = LSane.formaNo.ToString();
                lblTakim.Text = LSane.takim;
                lblUlke.Text = LSane.ulke;
                lblYas.Text = LSane.yas;
            }

            else if (futbolcu.oyuncu == "silva")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[25];
                lblAd.Text = BSilva.ad;
                lblFiyat.Text = BSilva.fiyat.ToString() + " €";
                lblMevki.Text = BSilva.mevki;
                lblNumara.Text = BSilva.formaNo.ToString();
                lblTakim.Text = BSilva.takim;
                lblUlke.Text = BSilva.ulke;
                lblYas.Text = BSilva.yas;

            }
            else if (futbolcu.oyuncu == "sorlock")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[26];
                lblAd.Text = ASorlock.ad;
                lblFiyat.Text = ASorlock.fiyat.ToString() + " €";
                lblMevki.Text = ASorlock.mevki;
                lblNumara.Text = ASorlock.formaNo.ToString();
                lblTakim.Text = ASorlock.takim;
                lblUlke.Text = ASorlock.ulke;
                lblYas.Text = ASorlock.yas;
            }
            else if (futbolcu.oyuncu == "yamal")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[28];
                lblAd.Text = LYamal.ad;
                lblFiyat.Text = LYamal.fiyat.ToString() + " €";
                lblMevki.Text = LYamal.mevki;
                lblNumara.Text = LYamal.formaNo.ToString();
                lblTakim.Text = LYamal.takim;
                lblUlke.Text = LYamal.ulke;
                lblYas.Text = LYamal.yas;
            }
            else if (futbolcu.oyuncu == "yildiz")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[29];
                lblAd.Text = KYildiz.ad;
                lblFiyat.Text = KYildiz.fiyat.ToString() + " €";
                lblMevki.Text = KYildiz.mevki;
                lblNumara.Text = KYildiz.formaNo.ToString();
                lblTakim.Text = KYildiz.takim;
                lblUlke.Text = KYildiz.ulke;
                lblYas.Text = KYildiz.yas;
            }
            else if (futbolcu.oyuncu == "ilkay")
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[10];
                lblAd.Text = IGundogan.ad;
                lblFiyat.Text = IGundogan.fiyat.ToString() + " €";
                lblMevki.Text = IGundogan.mevki;
                lblNumara.Text = IGundogan.formaNo.ToString();
                lblTakim.Text = IGundogan.takim;
                lblUlke.Text = IGundogan.ulke;
                lblYas.Text = IGundogan.yas;
            }
            else
            {
                pbfutbolcu.Image = imgOyuncuResim.Images[13];
                lblAd.Text = KBruyne.ad;
                lblFiyat.Text = KBruyne.fiyat.ToString() + " €";
                lblMevki.Text = KBruyne.mevki;
                lblNumara.Text = KBruyne.formaNo.ToString();
                lblTakim.Text = KBruyne.takim;
                lblUlke.Text = KBruyne.ulke;
                lblYas.Text = KBruyne.yas;
            }

        }
    }
}
