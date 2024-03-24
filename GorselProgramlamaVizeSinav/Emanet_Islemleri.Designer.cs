namespace GorselProgramlamaVizeSinav
{
    partial class Emanet_Islemleri
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
            txtEmanetYazar = new TextBox();
            label2 = new Label();
            txtEmanetBaslik = new TextBox();
            label1 = new Label();
            btnSureUzat = new Button();
            btnOduncAl = new Button();
            btnIade = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtEmanetYazar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEmanetBaslik);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(61, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "📖Kitap";
            // 
            // txtEmanetYazar
            // 
            txtEmanetYazar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmanetYazar.Location = new Point(69, 59);
            txtEmanetYazar.Name = "txtEmanetYazar";
            txtEmanetYazar.Size = new Size(300, 29);
            txtEmanetYazar.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(20, 65);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 0;
            label2.Text = "Yazar";
            // 
            // txtEmanetBaslik
            // 
            txtEmanetBaslik.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmanetBaslik.Location = new Point(69, 24);
            txtEmanetBaslik.Name = "txtEmanetBaslik";
            txtEmanetBaslik.Size = new Size(300, 29);
            txtEmanetBaslik.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 0;
            label1.Text = "Başlık";
            // 
            // btnSureUzat
            // 
            btnSureUzat.BackColor = Color.FromArgb(255, 128, 0);
            btnSureUzat.ForeColor = Color.White;
            btnSureUzat.Location = new Point(196, 176);
            btnSureUzat.Name = "btnSureUzat";
            btnSureUzat.Size = new Size(146, 23);
            btnSureUzat.TabIndex = 4;
            btnSureUzat.Text = "Süre Uzat";
            btnSureUzat.UseVisualStyleBackColor = false;
            btnSureUzat.Click += btnSureUzat_Click;
            // 
            // btnOduncAl
            // 
            btnOduncAl.BackColor = Color.Blue;
            btnOduncAl.ForeColor = Color.White;
            btnOduncAl.Location = new Point(348, 176);
            btnOduncAl.Name = "btnOduncAl";
            btnOduncAl.Size = new Size(137, 23);
            btnOduncAl.TabIndex = 5;
            btnOduncAl.Text = "Ödünç Al";
            btnOduncAl.UseVisualStyleBackColor = false;
            btnOduncAl.Click += btnOduncAl_Click;
            // 
            // btnIade
            // 
            btnIade.BackColor = Color.FromArgb(192, 0, 192);
            btnIade.ForeColor = Color.White;
            btnIade.Location = new Point(61, 176);
            btnIade.Name = "btnIade";
            btnIade.Size = new Size(129, 23);
            btnIade.TabIndex = 3;
            btnIade.Text = "İade Et";
            btnIade.UseVisualStyleBackColor = false;
            // 
            // Emanet_Islemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 284);
            Controls.Add(btnIade);
            Controls.Add(btnOduncAl);
            Controls.Add(btnSureUzat);
            Controls.Add(groupBox1);
            Name = "Emanet_Islemleri";
            Text = "Emanet_Islemleri";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtEmanetYazar;
        private Label label2;
        private TextBox txtEmanetBaslik;
        private Label label1;
        private Button btnSureUzat;
        private Button btnOduncAl;
        private Button btnIade;
    }
}