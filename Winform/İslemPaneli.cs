using KutuphaneOtomasyonWinForm.KAYİT;
using KutuphaneOtomasyonWinForm.KAYNAK;
using KutuphaneOtomasyonWinForm.KULLANİCİ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm
{
    public partial class İslemPaneli : Form
    {
        public İslemPaneli()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        public object Kaynaklisteform { get; private set; }

        private void İslemPaneli_Load(object sender, EventArgs e)
        {
            //İLK BASTA BUTONLAR KAPALIDIR. (EKLE,GUNCELLE,SİL)
            KULLANİCİEKLEBTN.Visible = false;
            KULLANİCİGÜNCELLEBTN.Visible = false;
            KULLANİCİSİLBTN.Visible = false;

            //İLK BASTA BUTONLAR KAPALIDIR. (EKLE,GUNCELLE,SİL)
            EKLEKAYNAKBTN.Visible = false;
            GUNCELLEKAYNAKBTN.Visible = false;
            SİLKAYNAKBTN.Visible = false;

        }

        private void KULLANICİ_Click(object sender, EventArgs e)
        {
            if(KULLANİCİEKLEBTN.Visible==false)
            {
                KULLANİCİEKLEBTN.Visible = true;
                KULLANİCİGÜNCELLEBTN.Visible = true;
                KULLANİCİSİLBTN.Visible = true;
            }
             else
            {
                KULLANİCİEKLEBTN.Visible = false;
                KULLANİCİGÜNCELLEBTN.Visible = false;
                KULLANİCİSİLBTN.Visible = false;
            }

            KullaniciListeForm klisteform = new KullaniciListeForm();
            klisteform.MdiParent = this;
            klisteform.Show();
        }

        private void KULLANİCİEKLEBTN_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm ekleForm = new KullaniciEkleForm();
            ekleForm.MdiParent = this;
            ekleForm.Show();
        }

        private void KULLANİCİSİLBTN_Click(object sender, EventArgs e)
        {
            KullaniciSilForm ksil = new KullaniciSilForm();
            ksil.MdiParent = this;
            ksil.Show();
        }

        private void KULLANİCİGÜNCELLEBTN_Click(object sender, EventArgs e)
        {
            KullaniciGüncelleForm kGuncel = new KullaniciGüncelleForm();
            kGuncel.MdiParent= this;
            kGuncel.Show();
        }

        private void KAYNAKLARBTN_Click(object sender, EventArgs e)
        {
            if (EKLEKAYNAKBTN.Visible==false)
            {
                EKLEKAYNAKBTN.Visible = true;
                GUNCELLEKAYNAKBTN.Visible = true;
                SİLKAYNAKBTN.Visible = true; 
            }

            else
            {
                EKLEKAYNAKBTN.Visible = false;
                GUNCELLEKAYNAKBTN.Visible = false;
                SİLKAYNAKBTN.Visible = false;
            }

            KAYNAKLİSTEFORM kliste = new KAYNAKLİSTEFORM();
            kliste.MdiParent = this;
            kliste.Show();
        }

        private void EKLEKAYNAKBTN_Click(object sender, EventArgs e)
        {
            KaynakEkleForm kekle = new KaynakEkleForm();
            kekle.MdiParent = this;
            kekle.Show();
        }

        private void SİLKAYNAKBTN_Click(object sender, EventArgs e)
        {
            KaynakSilForm kSİL = new KaynakSilForm();
            kSİL.MdiParent = this;
            kSİL.Show();
        
        }

        private void GUNCELLEKAYNAKBTN_Click(object sender, EventArgs e)
        {
            KaynakGüncelleForm kGuncel = new KaynakGüncelleForm();
            kGuncel.MdiParent = this;
            kGuncel.Show();

        }

        private void ODUNCBTN_Click(object sender, EventArgs e)
        {
            OduncForm odunc = new OduncForm();
            odunc.MdiParent = this;
            odunc.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeriAlForm geri = new GeriAlForm();
            geri.MdiParent = this;
            geri.Show();

        }
    }
}