using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaVizeSinav
{
    
    public partial class Kitap_Ekleme : Form
    {
        Kitap kitap;
        public Kitap_Ekleme()
        {
            InitializeComponent();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kitap = new Kitap();
            kitap.Baslik = txtBaslik.Text;
            kitap.Yazar = txtYazar.Text;
            kitap.Yayinevi = txtYayinevi.Text;
            kitap.ISBN = txtISBN.Text;
            kitap.BasimYili = Convert.ToInt32(txtBasimYili.Value);
            kitap.BaskiSayisi = Convert.ToInt32(txtBaskiSayisi.Value);

            Kitap.kitaplar.Add(kitap);
        }
    }
}
