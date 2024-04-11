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
    public partial class SureUzat : Form
    {
        Emanet_Islemleri f_emanet;
        public SureUzat()
        {
            InitializeComponent();
        }
        public SureUzat(Emanet_Islemleri form)
        {
            f_emanet = form;
            InitializeComponent();
        }

        private void btnOkSure_Click(object sender, EventArgs e)
        {
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
    }
}
