﻿namespace GorselProgramlamaVizeSinav
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
            kitaplarıDosyayaKaydetToolStripMenuItem = new ToolStripMenuItem();
            kitaplarıDosyadanOkuToolStripMenuItem = new ToolStripMenuItem();
            emanetİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            emanetİşlemleriTsm = new ToolStripMenuItem();
            ÖdünçAlTsm = new ToolStripMenuItem();
            dosyadanOkuToolStripMenuItem = new ToolStripMenuItem();
            dosyayaKaydetToolStripMenuItem1 = new ToolStripMenuItem();
            dgvEmanetler = new DataGridView();
            btnAraMain = new Button();
            txtAraMain = new TextBox();
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
            // kitaplarıDosyayaKaydetToolStripMenuItem
            // 
            kitaplarıDosyayaKaydetToolStripMenuItem.Name = "kitaplarıDosyayaKaydetToolStripMenuItem";
            kitaplarıDosyayaKaydetToolStripMenuItem.Size = new Size(203, 22);
            kitaplarıDosyayaKaydetToolStripMenuItem.Text = "Kitapları Dosyaya Kaydet";
            kitaplarıDosyayaKaydetToolStripMenuItem.Click += kitaplarıDosyayaKaydetToolStripMenuItem_Click;
            // 
            // kitaplarıDosyadanOkuToolStripMenuItem
            // 
            kitaplarıDosyadanOkuToolStripMenuItem.Name = "kitaplarıDosyadanOkuToolStripMenuItem";
            kitaplarıDosyadanOkuToolStripMenuItem.Size = new Size(203, 22);
            kitaplarıDosyadanOkuToolStripMenuItem.Text = "Kitapları Dosyadan Oku";
            kitaplarıDosyadanOkuToolStripMenuItem.Click += kitaplarıDosyadanOkuToolStripMenuItem_Click;
            // 
            // emanetİşlemleriToolStripMenuItem
            // 
            emanetİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { emanetİşlemleriTsm, ÖdünçAlTsm, dosyadanOkuToolStripMenuItem, dosyayaKaydetToolStripMenuItem1 });
            emanetİşlemleriToolStripMenuItem.Name = "emanetİşlemleriToolStripMenuItem";
            emanetİşlemleriToolStripMenuItem.Size = new Size(106, 20);
            emanetİşlemleriToolStripMenuItem.Text = "Emanet İşlemleri";
            // 
            // emanetİşlemleriTsm
            // 
            emanetİşlemleriTsm.Name = "emanetİşlemleriTsm";
            emanetİşlemleriTsm.Size = new Size(191, 22);
            emanetİşlemleriTsm.Text = "Emanet iade/süre uzat";
            emanetİşlemleriTsm.Click += emanetİşlemleriTsm_Click;
            // 
            // ÖdünçAlTsm
            // 
            ÖdünçAlTsm.Name = "ÖdünçAlTsm";
            ÖdünçAlTsm.Size = new Size(191, 22);
            ÖdünçAlTsm.Text = "Ödünç Al";
            ÖdünçAlTsm.Click += ÖdünçAlTsm_Click;
            // 
            // dosyadanOkuToolStripMenuItem
            // 
            dosyadanOkuToolStripMenuItem.Name = "dosyadanOkuToolStripMenuItem";
            dosyadanOkuToolStripMenuItem.Size = new Size(191, 22);
            dosyadanOkuToolStripMenuItem.Text = "Dosyadan Oku";
            dosyadanOkuToolStripMenuItem.Click += dosyadanOkuToolStripMenuItem_Click;
            // 
            // dosyayaKaydetToolStripMenuItem1
            // 
            dosyayaKaydetToolStripMenuItem1.Name = "dosyayaKaydetToolStripMenuItem1";
            dosyayaKaydetToolStripMenuItem1.Size = new Size(191, 22);
            dosyayaKaydetToolStripMenuItem1.Text = "Dosyaya Kaydet";
            dosyayaKaydetToolStripMenuItem1.Click += dosyayaKaydetToolStripMenuItem_Click_1;
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
            FormClosing += Form1_FormClosing;
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
        private Button btnAraMain;
        private TextBox txtAraMain;
        private ToolStripMenuItem emanetİşlemleriTsm;
        private ToolStripMenuItem ÖdünçAlTsm;
        private ToolStripMenuItem dosyadanOkuToolStripMenuItem;
        private ToolStripMenuItem üyeOperasyonlarıToolStripMenuItem;
        private ToolStripMenuItem üyeleriDosyayaKaydetToolStripMenuItem;
        private ToolStripMenuItem üyeleriDosyadanOkuToolStripMenuItem;
        private ToolStripMenuItem kitaplarıDosyayaKaydetToolStripMenuItem;
        private ToolStripMenuItem kitaplarıDosyadanOkuToolStripMenuItem;
        public DataGridView dgvEmanetler;
        private ToolStripMenuItem dosyayaKaydetToolStripMenuItem1;
    }
}
