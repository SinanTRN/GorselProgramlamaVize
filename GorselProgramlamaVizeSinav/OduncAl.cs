using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Emanet emanet = new Emanet();
        string txtEmanetBaslik = "";
        string txtEmanetYazar = "";
        public OduncAl()
        {
            InitializeComponent();
        }
        public OduncAl(string a,string b)
        {
            txtEmanetBaslik = a;
            txtEmanetYazar = b;
            InitializeComponent();
        }



        private void btnOkOdunc_Click(object sender, EventArgs e)
        {
            emanet.KitapBaslik= txtEmanetBaslik;
            emanet.KitapYazar= txtEmanetYazar;
            emanet.UyeIsmi = txtIsimOdunc.Text;
            emanet.uyeSoyismi = txtSoyisimOdunc.Text;
            emanet.UyeId = Convert.ToInt32(txtIdOdunc.Text);
            emanet.AlinmaTarihi = DateTime.Now;
            emanet.TeslimTarihi = dtpTeslimTarihiOdunc.Value;

            Emanet.emanetler.Add(emanet);
            this.Close();
        }

        private void OduncAl_Load(object sender, EventArgs e)
        {

        }

        private void txtSureOdunc_TextChanged(object sender, EventArgs e)
        {
            dtpTeslimTarihiOdunc.Value = DateTime.Now.AddDays(Convert.ToInt32(txtSureOdunc.Text));
        }

     }
}
