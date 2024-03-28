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
        
        public Emanet_Islemleri()
        {
            InitializeComponent();
        }

        private void btnOduncAl_Click(object sender, EventArgs e)
        {
            
            OduncAl nesne = new OduncAl(txtEmanetBaslik.Text,txtEmanetYazar.Text);
            nesne.ShowDialog();
        }

        private void btnSureUzat_Click(object sender, EventArgs e)
        {
            SureUzat nesne = new SureUzat();
            nesne.ShowDialog();
        }
    }
}
