namespace GorselProgramlamaVizeSinav
{
    partial class Uye_Ekleme
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
            txtAra = new TextBox();
            label1 = new Label();
            btnAra = new Button();
            dgvUyeler = new DataGridView();
            groupBox1 = new GroupBox();
            txtSoyisim = new TextBox();
            label2 = new Label();
            txtIsim = new TextBox();
            groupBox2 = new GroupBox();
            txtMail = new TextBox();
            label4 = new Label();
            txtTelefon = new TextBox();
            label3 = new Label();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtAra
            // 
            txtAra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAra.Location = new Point(22, 19);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(429, 23);
            txtAra.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(6, 60);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 1;
            label1.Text = "İsim";
            // 
            // btnAra
            // 
            btnAra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAra.Location = new Point(457, 18);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(94, 23);
            btnAra.TabIndex = 9;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            // 
            // dgvUyeler
            // 
            dgvUyeler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUyeler.BackgroundColor = SystemColors.InactiveCaption;
            dgvUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUyeler.GridColor = SystemColors.GradientActiveCaption;
            dgvUyeler.Location = new Point(22, 47);
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.Size = new Size(529, 429);
            dgvUyeler.TabIndex = 3;
            dgvUyeler.CellContentClick += dgvUyeler_CellContentClick;
            dgvUyeler.SelectionChanged += dgvUyeler_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(txtSoyisim);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIsim);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(575, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "\U0001f935isim";
            // 
            // txtSoyisim
            // 
            txtSoyisim.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtSoyisim.Location = new Point(189, 28);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(119, 29);
            txtSoyisim.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(189, 60);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyisim";
            // 
            // txtIsim
            // 
            txtIsim.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtIsim.Location = new Point(6, 28);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(165, 29);
            txtIsim.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(txtMail);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTelefon);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(575, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(314, 117);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "📞İletişim";
            // 
            // txtMail
            // 
            txtMail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtMail.Location = new Point(107, 64);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(201, 29);
            txtMail.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(6, 72);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 0;
            label4.Text = "Mail";
            // 
            // txtTelefon
            // 
            txtTelefon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtTelefon.Location = new Point(107, 29);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(201, 29);
            txtTelefon.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(6, 37);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 0;
            label3.Text = "Telefon";
            // 
            // btnEkle
            // 
            btnEkle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEkle.BackColor = Color.LightGreen;
            btnEkle.ForeColor = Color.Transparent;
            btnEkle.Location = new Point(806, 297);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(83, 23);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuncelle.BackColor = Color.Chocolate;
            btnGuncelle.ForeColor = Color.Transparent;
            btnGuncelle.Location = new Point(700, 297);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(100, 23);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSil.BackColor = Color.Red;
            btnSil.ForeColor = Color.Transparent;
            btnSil.Location = new Point(575, 297);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(119, 23);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // Uye_Ekleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 488);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvUyeler);
            Controls.Add(btnAra);
            Controls.Add(txtAra);
            Name = "Uye_Ekleme";
            Text = "Uye_Ekleme";
            FormClosing += Uye_Ekleme_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAra;
        private Label label1;
        private Button btnAra;
        private GroupBox groupBox1;
        private TextBox txtSoyisim;
        private Label label2;
        private TextBox txtIsim;
        private GroupBox groupBox2;
        private TextBox txtMail;
        private Label label4;
        private TextBox txtTelefon;
        private Label label3;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        public DataGridView dgvUyeler;
    }
}