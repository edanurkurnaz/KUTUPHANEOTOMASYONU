using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.KULLANİCİ
{
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }

       KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        public void Listele()
        {
            KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
            var KULLANiCiLAR = db.KULLANİCİLAR.ToList();
            dataGridView1.DataSource = KULLANiCiLAR.ToList();
        }

        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void KULLANİCİKAYDETBTN_Click(object sender, EventArgs e)
        {
            KULLANİCİLAR KULLANİCİLAR = new KULLANİCİLAR();
            KULLANİCİLAR.kullanıcı_ad = KULLANİCİADTXT.Text;
            KULLANİCİLAR.kullanıcı_soyad = KULLANİCİSOYADTXT.Text;
            KULLANİCİLAR.kullanıcı_tc = KULLANİCİTCTXT.Text;
            KULLANİCİLAR.kullanıcı_telefon = KULLANİCİTELTXT.Text;
            KULLANİCİLAR.kullanıcı_mail = KULLANİCİMAİLTXT.Text;
            KULLANİCİLAR.kullanıcı_ceza = Convert.ToDouble(KULLANİCİCEZATXT.Text);

            if(radioE.Checked==true)
            {
                KULLANİCİLAR.kullanıcı_cinsiyet = "E";
            }
            else if (radioK.Checked==true)
            {
                KULLANİCİLAR.kullanıcı_cinsiyet = "K";
            }
            db.KULLANİCİLAR.Add(KULLANİCİLAR);
            db.SaveChanges();
            Listele();

        }
    }
}
