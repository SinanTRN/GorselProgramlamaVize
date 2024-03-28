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
        public DataTable dtUyeler;
        Uye uye;
        public Uye_Ekleme()
        {
            InitializeComponent();
            dtUyeler = new DataTable();
            dtUyeler.Columns.Add("ID");
            dtUyeler.Columns.Add("İsim");
            dtUyeler.Columns.Add("Soyisim");
            dtUyeler.Columns.Add("E Posta");
            dtUyeler.Columns.Add("Telefon");

            dgvUyeler.DataSource = dtUyeler;

        }

        private void dgvUyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            uye=new Uye();
            uye.Isim=txtIsim.Text;
            uye.Soyisim=txtSoyisim.Text;
            uye.Telefon=txtTelefon.Text;
            uye.Eposta=txtMail.Text;

            uye.tabloyaEkle(dtUyeler);
            Uye.uyeler.Add(uye);
            
            dgvUyeler.DataSource = dtUyeler;

        }
    }
}
