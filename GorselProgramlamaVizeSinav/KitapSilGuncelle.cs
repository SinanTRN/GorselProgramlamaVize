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
    public partial class KitapSilGuncelle : Form
    {
        public DataTable dtKitap;
        public KitapSilGuncelle()
        {
            InitializeComponent();
            dtKitap = new DataTable();
            dtKitap.Columns.Add("Başlık");
            dtKitap.Columns.Add("Yazar");
            dtKitap.Columns.Add("Yayınevi");
            dtKitap.Columns.Add("ISBN Numarası");
            dtKitap.Columns.Add("Baskı Sayısı");
            dtKitap.Columns.Add("Basım Yılı");
            dtKitap.Columns.Add("Adeti");

            dgvKitaplar.DataSource = dtKitap;
        }

        private void btnSilKitap_Click(object sender, EventArgs e)
        {

        }

        private void KitapSilGuncelle_Load(object sender, EventArgs e)
        {
            //foreach (var kitap in Kitap.kitaplar)
            //{
            //    kitap.tabloyaEkle(dtKitap);
            //}
            //dgvKitaplar.DataSource = dtKitap;
        }
    }
}
