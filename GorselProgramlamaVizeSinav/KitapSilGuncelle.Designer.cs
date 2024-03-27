namespace GorselProgramlamaVizeSinav
{
    partial class KitapSilGuncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSilKitap = new Button();
            btnGuncelleKitap = new Button();
            dgvKitaplar = new DataGridView();
            btnAraKitap = new Button();
            txtAraKitap = new TextBox();
            groupBox1 = new GroupBox();
            txtAdetGuncelle = new NumericUpDown();
            txtBasimYiliGuncelle = new NumericUpDown();
            txtBaskiSayisiGuncelle = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtISBNGuncelle = new TextBox();
            label4 = new Label();
            txtYayinEviGuncelle = new TextBox();
            label3 = new Label();
            txtYazarGuncelle = new TextBox();
            label2 = new Label();
            txtBaslikGuncelle = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAdetGuncelle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBasimYiliGuncelle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBaskiSayisiGuncelle).BeginInit();
            SuspendLayout();
            // 
            // btnSilKitap
            // 
            btnSilKitap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSilKitap.BackColor = Color.Red;
            btnSilKitap.ForeColor = Color.Transparent;
            btnSilKitap.Location = new Point(705, 324);
            btnSilKitap.Name = "btnSilKitap";
            btnSilKitap.Size = new Size(119, 23);
            btnSilKitap.TabIndex = 8;
            btnSilKitap.Text = "Sil";
            btnSilKitap.UseVisualStyleBackColor = false;
            btnSilKitap.Click += btnSilKitap_Click;
            // 
            // btnGuncelleKitap
            // 
            btnGuncelleKitap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuncelleKitap.BackColor = Color.Chocolate;
            btnGuncelleKitap.ForeColor = Color.Transparent;
            btnGuncelleKitap.Location = new Point(553, 324);
            btnGuncelleKitap.Name = "btnGuncelleKitap";
            btnGuncelleKitap.Size = new Size(134, 23);
            btnGuncelleKitap.TabIndex = 7;
            btnGuncelleKitap.Text = "Güncelle";
            btnGuncelleKitap.UseVisualStyleBackColor = false;
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKitaplar.BackgroundColor = SystemColors.InactiveCaption;
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.GridColor = SystemColors.GradientActiveCaption;
            dgvKitaplar.Location = new Point(26, 44);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.Size = new Size(428, 391);
            dgvKitaplar.TabIndex = 10;
            // 
            // btnAraKitap
            // 
            btnAraKitap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAraKitap.Location = new Point(360, 15);
            btnAraKitap.Name = "btnAraKitap";
            btnAraKitap.Size = new Size(94, 23);
            btnAraKitap.TabIndex = 10;
            btnAraKitap.Text = "Ara";
            btnAraKitap.UseVisualStyleBackColor = true;
            // 
            // txtAraKitap
            // 
            txtAraKitap.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAraKitap.Location = new Point(26, 16);
            txtAraKitap.Name = "txtAraKitap";
            txtAraKitap.Size = new Size(328, 23);
            txtAraKitap.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(txtAdetGuncelle);
            groupBox1.Controls.Add(txtBasimYiliGuncelle);
            groupBox1.Controls.Add(txtBaskiSayisiGuncelle);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtISBNGuncelle);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtYayinEviGuncelle);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtYazarGuncelle);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBaslikGuncelle);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(460, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 274);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "📖Kitap";
            // 
            // txtAdetGuncelle
            // 
            txtAdetGuncelle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAdetGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAdetGuncelle.Location = new Point(93, 230);
            txtAdetGuncelle.Name = "txtAdetGuncelle";
            txtAdetGuncelle.Size = new Size(120, 23);
            txtAdetGuncelle.TabIndex = 6;
            // 
            // txtBasimYiliGuncelle
            // 
            txtBasimYiliGuncelle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBasimYiliGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtBasimYiliGuncelle.Location = new Point(93, 196);
            txtBasimYiliGuncelle.Name = "txtBasimYiliGuncelle";
            txtBasimYiliGuncelle.Size = new Size(120, 23);
            txtBasimYiliGuncelle.TabIndex = 6;
            // 
            // txtBaskiSayisiGuncelle
            // 
            txtBaskiSayisiGuncelle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBaskiSayisiGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtBaskiSayisiGuncelle.Location = new Point(93, 165);
            txtBaskiSayisiGuncelle.Name = "txtBaskiSayisiGuncelle";
            txtBaskiSayisiGuncelle.Size = new Size(120, 23);
            txtBaskiSayisiGuncelle.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(6, 230);
            label7.Name = "label7";
            label7.Size = new Size(35, 17);
            label7.TabIndex = 0;
            label7.Text = "Adet";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(6, 196);
            label6.Name = "label6";
            label6.Size = new Size(62, 17);
            label6.TabIndex = 0;
            label6.Text = "Basım Yılı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(6, 165);
            label5.Name = "label5";
            label5.Size = new Size(73, 17);
            label5.TabIndex = 0;
            label5.Text = "Baskı Sayısı";
            // 
            // txtISBNGuncelle
            // 
            txtISBNGuncelle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtISBNGuncelle.Location = new Point(93, 124);
            txtISBNGuncelle.Name = "txtISBNGuncelle";
            txtISBNGuncelle.Size = new Size(257, 29);
            txtISBNGuncelle.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(6, 130);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 0;
            label4.Text = "ISBN/ISSN";
            // 
            // txtYayinEviGuncelle
            // 
            txtYayinEviGuncelle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtYayinEviGuncelle.Location = new Point(93, 89);
            txtYayinEviGuncelle.Name = "txtYayinEviGuncelle";
            txtYayinEviGuncelle.Size = new Size(257, 29);
            txtYayinEviGuncelle.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(6, 95);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 0;
            label3.Text = "Yayınevi";
            // 
            // txtYazarGuncelle
            // 
            txtYazarGuncelle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtYazarGuncelle.Location = new Point(93, 54);
            txtYazarGuncelle.Name = "txtYazarGuncelle";
            txtYazarGuncelle.Size = new Size(257, 29);
            txtYazarGuncelle.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 0;
            label2.Text = "Yazar";
            // 
            // txtBaslikGuncelle
            // 
            txtBaslikGuncelle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBaslikGuncelle.Location = new Point(93, 19);
            txtBaslikGuncelle.Name = "txtBaslikGuncelle";
            txtBaslikGuncelle.Size = new Size(257, 29);
            txtBaslikGuncelle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 0;
            label1.Text = "Başlık";
            // 
            // KitapSilGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnSilKitap);
            Controls.Add(btnGuncelleKitap);
            Controls.Add(dgvKitaplar);
            Controls.Add(btnAraKitap);
            Controls.Add(txtAraKitap);
            Name = "KitapSilGuncelle";
            Text = "KitapSilGuncelle";
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAdetGuncelle).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBasimYiliGuncelle).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBaskiSayisiGuncelle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSilKitap;
        private Button btnGuncelleKitap;
        private DataGridView dgvKitaplar;
        private Button btnAraKitap;
        private TextBox txtAraKitap;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txtISBNGuncelle;
        private Label label4;
        private TextBox txtYayinEviGuncelle;
        private Label label3;
        private TextBox txtYazarGuncelle;
        private Label label2;
        private TextBox txtBaslikGuncelle;
        private Label label1;
        private NumericUpDown txtBasimYiliGuncelle;
        private NumericUpDown txtBaskiSayisiGuncelle;
        private Label label6;
        private NumericUpDown txtAdetGuncelle;
        private Label label7;
    }
}