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
    public partial class SureUzat : Form
    {
        Emanet_Islemleri f_emanet;
        SQLiteConnection baglanti;

        public SureUzat()
        {
            InitializeComponent();
        }
        public SureUzat(Emanet_Islemleri form)
        {
            f_emanet = form;
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

        private void btnOkSure_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(f_emanet.txtEmanetId.Text);

                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = $"UPDATE emanetler SET teslim_Tarihi=\"{dtpTeslimTarihiSure.Value}\" WHERE emanet_Id={id}";

                int eklenen_sayisi = komut.ExecuteNonQuery();
                if (eklenen_sayisi > 0)
                    f_emanet.form1.tabloGuncelle();
            }
            catch (Exception ex) { }
            //    if (f_emanet.txtEmanetBaslik.Text != "" && f_emanet.txtEmanetYazar.Text != "")
            //    {

            //        foreach (var emanet in Emanet.emanetler)
            //        {
            //            if (emanet.KitapBaslik == f_emanet.txtEmanetBaslik.Text && emanet.KitapYazar == f_emanet.txtEmanetYazar.Text)
            //            {
            //                emanet.TeslimTarihi = dtpTeslimTarihiSure.Value;
            //            }
            //        }
            //        f_emanet.form1.dtEmanet.Rows.Clear();

            //        f_emanet.form1.dgvEmanetler.DataSource = f_emanet.form1.dtEmanet;

            //        foreach (var emanet in Emanet.emanetler)
            //        {
            //            emanet.tabloyaEkle(f_emanet.form1.dtEmanet);
            //        }

            //        f_emanet.form1.dgvEmanetler.DataSource = f_emanet.form1.dtEmanet;

            //    }
            //    else
            //    {
            //        MessageBox.Show("Lutfen uye seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
        }

        private void txtSureUzatma_TextChanged(object sender, EventArgs e)
        {
            dtpTeslimTarihiSure.Value = DateTime.Now.AddDays(Convert.ToInt32(txtSureUzatma.Text));

        }

        private void SureUzat_FormClosing(object sender, FormClosingEventArgs e)
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
