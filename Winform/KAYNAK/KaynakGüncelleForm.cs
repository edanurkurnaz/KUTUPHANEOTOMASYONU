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
    public partial class KaynakGüncelleForm : Form
    {
        public KaynakGüncelleForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        

        private void KaynakGüncelleForm_Load(object sender, EventArgs e)
        {
            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //hucre clıck yaptık bır yere tıklayuınca butun verırler gelır.fare tıklama olayı.
            //celleer hücre sayısı kacıncı hucrede oldugunu gosterır
            AdKaynaktxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            YazarKaynaktxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            YayıncıKaynaktxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            numericUpDown1.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenkaynak =Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var Guncellenecekkaynak = db.Kaynaklar.Where(x => x.kaynak_id == secilenkaynak).FirstOrDefault();
            Guncellenecekkaynak.kaynak_ad = AdKaynaktxt.Text;
            Guncellenecekkaynak.kaynak_yazar = YayıncıKaynaktxt.Text;
            Guncellenecekkaynak.kaynak_yayıncı = YayıncıKaynaktxt.Text;
            Guncellenecekkaynak.kaynak_sayfasayısı = Convert.ToInt16(numericUpDown1.Value);
            Guncellenecekkaynak.kaynak_basımtarihi = dateTimePicker1.Value;
            db.SaveChanges();

            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();

        }

        
    }
}
