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
    public partial class GeriAlForm : Form
    {
        public GeriAlForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        private void GeriAlForm_Load(object sender, EventArgs e)
        {
            //listeledik
            var kayıtlar = db.Kayitlar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayıtlar.ToList();
         
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenKayitId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit = db.Kayitlar.Where(x => x.kayit_id == secilenKayitId).FirstOrDefault();
            kayit.durum = true;
            db.SaveChanges();

            //liste tazeleee
            var kayıtlar = db.Kayitlar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayıtlar.ToList();
            

        }   

    }
}
