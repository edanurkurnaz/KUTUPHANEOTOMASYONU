using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.KAYNAK
{
    public partial class KaynakSilForm : Form
    {
        public KaynakSilForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        private void KaynakSilForm_Load(object sender, EventArgs e)
        {
            //birden fazla kaynagı kolan kolon yazabılmek ıcın to lıst yazılır.
            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hangı satırdaysa o satırı yanı correntrowunu sılwer
            //cells 0 kaynak id alır
            int secilenİd = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            //fırordf secılenı bul
            var silinenKaynak = db.Kaynaklar.Where(x => x.kaynak_id == secilenİd).FirstOrDefault();
            db.Kaynaklar.Remove(silinenKaynak);
            db.SaveChanges();

            //ekranda olan degısıklıgı lıste halıne getır
            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();

        } 
    }
}
