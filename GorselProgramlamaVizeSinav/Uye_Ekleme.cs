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
            uye = new Uye();
            uye.Isim = txtIsim.Text;
            uye.Soyisim = txtSoyisim.Text;
            uye.Telefon = txtTelefon.Text;
            uye.Eposta = txtMail.Text;

            uye.tabloyaEkle(dtUyeler);
            Uye.uyeler.Add(uye);

            dgvUyeler.DataSource = dtUyeler;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text != "" && txtSoyisim.Text != "" && txtTelefon.Text != "" && txtMail.Text != "")
            {
                int Id = Convert.ToInt32(dgvUyeler.CurrentRow.Cells[0].Value);

                foreach (var uye in Uye.uyeler)
                {
                    if (uye.ID == Id)
                    {
                        uye.Isim = txtIsim.Text;
                        uye.Soyisim = txtSoyisim.Text;
                        uye.Telefon = txtTelefon.Text;
                        uye.Eposta = txtMail.Text;
                    }
                }
                dtUyeler.Rows.Clear();
                dgvUyeler.DataSource = dtUyeler;

                foreach (var uye in Uye.uyeler)
                {
                    uye.tabloyaEkle(dtUyeler);
                }

                dgvUyeler.DataSource = dtUyeler;

            }
            else
            {
                MessageBox.Show("Lutfen uye seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvUyeler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUyeler.CurrentRow != null)
            {
                int Id = Convert.ToInt32(dgvUyeler.CurrentRow.Cells[0].Value);
                foreach (var uye in Uye.uyeler)
                {
                    if (uye.ID == Id)
                    {
                        txtIsim.Text = uye.Isim;
                        txtSoyisim.Text = uye.Soyisim;
                        txtTelefon.Text = uye.Telefon;
                        txtMail.Text = uye.Eposta;
                    }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text != "" && txtSoyisim.Text != "" && txtTelefon.Text != "" && txtMail.Text != "")
            {
                int Id = Convert.ToInt32(dgvUyeler.CurrentRow.Cells[0].Value);

                for (int i = Uye.uyeler.Count - 1; i >= 0; i--)
                {
                    if (Uye.uyeler[i].ID == Id)
                    {
                        Uye.uyeler.Remove(Uye.uyeler[i]);
                    }
                }
                dtUyeler.Rows.Clear();
                dgvUyeler.DataSource = dtUyeler;

                foreach (var uye in Uye.uyeler)
                {
                    uye.tabloyaEkle(dtUyeler);
                }

                dgvUyeler.DataSource = dtUyeler;

            }
            else
            {
                MessageBox.Show("Lutfen uye seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
