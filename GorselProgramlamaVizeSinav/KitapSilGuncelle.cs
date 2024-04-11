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
    public partial class KitapSilGuncelle : Form
    {
        public DataTable dtKitap;
        SQLiteConnection baglanti;
        public KitapSilGuncelle()
        {
            InitializeComponent();

            string baglanti_metni = "Data Source=kutuphane.db;Version=3;";

            try
            {
                baglanti = new SQLiteConnection(baglanti_metni);
                baglanti.Open();
                tabloGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQLite Baglantısı kurulamadı",
                                "Bağlantı hatası",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        public void tabloGuncelle()
        {
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM kitaplar";

            dtKitap = new DataTable();
            dtKitap.Columns.Add("Başlık");
            dtKitap.Columns.Add("Yazar");
            dtKitap.Columns.Add("Yayınevi");
            dtKitap.Columns.Add("ISBN Numarası");
            dtKitap.Columns.Add("Baskı Sayısı");
            dtKitap.Columns.Add("Basım Yılı");
            dtKitap.Columns.Add("Adeti");

            var okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                dtKitap.Rows.Add(new object[] { okuyucu.GetString(0) ,
                                                   okuyucu.GetString(1),
                                                    okuyucu.GetString(2),
                                                    okuyucu.GetString(3),
                                                    okuyucu.GetInt32(4),
                                                    okuyucu.GetInt32(5),
                                                    okuyucu.GetInt32(6)});

            }
            dgvKitaplar.DataSource = dtKitap;
        }

        private void btnSilKitap_Click(object sender, EventArgs e)
        {
            if (txtBaslikGuncelle.Text != "" && txtYazarGuncelle.Text != "" && txtYayinEviGuncelle.Text != "" && txtISBNGuncelle.Text != "" &&
                txtBaskiSayisiGuncelle.Value != 0 && txtBasimYiliGuncelle.Value != 0)
            {
                try
                {
                    string isbn = dgvKitaplar.CurrentRow.Cells[3].Value +"";

                    SQLiteCommand komut = new SQLiteCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = $"DELETE FROM kitaplar WHERE ISBN = {isbn}";

                    int eklenen_sayisi = komut.ExecuteNonQuery();
                    if (eklenen_sayisi > 0)
                        tabloGuncelle();
                }
                catch (Exception ex) { }

                //string Id = dgvKitaplar.CurrentRow.Cells[3].Value + "";

                //for (int i = Kitap.kitaplar.Count - 1; i >= 0; i--)
                //{
                //    if (Kitap.kitaplar[i].ISBN == Id)
                //    {
                //        Kitap.kitaplar.Remove(Kitap.kitaplar[i]);
                //    }
                //}
                //dtKitap.Rows.Clear();
                //dgvKitaplar.DataSource = dtKitap;

                //foreach (var kitap in Kitap.kitaplar)
                //{
                //    kitap.tabloyaEkle(dtKitap);
                //}

                //dgvKitaplar.DataSource = dtKitap;

                txtBaslikGuncelle.Text = "";
                txtYazarGuncelle.Text = "";
                txtYayinEviGuncelle.Text = "";
                txtISBNGuncelle.Text = "";
                txtBasimYiliGuncelle.Value = 0;
                txtBaskiSayisiGuncelle.Value = 0;
                txtAdetGuncelle.Value = 0;
            }
            else
            {
                MessageBox.Show("Lutfen kitap seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuncelleKitap_Click(object sender, EventArgs e)
        {
            if (txtBaslikGuncelle.Text != "" && txtYazarGuncelle.Text != "" && txtYayinEviGuncelle.Text != "" && txtISBNGuncelle.Text != "" &&
                txtBaskiSayisiGuncelle.Value != 0 && txtBasimYiliGuncelle.Value != 0)
            {      
                try
                {
                    string isbn = dgvKitaplar.CurrentRow.Cells[3].Value + "";

                    SQLiteCommand komut = new SQLiteCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = $"UPDATE kitaplar SET baslik=\"{txtBaslikGuncelle.Text}\"," +
                        $"                                  yazar=\"{txtYazarGuncelle.Text}\"," +
                        $"                                  yayinevi=\"{txtYayinEviGuncelle.Text}\"," +
                        $"                                  ISBN=\"{txtISBNGuncelle.Text}\"," +
                        $"                                  baski_sayisi=\"{txtBaskiSayisiGuncelle.Value}\"," +
                        $"                                  basim_yili=\"{txtBasimYiliGuncelle.Value}\"," +
                        $"                                  adet=\"{txtAdetGuncelle.Value}\" WHERE ISBN={isbn}";

                    int eklenen_sayisi = komut.ExecuteNonQuery();
                    if (eklenen_sayisi > 0)
                        tabloGuncelle();
                }
                catch (Exception ex) { }



                //foreach (var kitap in Kitap.kitaplar)
                //{
                //    if (kitap.ISBN == isbn)
                //    {
                //        kitap.Baslik = txtBaslikGuncelle.Text;
                //        kitap.Yazar = txtYazarGuncelle.Text;
                //        kitap.Yayinevi = txtYayinEviGuncelle.Text;
                //        kitap.ISBN = txtISBNGuncelle.Text;
                //        kitap.BasimYili = Convert.ToInt32(txtBasimYiliGuncelle.Value);
                //        kitap.BaskiSayisi = Convert.ToInt32(txtBaskiSayisiGuncelle.Value);
                //        kitap.Adet = Convert.ToInt32(txtAdetGuncelle.Value);
                //    }
                //}
                //dtKitap.Rows.Clear();
                //dgvKitaplar.DataSource = dtKitap;

                //foreach (var kitap in Kitap.kitaplar)
                //{
                //    kitap.tabloyaEkle(dtKitap);
                //}

                //dgvKitaplar.DataSource = dtKitap;


                txtBaslikGuncelle.Text = "";
                txtYazarGuncelle.Text = "";
                txtYayinEviGuncelle.Text = "";
                txtISBNGuncelle.Text = "";
                txtBasimYiliGuncelle.Value = 0;
                txtBaskiSayisiGuncelle.Value = 0;
                txtAdetGuncelle.Value = 0;

            }
            else
            {
                MessageBox.Show("Lutfen kitap seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void KitapSilGuncelle_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBaslikGuncelle.Text = dgvKitaplar.CurrentRow.Cells[0].Value.ToString();
            txtYazarGuncelle.Text = dgvKitaplar.CurrentRow.Cells[1].Value.ToString();
            txtYayinEviGuncelle.Text = dgvKitaplar.CurrentRow.Cells[2].Value.ToString();
            txtISBNGuncelle.Text = dgvKitaplar.CurrentRow.Cells[3].Value.ToString();
            txtBaskiSayisiGuncelle.Value = Convert.ToInt32(dgvKitaplar.CurrentRow.Cells[4].Value.ToString());
            txtBasimYiliGuncelle.Value = Convert.ToInt32(dgvKitaplar.CurrentRow.Cells[5].Value.ToString());
            txtAdetGuncelle.Value = Convert.ToInt32(dgvKitaplar.CurrentRow.Cells[6].Value.ToString());
        }
    }
}
