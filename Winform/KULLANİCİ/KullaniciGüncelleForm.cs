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
    public partial class KullaniciGüncelleForm : Form
    {
        public KullaniciGüncelleForm()
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

        private void KullaniciGüncelleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KULLANİCİADTXT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            KULLANİCİSOYADTXT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            KULLANİCİTCTXT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            KULLANİCİMAİLTXT.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            KULLANİCİTELTXT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            KULLANİCİCEZATXT.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            //cinsiyet kısmında randyo buton oldugu ıcın kontrol et kontrol ettıgını texte cevır sonra erkekse e yaz 7. kolondakı cınsıyet//
            if (dataGridView1.CurrentRow.Cells[7].Value.ToString().Equals("E"))
                radioE.Checked = true;
            else
                radioK.Checked = true;
        }

        private void KULLANİCİGUNCELLEBTN_Click(object sender, EventArgs e)
        {
            int secilenId =Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = db.KULLANİCİLAR.Where(x => x.kullanıcı_id == secilenId).FirstOrDefault();

            kullanici.kullanıcı_ad = KULLANİCİADTXT.Text;
            kullanici.kullanıcı_soyad = KULLANİCİSOYADTXT.Text;
            kullanici.kullanıcı_tc = KULLANİCİTCTXT.Text;
            kullanici.kullanıcı_telefon = KULLANİCİTELTXT.Text;
            kullanici.kullanıcı_mail = KULLANİCİMAİLTXT.Text;
            kullanici.kullanıcı_ceza = Convert.ToDouble(KULLANİCİCEZATXT.Text);

            if (radioE.Checked == true)
            {
                kullanici.kullanıcı_cinsiyet = "E";
            }
            else if (radioK.Checked == true)
            {
                kullanici.kullanıcı_cinsiyet = "K";
            }
            db.SaveChanges();
            Listele();
        }
    }
}
