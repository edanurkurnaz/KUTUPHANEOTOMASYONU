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
    public partial class Form1 : Form
    {

       KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
       

        public Form1()
        {
            InitializeComponent();
        }


        private void PERSONELGİRİSBTN_Click(object sender, EventArgs e)
        {
            string gelenAd = ADGİRİSTXT.Text;
            string gelenŞifre = SİFREGİRİSTXT.Text;

            //linqu sorgusu
         var personel = db.Personeller.Where(x => x.personel_ad.Equals(gelenAd) && x.personel_sifre.Equals(gelenŞifre)).FirstOrDefault();

            if(personel==null)
            {
                MessageBox.Show(text: "kullanıcı adı veya sıfre hatalı");
            }
            else
            {
                MessageBox.Show(text: "basarılı");
                İslemPaneli panel = new İslemPaneli();
                panel.Show();
                this.Hide();
            }
 

        }

        
    }
}
