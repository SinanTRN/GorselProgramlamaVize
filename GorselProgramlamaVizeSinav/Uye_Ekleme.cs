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
    public partial class Uye_Ekleme : Form
    {
        public DataTable dtUyeler;
        Uye uye;
        SQLiteConnection baglanti;
        public Uye_Ekleme()
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
            komut.CommandText = "SELECT * FROM uyeler";

            dtUyeler = new DataTable();
            dtUyeler.Columns.Add("ID");
            dtUyeler.Columns.Add("İsim");
            dtUyeler.Columns.Add("Soyisim");
            dtUyeler.Columns.Add("E Posta");
            dtUyeler.Columns.Add("Telefon");

            var okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                dtUyeler.Rows.Add(new object[] { okuyucu.GetInt32(0) ,
                                                   okuyucu.GetString(1),
                                                    okuyucu.GetString(2),
                                                    okuyucu.IsDBNull(3) ? "" : okuyucu.GetString(3),
                                                    okuyucu.GetString(4)});

            }
            dgvUyeler.DataSource = dtUyeler;
        }

        private void dgvUyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = $"INSERT INTO uyeler (telefon,isim,soyisim,email) VALUES(\"{txtTelefon.Text}\", \"{txtIsim.Text}\", \"{txtSoyisim.Text}\", \"{txtMail.Text}\")";


            int eklenen_sayisi = komut.ExecuteNonQuery();
            if (eklenen_sayisi > 0)
                tabloGuncelle();

            txtTelefon.Text = "";
            txtIsim.Text = "";
            txtSoyisim.Text = "";
            txtMail.Text = "";


            //uye = new Uye();
            //uye.Isim = txtIsim.Text;
            //uye.Soyisim = txtSoyisim.Text;
            //uye.Telefon = txtTelefon.Text;
            //uye.Eposta = txtMail.Text;

            //uye.tabloyaEkle(dtUyeler);
            //Uye.uyeler.Add(uye);

            //dgvUyeler.DataSource = dtUyeler;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text != "" && txtSoyisim.Text != "" && txtTelefon.Text != "" && txtMail.Text != "")
            {
                int Id = Convert.ToInt32(dgvUyeler.CurrentRow.Cells[0].Value);

                foreach (var uye in Uye.uyeler)
                {
                    if (uye.ID == Id)
                    {
                        uye.Isim = txtIsim.Text;
                        uye.Soyisim = txtSoyisim.Text;
                        uye.Telefon = txtTelefon.Text;
                        uye.Eposta = txtMail.Text;
                    }
                }
                dtUyeler.Rows.Clear();
                dgvUyeler.DataSource = dtUyeler;

                foreach (var uye in Uye.uyeler)
                {
                    uye.tabloyaEkle(dtUyeler);
                }

                dgvUyeler.DataSource = dtUyeler;

            }
            else
            {
                MessageBox.Show("Lutfen uye seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvUyeler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUyeler.CurrentRow != null)
            {
                int Id = Convert.ToInt32(dgvUyeler.CurrentRow.Cells[0].Value);
                foreach (var uye in Uye.uyeler)
                {
                    if (uye.ID == Id)
                    {
                        txtIsim.Text = uye.Isim;
                        txtSoyisim.Text = uye.Soyisim;
                        txtTelefon.Text = uye.Telefon;
                        txtMail.Text = uye.Eposta;
                    }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text != "" && txtSoyisim.Text != "" && txtTelefon.Text != "" && txtMail.Text != "")
            {
                int Id = Convert.ToInt32(dgvUyeler.CurrentRow.Cells[0].Value);

                for (int i = Uye.uyeler.Count - 1; i >= 0; i--)
                {
                    if (Uye.uyeler[i].ID == Id)
                    {
                        Uye.uyeler.Remove(Uye.uyeler[i]);
                    }
                }
                dtUyeler.Rows.Clear();
                dgvUyeler.DataSource = dtUyeler;

                foreach (var uye in Uye.uyeler)
                {
                    uye.tabloyaEkle(dtUyeler);
                }

                dgvUyeler.DataSource = dtUyeler;

            }
            else
            {
                MessageBox.Show("Lutfen uye seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Uye_Ekleme_FormClosing(object sender, FormClosingEventArgs e)
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
