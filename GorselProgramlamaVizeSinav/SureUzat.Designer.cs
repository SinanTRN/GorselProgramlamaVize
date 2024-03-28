namespace GorselProgramlamaVizeSinav
{
    partial class SureUzat
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
            label1 = new Label();
            txtSureUzatma = new TextBox();
            btnOkSure = new Button();
            btnIptalSure = new Button();
            label2 = new Label();
            dtpTeslimTarihiSure = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(54, 77);
            label1.Name = "label1";
            label1.Size = new Size(336, 25);
            label1.TabIndex = 0;
            label1.Text = "Uzatmak istediğiniz süreyi giriniz(Gün)";
            // 
            // txtSureUzatma
            // 
            txtSureUzatma.Location = new Point(54, 117);
            txtSureUzatma.Name = "txtSureUzatma";
            txtSureUzatma.Size = new Size(345, 23);
            txtSureUzatma.TabIndex = 1;
            txtSureUzatma.TextChanged += txtSureUzatma_TextChanged;
            // 
            // btnOkSure
            // 
            btnOkSure.BackColor = Color.Lime;
            btnOkSure.ForeColor = Color.White;
            btnOkSure.Location = new Point(324, 198);
            btnOkSure.Name = "btnOkSure";
            btnOkSure.Size = new Size(75, 23);
            btnOkSure.TabIndex = 2;
            btnOkSure.Text = "Tamam";
            btnOkSure.UseVisualStyleBackColor = false;
            btnOkSure.Click += btnOkSure_Click;
            // 
            // btnIptalSure
            // 
            btnIptalSure.BackColor = Color.Silver;
            btnIptalSure.ForeColor = Color.White;
            btnIptalSure.Location = new Point(243, 198);
            btnIptalSure.Name = "btnIptalSure";
            btnIptalSure.Size = new Size(75, 23);
            btnIptalSure.TabIndex = 2;
            btnIptalSure.Text = "İptal";
            btnIptalSure.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(54, 141);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 0;
            label2.Text = "Teslim Tarihi";
            // 
            // dtpTeslimTarihiSure
            // 
            dtpTeslimTarihiSure.Location = new Point(54, 169);
            dtpTeslimTarihiSure.Name = "dtpTeslimTarihiSure";
            dtpTeslimTarihiSure.Size = new Size(189, 23);
            dtpTeslimTarihiSure.TabIndex = 3;
            // 
            // SureUzat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 270);
            Controls.Add(dtpTeslimTarihiSure);
            Controls.Add(btnIptalSure);
            Controls.Add(btnOkSure);
            Controls.Add(txtSureUzatma);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SureUzat";
            Text = "SureUzat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSureUzatma;
        private Button btnOkSure;
        private Button btnIptalSure;
        private Label label2;
        public DateTimePicker dtpTeslimTarihiSure;
    }
}