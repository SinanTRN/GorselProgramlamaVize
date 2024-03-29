namespace GorselProgramlamaVizeSinav
{
    partial class Kitap_Ekleme
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
            groupBox1 = new GroupBox();
            txtBasimYili = new NumericUpDown();
            txtAdet = new NumericUpDown();
            txtBaskiSayisi = new NumericUpDown();
            txtISBN = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtYayinevi = new TextBox();
            label3 = new Label();
            txtYazar = new TextBox();
            label2 = new Label();
            txtBaslik = new TextBox();
            label1 = new Label();
            btnIptal = new Button();
            btnEkle = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtBasimYili).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBaskiSayisi).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtBasimYili);
            groupBox1.Controls.Add(txtAdet);
            groupBox1.Controls.Add(txtBaskiSayisi);
            groupBox1.Controls.Add(txtISBN);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtYayinevi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtYazar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBaslik);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(42, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(567, 260);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "📖Kitap";
            // 
            // txtBasimYili
            // 
            txtBasimYili.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBasimYili.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtBasimYili.Location = new Point(79, 197);
            txtBasimYili.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            txtBasimYili.Name = "txtBasimYili";
            txtBasimYili.Size = new Size(120, 23);
            txtBasimYili.TabIndex = 6;
            // 
            // txtAdet
            // 
            txtAdet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAdet.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAdet.Location = new Point(79, 228);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(120, 23);
            txtAdet.TabIndex = 6;
            // 
            // txtBaskiSayisi
            // 
            txtBaskiSayisi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBaskiSayisi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtBaskiSayisi.Location = new Point(79, 168);
            txtBaskiSayisi.Name = "txtBaskiSayisi";
            txtBaskiSayisi.Size = new Size(120, 23);
            txtBaskiSayisi.TabIndex = 5;
            // 
            // txtISBN
            // 
            txtISBN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtISBN.Location = new Point(79, 133);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(305, 29);
            txtISBN.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(6, 197);
            label7.Name = "label7";
            label7.Size = new Size(62, 17);
            label7.TabIndex = 0;
            label7.Text = "Basım Yılı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(6, 228);
            label6.Name = "label6";
            label6.Size = new Size(35, 17);
            label6.TabIndex = 0;
            label6.Text = "Adet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(6, 168);
            label5.Name = "label5";
            label5.Size = new Size(73, 17);
            label5.TabIndex = 0;
            label5.Text = "Baskı Sayısı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(6, 139);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 0;
            label4.Text = "ISBN/ISSN";
            // 
            // txtYayinevi
            // 
            txtYayinevi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtYayinevi.Location = new Point(79, 98);
            txtYayinevi.Name = "txtYayinevi";
            txtYayinevi.Size = new Size(305, 29);
            txtYayinevi.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(6, 104);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 0;
            label3.Text = "Yayınevi";
            // 
            // txtYazar
            // 
            txtYazar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtYazar.Location = new Point(79, 63);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(305, 29);
            txtYazar.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(6, 69);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 0;
            label2.Text = "Yazar";
            // 
            // txtBaslik
            // 
            txtBaslik.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBaslik.Location = new Point(79, 28);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Size = new Size(450, 29);
            txtBaslik.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 0;
            label1.Text = "Başlık";
            // 
            // btnIptal
            // 
            btnIptal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIptal.BackColor = Color.Sienna;
            btnIptal.ForeColor = SystemColors.ButtonHighlight;
            btnIptal.Location = new Point(377, 307);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(113, 23);
            btnIptal.TabIndex = 7;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            btnEkle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEkle.BackColor = Color.RoyalBlue;
            btnEkle.ForeColor = Color.Transparent;
            btnEkle.Location = new Point(496, 307);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(113, 23);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // Kitap_Ekleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 353);
            Controls.Add(btnEkle);
            Controls.Add(btnIptal);
            Controls.Add(groupBox1);
            Name = "Kitap_Ekleme";
            Text = "Kitap_Ekleme";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtBasimYili).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBaskiSayisi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtBaslik;
        private Label label1;
        private TextBox txtISBN;
        private Label label4;
        private TextBox txtYayinevi;
        private Label label3;
        private TextBox txtYazar;
        private Label label2;
        private NumericUpDown txtAdet;
        private NumericUpDown txtBaskiSayisi;
        private Label label6;
        private Label label5;
        private Button btnIptal;
        private Button btnEkle;
        private NumericUpDown txtBasimYili;
        private Label label7;
    }
}