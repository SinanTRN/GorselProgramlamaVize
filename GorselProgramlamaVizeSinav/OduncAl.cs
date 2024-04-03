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
        public Emanet emanet;
        string txtEmanetBaslik = "";
        string txtEmanetYazar = "";
        Form1 form1;
        public OduncAl(string a,string b,Form1 form)
        {
            txtEmanetBaslik = a;
            txtEmanetYazar = b;
            form1= form;
            InitializeComponent();
        }
        public OduncAl()
        {
            InitializeComponent();
        }



        private void btnOkOdunc_Click(object sender, EventArgs e)
        {
            emanet = new Emanet();
            emanet.KitapBaslik= txtEmanetBaslik;
            emanet.KitapYazar= txtEmanetYazar;
            emanet.UyeIsmi = txtIsimOdunc.Text;
            emanet.uyeSoyismi = txtSoyisimOdunc.Text;
            emanet.UyeId = Convert.ToInt32(txtIdOdunc.Text);
            emanet.AlinmaTarihi = DateTime.Now;
            emanet.TeslimTarihi = dtpTeslimTarihiOdunc.Value;

            emanet.tabloyaEkle(form1.dtEmanet);
            Emanet.emanetler.Add(emanet);
           
            form1.dgvEmanetler.DataSource = form1.dtEmanet;

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
