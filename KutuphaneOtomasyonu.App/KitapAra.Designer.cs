namespace KutuphaneOtomasyonu.App
{
    partial class KitapAra
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
            this.lblKitapAd = new System.Windows.Forms.Label();
            this.txtKtpAd = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblKitapAd
            // 
            this.lblKitapAd.AutoSize = true;
            this.lblKitapAd.Location = new System.Drawing.Point(116, 69);
            this.lblKitapAd.Name = "lblKitapAd";
            this.lblKitapAd.Size = new System.Drawing.Size(61, 17);
            this.lblKitapAd.TabIndex = 0;
            this.lblKitapAd.Text = "Kitap Ad";
            // 
            // txtKtpAd
            // 
            this.txtKtpAd.Location = new System.Drawing.Point(213, 66);
            this.txtKtpAd.Name = "txtKtpAd";
            this.txtKtpAd.Size = new System.Drawing.Size(121, 22);
            this.txtKtpAd.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(183, 236);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(213, 172);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(121, 24);
            this.cmbTur.TabIndex = 3;
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Location = new System.Drawing.Point(116, 126);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(45, 17);
            this.lblYazar.TabIndex = 4;
            this.lblYazar.Text = "Yazar";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(116, 175);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(30, 17);
            this.lblTur.TabIndex = 5;
            this.lblTur.Text = "Tür";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(213, 121);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(121, 22);
            this.txtYazar.TabIndex = 6;
            // 
            // KitapAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtKtpAd);
            this.Controls.Add(this.lblKitapAd);
            this.Name = "KitapAra";
            this.Text = "KitapAra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKitapAd;
        private System.Windows.Forms.TextBox txtKtpAd;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.TextBox txtYazar;
    }
}