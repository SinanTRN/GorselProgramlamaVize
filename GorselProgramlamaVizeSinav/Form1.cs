namespace GorselProgramlamaVizeSinav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void �yeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uye_Ekleme nesne = new Uye_Ekleme();
            nesne.Show();
        }

        private void kitapEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kitap_Ekleme nesne = new Kitap_Ekleme();
            nesne.Show();
        }

        private void kitapG�ncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapSilGuncelle nesne = new KitapSilGuncelle();
            nesne.ShowDialog();
        }

        private void emanet��lemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Emanet_Islemleri nesne = new Emanet_Islemleri();
            nesne.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

        }
    }
}
