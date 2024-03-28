namespace GorselProgramlamaVizeSinav
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            üyeEkleToolStripMenuItem = new ToolStripMenuItem();
            üyeOperasyonlarıToolStripMenuItem = new ToolStripMenuItem();
            üyeleriDosyayaKaydetToolStripMenuItem = new ToolStripMenuItem();
            üyeleriDosyadanOkuToolStripMenuItem = new ToolStripMenuItem();
            kitapEkleToolStripMenuItem = new ToolStripMenuItem();
            kitapEkleToolStripMenuItem1 = new ToolStripMenuItem();
            kitapGüncelleSilToolStripMenuItem = new ToolStripMenuItem();
            emanetİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            emanetİşlemleriTsm = new ToolStripMenuItem();
            dosyayaKaydetToolStripMenuItem = new ToolStripMenuItem();
            dosyadanOkuToolStripMenuItem = new ToolStripMenuItem();
            dgvEmanetler = new DataGridView();
            btnAraMain = new Button();
            txtAraMain = new TextBox();
            kitaplarıDosyayaKaydetToolStripMenuItem = new ToolStripMenuItem();
            kitaplarıDosyadanOkuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmanetler).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { üyeEkleToolStripMenuItem, kitapEkleToolStripMenuItem, emanetİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(862, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // üyeEkleToolStripMenuItem
            // 
            üyeEkleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { üyeOperasyonlarıToolStripMenuItem, üyeleriDosyayaKaydetToolStripMenuItem, üyeleriDosyadanOkuToolStripMenuItem });
            üyeEkleToolStripMenuItem.Name = "üyeEkleToolStripMenuItem";
            üyeEkleToolStripMenuItem.Size = new Size(86, 20);
            üyeEkleToolStripMenuItem.Text = "Üye İşlemleri";
            // 
            // üyeOperasyonlarıToolStripMenuItem
            // 
            üyeOperasyonlarıToolStripMenuItem.Name = "üyeOperasyonlarıToolStripMenuItem";
            üyeOperasyonlarıToolStripMenuItem.Size = new Size(196, 22);
            üyeOperasyonlarıToolStripMenuItem.Text = "Üye Operasyonları";
            üyeOperasyonlarıToolStripMenuItem.Click += üyeOperasyonlarıToolStripMenuItem_Click;
            // 
            // üyeleriDosyayaKaydetToolStripMenuItem
            // 
            üyeleriDosyayaKaydetToolStripMenuItem.Name = "üyeleriDosyayaKaydetToolStripMenuItem";
            üyeleriDosyayaKaydetToolStripMenuItem.Size = new Size(196, 22);
            üyeleriDosyayaKaydetToolStripMenuItem.Text = "Üyeleri Dosyaya Kaydet";
            üyeleriDosyayaKaydetToolStripMenuItem.Click += üyeleriDosyayaKaydetToolStripMenuItem_Click;
            // 
            // üyeleriDosyadanOkuToolStripMenuItem
            // 
            üyeleriDosyadanOkuToolStripMenuItem.Name = "üyeleriDosyadanOkuToolStripMenuItem";
            üyeleriDosyadanOkuToolStripMenuItem.Size = new Size(196, 22);
            üyeleriDosyadanOkuToolStripMenuItem.Text = "Üyeleri Dosyadan Oku";
            üyeleriDosyadanOkuToolStripMenuItem.Click += üyeleriDosyadanOkuToolStripMenuItem_Click;
            // 
            // kitapEkleToolStripMenuItem
            // 
            kitapEkleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kitapEkleToolStripMenuItem1, kitapGüncelleSilToolStripMenuItem, kitaplarıDosyayaKaydetToolStripMenuItem, kitaplarıDosyadanOkuToolStripMenuItem });
            kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            kitapEkleToolStripMenuItem.Size = new Size(93, 20);
            kitapEkleToolStripMenuItem.Text = "Kitap İşlemleri";
            // 
            // kitapEkleToolStripMenuItem1
            // 
            kitapEkleToolStripMenuItem1.Name = "kitapEkleToolStripMenuItem1";
            kitapEkleToolStripMenuItem1.Size = new Size(203, 22);
            kitapEkleToolStripMenuItem1.Text = "Kitap Ekle";
            kitapEkleToolStripMenuItem1.Click += kitapEkleToolStripMenuItem1_Click;
            // 
            // kitapGüncelleSilToolStripMenuItem
            // 
            kitapGüncelleSilToolStripMenuItem.Name = "kitapGüncelleSilToolStripMenuItem";
            kitapGüncelleSilToolStripMenuItem.Size = new Size(203, 22);
            kitapGüncelleSilToolStripMenuItem.Text = "Kitap Güncelle / Sil";
            kitapGüncelleSilToolStripMenuItem.Click += kitapGüncelleSilToolStripMenuItem_Click;
            // 
            // emanetİşlemleriToolStripMenuItem
            // 
            emanetİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { emanetİşlemleriTsm, dosyayaKaydetToolStripMenuItem, dosyadanOkuToolStripMenuItem });
            emanetİşlemleriToolStripMenuItem.Name = "emanetİşlemleriToolStripMenuItem";
            emanetİşlemleriToolStripMenuItem.Size = new Size(59, 20);
            emanetİşlemleriToolStripMenuItem.Text = "Emanet";
            // 
            // emanetİşlemleriTsm
            // 
            emanetİşlemleriTsm.Name = "emanetİşlemleriTsm";
            emanetİşlemleriTsm.Size = new Size(161, 22);
            emanetİşlemleriTsm.Text = "Emanet İşlemleri";
            emanetİşlemleriTsm.Click += emanetİşlemleriTsm_Click;
            // 
            // dosyayaKaydetToolStripMenuItem
            // 
            dosyayaKaydetToolStripMenuItem.Name = "dosyayaKaydetToolStripMenuItem";
            dosyayaKaydetToolStripMenuItem.Size = new Size(161, 22);
            dosyayaKaydetToolStripMenuItem.Text = "Dosyaya Kaydet";
            // 
            // dosyadanOkuToolStripMenuItem
            // 
            dosyadanOkuToolStripMenuItem.Name = "dosyadanOkuToolStripMenuItem";
            dosyadanOkuToolStripMenuItem.Size = new Size(161, 22);
            dosyadanOkuToolStripMenuItem.Text = "Dosyadan Oku";
            dosyadanOkuToolStripMenuItem.Click += dosyadanOkuToolStripMenuItem_Click;
            // 
            // dgvEmanetler
            // 
            dgvEmanetler.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmanetler.BackgroundColor = SystemColors.InactiveCaption;
            dgvEmanetler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmanetler.Location = new Point(12, 77);
            dgvEmanetler.Name = "dgvEmanetler";
            dgvEmanetler.Size = new Size(838, 361);
            dgvEmanetler.TabIndex = 1;
            // 
            // btnAraMain
            // 
            btnAraMain.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAraMain.Location = new Point(759, 48);
            btnAraMain.Name = "btnAraMain";
            btnAraMain.Size = new Size(91, 23);
            btnAraMain.TabIndex = 2;
            btnAraMain.Text = "Ara";
            btnAraMain.UseVisualStyleBackColor = true;
            btnAraMain.Click += btnAra_Click;
            // 
            // txtAraMain
            // 
            txtAraMain.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAraMain.Location = new Point(490, 48);
            txtAraMain.Name = "txtAraMain";
            txtAraMain.Size = new Size(263, 23);
            txtAraMain.TabIndex = 3;
            // 
            // kitaplarıDosyayaKaydetToolStripMenuItem
            // 
            kitaplarıDosyayaKaydetToolStripMenuItem.Name = "kitaplarıDosyayaKaydetToolStripMenuItem";
            kitaplarıDosyayaKaydetToolStripMenuItem.Size = new Size(203, 22);
            kitaplarıDosyayaKaydetToolStripMenuItem.Text = "Kitapları Dosyaya Kaydet";
            // 
            // kitaplarıDosyadanOkuToolStripMenuItem
            // 
            kitaplarıDosyadanOkuToolStripMenuItem.Name = "kitaplarıDosyadanOkuToolStripMenuItem";
            kitaplarıDosyadanOkuToolStripMenuItem.Size = new Size(203, 22);
            kitaplarıDosyadanOkuToolStripMenuItem.Text = "Kitapları Dosyadan Oku";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 450);
            Controls.Add(txtAraMain);
            Controls.Add(btnAraMain);
            Controls.Add(dgvEmanetler);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmanetler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem üyeEkleToolStripMenuItem;
        private ToolStripMenuItem kitapEkleToolStripMenuItem;
        private ToolStripMenuItem emanetİşlemleriToolStripMenuItem;
        private ToolStripMenuItem kitapEkleToolStripMenuItem1;
        private ToolStripMenuItem kitapGüncelleSilToolStripMenuItem;
        private DataGridView dgvEmanetler;
        private Button btnAraMain;
        private TextBox txtAraMain;
        private ToolStripMenuItem emanetİşlemleriTsm;
        private ToolStripMenuItem dosyayaKaydetToolStripMenuItem;
        private ToolStripMenuItem dosyadanOkuToolStripMenuItem;
        private ToolStripMenuItem üyeOperasyonlarıToolStripMenuItem;
        private ToolStripMenuItem üyeleriDosyayaKaydetToolStripMenuItem;
        private ToolStripMenuItem üyeleriDosyadanOkuToolStripMenuItem;
        private ToolStripMenuItem kitaplarıDosyayaKaydetToolStripMenuItem;
        private ToolStripMenuItem kitaplarıDosyadanOkuToolStripMenuItem;
    }
}
