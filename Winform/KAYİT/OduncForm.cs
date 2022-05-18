using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.KAYİT
{
    public partial class OduncForm : Form
    {
        public OduncForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        private void OduncForm_Load(object sender, EventArgs e)
        {
            //listeledik(kayıtları)
            var kayitlist = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitlist.ToList();

            //listeledık (kaynakları)
            var kaynaklist = db.Kaynaklar.ToList();
            dataGridView2.DataSource = kaynaklist.ToList();


            //istenmeyen kaynak ve kolonu gizledık
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            //kolon adlarını duzenledık
            dataGridView1.Columns[1].HeaderText = "Kullanıcı";
            dataGridView1.Columns[2].HeaderText = "Kaynak Ad";
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aranansecilen = Tcbultxt.Text;
            var kullanicivarmi = db.KULLANİCİLAR.Where(x => x.kullanıcı_tc == aranansecilen).FirstOrDefault();


            if (kullanicivarmi!=null)
            label2.Text = kullanicivarmi.kullanıcı_ad + " " + kullanicivarmi.kullanıcı_soyad;

            else
                label2.Text="Böyle Bir Kullanıcı Henüz Yok";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string gelenAd = textBox1.Text;
            var bulunankaynaklar = db.Kaynaklar.Where(x => x.kaynak_ad.Contains(gelenAd)).ToList();
            dataGridView2.DataSource = bulunankaynaklar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kişiyi aldık
            string secilenKisiTc = Tcbultxt.Text;
            var secilenkisi = db.KULLANİCİLAR.Where(x => x.kullanıcı_tc.Equals(secilenKisiTc)).FirstOrDefault();

            //kitabı aldık
            int secilenkitapİd =Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value);
            var secilenkitap = db.Kaynaklar.Where(x => x.kaynak_id == secilenkitapİd).FirstOrDefault();

            Kayitlar yenikayit = new Kayitlar();
            yenikayit.kitap_id = secilenkitap.kaynak_id;
            yenikayit.kullanici_id = secilenkisi.kullanıcı_id;
            yenikayit.durum = false;
            yenikayit.alis_tarih = DateTime.Today;
            yenikayit.son_tarih = DateTime.Today.AddDays(15);
            db.Kayitlar.Add(yenikayit);
            db.SaveChanges();

            var kayitlist = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitlist.ToList();

        }
  
    }
}
