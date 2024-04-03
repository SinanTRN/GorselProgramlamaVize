﻿using System;
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

            foreach (var kitap in Kitap.kitaplar)
            {
                kitap.tabloyaEkle(dtKitap);
            }
            dgvKitaplar.DataSource = dtKitap;
        }

        private void btnSilKitap_Click(object sender, EventArgs e)
        {
            if (txtBaslikGuncelle.Text != "" && txtYazarGuncelle.Text != "" && txtYayinEviGuncelle.Text != "" && txtISBNGuncelle.Text != "" &&
                txtBaskiSayisiGuncelle.Value != 0 && txtBasimYiliGuncelle.Value != 0)
            {
                string Id = dgvKitaplar.CurrentRow.Cells[3].Value + "";

                for (int i = Kitap.kitaplar.Count - 1; i >= 0; i--)
                {
                    if (Kitap.kitaplar[i].ISBN == Id)
                    {
                        Kitap.kitaplar.Remove(Kitap.kitaplar[i]);
                    }
                }
                dtKitap.Rows.Clear();
                dgvKitaplar.DataSource = dtKitap;

                foreach (var kitap in Kitap.kitaplar)
                {
                    kitap.tabloyaEkle(dtKitap);
                }

                dgvKitaplar.DataSource = dtKitap;

                txtBaslikGuncelle.Text = "";
                txtYazarGuncelle.Text = "";
                txtYayinEviGuncelle.Text = "";
                txtISBNGuncelle.Text = "";
                txtBasimYiliGuncelle.Value = 0;
                txtBaskiSayisiGuncelle.Value = 0;
                txtAdetGuncelle.Value = 0;
            }
            else
            {
                MessageBox.Show("Lutfen uye seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void KitapSilGuncelle_Load(object sender, EventArgs e)
        {
            //foreach (var kitap in Kitap.kitaplar)
            //{
            //    kitap.tabloyaEkle(dtKitap);
            //}
            //dgvKitaplar.DataSource = dtKitap;
        }

        private void btnGuncelleKitap_Click(object sender, EventArgs e)
        {
            if (txtBaslikGuncelle.Text != "" && txtYazarGuncelle.Text != "" && txtYayinEviGuncelle.Text != "" && txtISBNGuncelle.Text != "" &&
                txtBaskiSayisiGuncelle.Value != 0 && txtBasimYiliGuncelle.Value != 0)
            {
                string isbn = dgvKitaplar.CurrentRow.Cells[3].Value + "";

                foreach (var kitap in Kitap.kitaplar)
                {
                    if (kitap.ISBN == isbn)
                    {
                        kitap.Baslik = txtBaslikGuncelle.Text;
                        kitap.Yazar = txtYazarGuncelle.Text;
                        kitap.Yayinevi = txtYayinEviGuncelle.Text;
                        kitap.ISBN = txtISBNGuncelle.Text;
                        kitap.BasimYili = Convert.ToInt32(txtBasimYiliGuncelle.Value);
                        kitap.BaskiSayisi = Convert.ToInt32(txtBaskiSayisiGuncelle.Value);
                        kitap.Adet = Convert.ToInt32(txtAdetGuncelle.Value);
                    }
                }
                dtKitap.Rows.Clear();
                dgvKitaplar.DataSource = dtKitap;

                foreach (var kitap in Kitap.kitaplar)
                {
                    kitap.tabloyaEkle(dtKitap);
                }

                dgvKitaplar.DataSource =dtKitap;


                txtBaslikGuncelle.Text = "";
                txtYazarGuncelle.Text = "";
                txtYayinEviGuncelle.Text = "";
                txtISBNGuncelle.Text = "";
                txtBasimYiliGuncelle.Value = 0;
                txtBaskiSayisiGuncelle.Value = 0;
                txtAdetGuncelle.Value = 0;

            }
            else
            {
                MessageBox.Show("Lutfen uye seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvKitaplar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKitaplar.CurrentRow != null)
            {
                string Id = dgvKitaplar.CurrentRow.Cells[3].Value+"";
                foreach (var kitap in Kitap.kitaplar)
                {
                    if (kitap.ISBN == Id)
                    {
                        txtBaslikGuncelle.Text = kitap.Baslik;
                        txtYazarGuncelle.Text = kitap.Yazar;
                        txtYayinEviGuncelle.Text = kitap.Yayinevi;
                        txtISBNGuncelle.Text = kitap.ISBN;
                        txtBasimYiliGuncelle.Value = kitap.BasimYili;
                        txtBaskiSayisiGuncelle.Value= kitap.BaskiSayisi;
                        txtAdetGuncelle.Value = kitap.Adet;
                    }
                }
            }
        }
    }
}
