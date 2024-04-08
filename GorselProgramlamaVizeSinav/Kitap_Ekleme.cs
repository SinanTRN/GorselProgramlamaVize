using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        SQLiteConnection baglanti;
        public Kitap_Ekleme()
        {
            InitializeComponent();

            string baglanti_metni = "Data Source=kutuphane.db;Version=3;";
            try
            {
                baglanti = new SQLiteConnection(baglanti_metni);
                baglanti.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQLite Baglantısı kurulamadı",
                                "Bağlantı hatası",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {


            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = $"INSERT INTO kitaplar (baslik,yazar,yayinevi,ISBN,baski_sayisi,basim_yili,adet) VALUES(\"{txtBaslik.Text.Trim()}\",\"{txtYazar.Text}\"," +
                $"                                                                           \"{txtYayinevi.Text}\",\"{txtISBN.Text}\"," +
                $"                                                                            \"{txtBaskiSayisi.Text}\",\"{txtBasimYili.Text}\"," +
                $"                                                                             \"{txtAdet.Text}\")";


            komut.ExecuteNonQuery();

            //kitap = new Kitap();
            //kitap.Baslik = txtBaslik.Text;
            //kitap.Yazar = txtYazar.Text;
            //kitap.Yayinevi = txtYayinevi.Text;
            //kitap.ISBN = txtISBN.Text;
            //kitap.BasimYili = Convert.ToInt32(txtBasimYili.Value);
            //kitap.BaskiSayisi = Convert.ToInt32(txtBaskiSayisi.Value);
            //kitap.Adet=Convert.ToInt32(txtAdet.Value);

            //Kitap.kitaplar.Add(kitap);
            this.Close();
        }

        private void Kitap_Ekleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (baglanti != null && baglanti.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQLite Baglantisi sonlandirilirken hata ile karsilasildi",
                                    "Baglanti sonlandirma hatasi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
