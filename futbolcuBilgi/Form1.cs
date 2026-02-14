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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        formBilgi bilgi = new formBilgi();


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Akanji_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "akanji";
            bilgi.Show();
            this.Hide();

            
        }

        private void arnould_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu= "arnold";
            bilgi.Show();
            this.Hide();


        }

        private void calhanoglu_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "calhanoglu";
            bilgi.Show();
            this.Hide();

        }

        private void courtuas_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "courtuas";
            bilgi.Show();
            this.Hide();

        }

        private void dembele_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "dembele";
            bilgi.Show();
            this.Hide();

        }

        private void dijk_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "dijk";
            bilgi.Show();
            this.Hide();

        }

        private void doue_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "doue";
            bilgi.Show();
            this.Hide();

        }

        private void foden_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "foden";
            bilgi.Show();
            this.Hide();

        }

        private void guler_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "guler";
            bilgi.Show();
            this.Hide();

        }

        private void haaland_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "haaland";
            bilgi.Show();
            this.Hide();

        }

        private void kane_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "kane";
            bilgi.Show(); 
            this.Hide();


        }

        private void kimmich_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "kimmich";
            bilgi.Show(); 
            this.Hide();


        }

        private void lewa_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "lewandowski";
            bilgi.Show();
            this.Hide();

        }

        private void lookman_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "lookman";    
            bilgi.Show();
            this.Hide();

        }

        private void mbpee_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "mbappe";
            bilgi.Show();
            this.Hide();


        }

        private void neymar_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "neymar";
            bilgi.Show();
            this.Hide();

        }

        private void messi_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "messi";
            bilgi.Show();
            this.Hide();

        }

        private void osimhen_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "osimhen";
            bilgi.Show();
            this.Hide();

        }

        private void pogba_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "pogba";
            bilgi.Show();
            this.Hide();

        }

        private void rice_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "rice";
            bilgi.Show();
            this.Hide();

        }

        private void ronaldo_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "ronaldo";
            bilgi.Show();
            this.Hide();

        }

        private void sane_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "sane";
            bilgi.Show();
            this.Hide();

        }

        private void silva_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "silva";
            bilgi.Show();
            this.Hide();

        }

        private void sorlock_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "sorlock";
            bilgi.Show();
            this.Hide();

        }

        private void yamal_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "yamal";
            bilgi.Show();
            this.Hide();

        }

        private void yildiz_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "yildiz";
            bilgi.Show();
            this.Hide();
        }

        private void ilkay_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "ilkay";
            bilgi.Show();
            this.Hide();

        }

        private void bruyne_Click(object sender, EventArgs e)
        {
            futbolcu.oyuncu = "bruyne";
            bilgi.Show();
            this.Hide();

        }
    }
}
