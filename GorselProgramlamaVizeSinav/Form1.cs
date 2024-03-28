using System.Data;
using System.Text.Json;
using System.Text;

namespace GorselProgramlamaVizeSinav
{
    public partial class Form1 : Form
    {
        DataTable dtEmanet;
        private List<Emanet> emanetler;

        public Form1()
        {
            InitializeComponent();

            dtEmanet = new DataTable();
            dtEmanet.Columns.Add("Emanent ID");
            dtEmanet.Columns.Add("Üye ID");
            dtEmanet.Columns.Add("isim");
            dtEmanet.Columns.Add("Soyisim");
            dtEmanet.Columns.Add("Baþlýk");
            dtEmanet.Columns.Add("Yazar");
            dtEmanet.Columns.Add("Alýndýðý Tarih");
            dtEmanet.Columns.Add("Teslim Tarihi");

            dgvEmanetler.DataSource = dtEmanet;
        }

        private void üyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uye_Ekleme nesne = new Uye_Ekleme();
            nesne.Show();
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

        private void emanetÝþlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
        }

        private void emanetÝþlemleriTsm_Click(object sender, EventArgs e)
        {
            Emanet_Islemleri nesne = new Emanet_Islemleri();
            nesne.Show();
        }

        public static void dosyayaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
