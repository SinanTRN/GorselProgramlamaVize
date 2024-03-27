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
        private DataTable dtKitap;
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
        }

        private void btnSilKitap_Click(object sender, EventArgs e)
        {

        }
    }
}
