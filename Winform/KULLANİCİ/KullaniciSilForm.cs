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
    public partial class KullaniciSilForm : Form
    {
        public KullaniciSilForm()
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

        private void KullaniciSilForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void KullanicisilBtn_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanicilar = db.KULLANİCİLAR.Where(X => X.kullanıcı_id == secilenId).FirstOrDefault();
            db.KULLANİCİLAR.Remove(kullanicilar);
            db.SaveChanges();
            Listele();

        }
    }
}
