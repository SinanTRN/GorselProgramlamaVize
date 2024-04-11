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
            btnSureUzat = new Button();
            btnIade = new Button();
            label3 = new Label();
            txtEmanetId = new TextBox();
            SuspendLayout();
            // 
            // btnSureUzat
            // 
            btnSureUzat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSureUzat.BackColor = Color.FromArgb(255, 128, 0);
            btnSureUzat.ForeColor = Color.White;
            btnSureUzat.Location = new Point(211, 105);
            btnSureUzat.Name = "btnSureUzat";
            btnSureUzat.Size = new Size(129, 23);
            btnSureUzat.TabIndex = 4;
            btnSureUzat.Text = "Süre Uzat";
            btnSureUzat.UseVisualStyleBackColor = false;
            btnSureUzat.Click += btnSureUzat_Click;
            // 
            // btnIade
            // 
            btnIade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnIade.BackColor = Color.FromArgb(192, 0, 192);
            btnIade.ForeColor = Color.White;
            btnIade.Location = new Point(211, 76);
            btnIade.Name = "btnIade";
            btnIade.Size = new Size(129, 23);
            btnIade.TabIndex = 3;
            btnIade.Text = "İade Et";
            btnIade.UseVisualStyleBackColor = false;
            btnIade.Click += btnIade_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(66, 61);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 0;
            label3.Text = "Emanet ID:";
            // 
            // txtEmanetId
            // 
            txtEmanetId.Location = new Point(66, 92);
            txtEmanetId.Name = "txtEmanetId";
            txtEmanetId.Size = new Size(122, 23);
            txtEmanetId.TabIndex = 5;
            // 
            // Emanet_Islemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 196);
            Controls.Add(txtEmanetId);
            Controls.Add(btnIade);
            Controls.Add(btnSureUzat);
            Controls.Add(label3);
            Name = "Emanet_Islemleri";
            Text = "Emanet_Islemleri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSureUzat;
        private Button btnIade;
        private Label label3;
        private TextBox txtEmanetId;
    }
}