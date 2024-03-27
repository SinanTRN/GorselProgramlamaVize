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
    public partial class Uye_Ekleme : Form
    {
        DataTable dt;
        public Uye_Ekleme()
        {
            InitializeComponent();
            dt=new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("İsim");
            dt.Columns.Add("Soyisim");
            dt.Columns.Add("E Posta");
            dt.Columns.Add("Telefon");

        }

        private void dgvUyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
