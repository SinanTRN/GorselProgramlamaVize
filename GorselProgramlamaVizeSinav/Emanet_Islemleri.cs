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
    public partial class Emanet_Islemleri : Form
    {
        public Form1 form1;
        public Emanet_Islemleri()
        {
            InitializeComponent();
        }
        public Emanet_Islemleri(Form1 nesne)
        {
            this.form1 = nesne;
            InitializeComponent();
        }

        private void btnOduncAl_Click(object sender, EventArgs e)
        {
            OduncAl nesne = new OduncAl(txtEmanetBaslik.Text, txtEmanetYazar.Text, form1);
            nesne.ShowDialog();
            txtEmanetBaslik.Text = "";
            txtEmanetYazar.Text = "";
        }

        private void btnSureUzat_Click(object sender, EventArgs e)
        {
            SureUzat nesne = new SureUzat(this);
            nesne.ShowDialog();
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            if (txtEmanetBaslik.Text != "" && txtEmanetYazar.Text != "")
            {

                for (int i = Emanet.emanetler.Count - 1; i >= 0; i--)
                {
                    if (Emanet.emanetler[i].KitapBaslik == txtEmanetBaslik.Text && Emanet.emanetler[i].KitapYazar == txtEmanetYazar.Text)
                    {
                        Emanet.emanetler.Remove(Emanet.emanetler[i]);
                    }
                }
                form1.dtEmanet.Rows.Clear();

                form1.dgvEmanetler.DataSource =form1.dtEmanet;

                foreach (var emanet in Emanet.emanetler)
                {
                    emanet.tabloyaEkle(form1.dtEmanet);
                }

                form1.dgvEmanetler.DataSource = form1.dtEmanet;

            }
            else
            {
                MessageBox.Show("Lutfen uye seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
