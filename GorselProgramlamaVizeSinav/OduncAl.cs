using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaVizeSinav
{
    public partial class OduncAl : Form
    {
        public Emanet emanet;
        Form1 form1;

        SQLiteConnection baglanti;
        public OduncAl(Form1 form)
        {
            form1 = form;
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
        public OduncAl()
        {
            InitializeComponent();
        }



        private void btnOkOdunc_Click(object sender, EventArgs e)
        {


            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = $"INSERT INTO emanetler (uye_Id,uye_Ismi,uye_Soyismi,kitap_Baslik,kitap_Yazar,alınan_Tarih,teslim_Tarihi) VALUES(\"{Convert.ToInt32(txtIdOdunc.Text)}\",\"{txtIsimOdunc.Text}\"," +
                $"                                                                           \"{txtSoyisimOdunc.Text}\",\"{txtBaslikEmanet.Text}\"," +
                $"                                                                            \"{txtYazarEmanet.Text}\",\"{DateTime.Now.ToString()}\"," +
                $"                                                                             \"{dtpTeslimTarihiOdunc.Value.ToString()}\")";


            komut.ExecuteNonQuery();
            form1.tabloGuncelle();
            //emanet = new Emanet();
            //emanet.KitapBaslik= txtEmanetBaslik;
            //emanet.KitapYazar= txtEmanetYazar;
            //emanet.UyeIsmi = txtIsimOdunc.Text;
            //emanet.uyeSoyismi = txtSoyisimOdunc.Text;
            //emanet.UyeId = Convert.ToInt32(txtIdOdunc.Text);
            //emanet.AlinmaTarihi = DateTime.Now;
            //emanet.TeslimTarihi = dtpTeslimTarihiOdunc.Value;

            //emanet.tabloyaEkle(form1.dtEmanet);
            //Emanet.emanetler.Add(emanet);

            //form1.dgvEmanetler.DataSource = form1.dtEmanet;

            this.Close();
        }

        private void OduncAl_Load(object sender, EventArgs e)
        {

        }

        private void txtSureOdunc_TextChanged(object sender, EventArgs e)
        {
            dtpTeslimTarihiOdunc.Value = DateTime.Now.AddDays(Convert.ToInt32(txtSureOdunc.Text));
        }

        private void OduncAl_FormClosing(object sender, FormClosingEventArgs e)
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
