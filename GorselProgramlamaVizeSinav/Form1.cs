using System.Data;
using System.Text.Json;
using System.Text;
using System.Data.SQLite;

namespace GorselProgramlamaVizeSinav
{
    public partial class Form1 : Form
    {
        public DataTable dtEmanet;
        private List<Emanet> emanetler;

        SQLiteConnection baglanti;

        public Form1()
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
                MessageBox.Show("SQLite Baglantýsý kurulamadý",
                                "Baðlantý hatasý",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            //dtEmanet = new DataTable();
            //dtEmanet.Columns.Add("Emanent ID");
            //dtEmanet.Columns.Add("Üye ID");
            //dtEmanet.Columns.Add("isim");
            //dtEmanet.Columns.Add("Soyisim");
            //dtEmanet.Columns.Add("Baþlýk");
            //dtEmanet.Columns.Add("Yazar");
            //dtEmanet.Columns.Add("Alýndýðý Tarih");
            //dtEmanet.Columns.Add("Teslim Tarihi");

            //dgvEmanetler.DataSource = dtEmanet;
        }
        public void tabloGuncelle()
        {
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM emanetler";

            dtEmanet = new DataTable();
            dtEmanet.Columns.Add("Emanent ID");
            dtEmanet.Columns.Add("Üye ID");
            dtEmanet.Columns.Add("Ýsim");
            dtEmanet.Columns.Add("Soyisim");
            dtEmanet.Columns.Add("Baþlýk");
            dtEmanet.Columns.Add("Yazar");
            dtEmanet.Columns.Add("Alýndýðý Tarih");
            dtEmanet.Columns.Add("Teslim Tarihi");

            var okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                dtEmanet.Rows.Add(new object[] { okuyucu.GetInt32(0) ,
                                                   okuyucu.GetInt32(1),
                                                    okuyucu.GetString(2),
                                                    okuyucu.GetString(3),
                                                    okuyucu.GetString(4),
                                                    okuyucu.GetString(5),
                                                    okuyucu.GetString(6),
                                                    okuyucu.GetString(7)});

            }
            dgvEmanetler.DataSource = dtEmanet;
        }
        private void kitapEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kitap_Ekleme nesne = new Kitap_Ekleme();
            nesne.Show();
        }

        private void kitapGüncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapSilGuncelle nesne = new KitapSilGuncelle();
            nesne.ShowDialog();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
        }

        private void emanetÝþlemleriTsm_Click(object sender, EventArgs e)
        {
            Emanet_Islemleri nesne = new Emanet_Islemleri(this);
            nesne.Show();
        }

        private void dosyadanOkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSon Dosyasý|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);
                Emanet.emanetler = JsonSerializer.Deserialize<List<Emanet>>(data);
                foreach (Emanet emanet in Emanet.emanetler)
                {
                    emanet.tabloyaEkle(dtEmanet);
                }
            }


        }

        private void üyeleriDosyayaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonSerializer.Serialize<List<Uye>>(Uye.uyeler);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSon Dosyasý|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string dosyaYolu = dialog.FileName;
                File.WriteAllText(dosyaYolu, yazilacak, Encoding.UTF8);

            }
        }

        private void üyeOperasyonlarýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uye_Ekleme nesne = new Uye_Ekleme();
            nesne.Show();
        }

        private void üyeleriDosyadanOkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uye_Ekleme nesne = new Uye_Ekleme();
            nesne.Show();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSon Dosyasý|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);
                Uye.uyeler = JsonSerializer.Deserialize<List<Uye>>(data);
                foreach (Uye uye in Uye.uyeler)
                {
                    uye.tabloyaEkle(nesne.dtUyeler);
                }
            }
            nesne.dgvUyeler.DataSource = nesne.dtUyeler;
        }

        private void kitaplarýDosyayaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonSerializer.Serialize<List<Kitap>>(Kitap.kitaplar);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSon Dosyasý|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string dosyaYolu = dialog.FileName;
                File.WriteAllText(dosyaYolu, yazilacak, Encoding.UTF8);

            }
        }

        private void kitaplarýDosyadanOkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //KitapSilGuncelle nesne = new KitapSilGuncelle();
            //nesne.Show();

            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "JSon Dosyasý|*.json";
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    string data = File.ReadAllText(dialog.FileName);
            //    Kitap.kitaplar = JsonSerializer.Deserialize<List<Kitap>>(data);
            //    foreach (Kitap kitap in Kitap.kitaplar)
            //    {
            //        kitap.tabloyaEkle(nesne.dtKitap);
            //    }
            //}
            //nesne.dgvKitaplar.DataSource = nesne.dtKitap;
        }

        private void dosyayaKaydetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string yazilacak = JsonSerializer.Serialize<List<Emanet>>(Emanet.emanetler);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSon Dosyasý|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string dosyaYolu = dialog.FileName;
                File.WriteAllText(dosyaYolu, yazilacak, Encoding.UTF8);

            }
        }
    }
}
