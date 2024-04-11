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
    public partial class Emanet_Islemleri : Form
    {
        public Form1 form1;
        SQLiteConnection baglanti;

        public Emanet_Islemleri()
        {
            InitializeComponent();
        }
        public Emanet_Islemleri(Form1 nesne)
        {
            this.form1 = nesne;
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


        private void btnSureUzat_Click(object sender, EventArgs e)
        {
            if (txtEmanetId.Text != "")
            {
                SureUzat nesne = new SureUzat(this);
                nesne.ShowDialog();
            }
            else MessageBox.Show("Lutfen ilgili alanları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            if (txtEmanetId.Text != "")
            {
                try
                {
                    int id = Convert.ToInt32(txtEmanetId.Text);

                    SQLiteCommand komut = new SQLiteCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = $"DELETE FROM emanetler WHERE emanet_Id = {id}";

                    int eklenen_sayisi = komut.ExecuteNonQuery();
                    if (eklenen_sayisi > 0)
                        form1.tabloGuncelle();
                }
                catch (Exception ex) { }

                //for (int i = Emanet.emanetler.Count - 1; i >= 0; i--)
                //{
                //    if (Emanet.emanetler[i].KitapBaslik == txtEmanetBaslik.Text && Emanet.emanetler[i].KitapYazar == txtEmanetYazar.Text)
                //    {
                //        Emanet.emanetler.Remove(Emanet.emanetler[i]);
                //    }
                //}
                //form1.dtEmanet.Rows.Clear();

                //form1.dgvEmanetler.DataSource =form1.dtEmanet;

                //foreach (var emanet in Emanet.emanetler)
                //{
                //    emanet.tabloyaEkle(form1.dtEmanet);
                //}

                //form1.dgvEmanetler.DataSource = form1.dtEmanet;

            }
            else
            {
                MessageBox.Show("Lutfen ilgili alanları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Emanet_Islemleri_FormClosing(object sender, FormClosingEventArgs e)
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
