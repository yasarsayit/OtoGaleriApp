namespace OtoGaleriApp.View
{
    partial class SatisGuncelleForm
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
            this.cmbSatislar = new System.Windows.Forms.ComboBox();
            this.cmbArac = new System.Windows.Forms.ComboBox();
            this.cmbSatici = new System.Windows.Forms.ComboBox();
            this.cmbAlici = new System.Windows.Forms.ComboBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblSatislar = new System.Windows.Forms.Label();
            this.lblAlici = new System.Windows.Forms.Label();
            this.lblSatici = new System.Windows.Forms.Label();
            this.lblAraclar = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbSatislar
            // 
            this.cmbSatislar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSatislar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSatislar.FormattingEnabled = true;
            this.cmbSatislar.Location = new System.Drawing.Point(269, 57);
            this.cmbSatislar.Name = "cmbSatislar";
            this.cmbSatislar.Size = new System.Drawing.Size(337, 28);
            this.cmbSatislar.TabIndex = 0;
            // 
            // cmbArac
            // 
            this.cmbArac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbArac.FormattingEnabled = true;
            this.cmbArac.Location = new System.Drawing.Point(269, 205);
            this.cmbArac.Name = "cmbArac";
            this.cmbArac.Size = new System.Drawing.Size(337, 28);
            this.cmbArac.TabIndex = 1;
            // 
            // cmbSatici
            // 
            this.cmbSatici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSatici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSatici.FormattingEnabled = true;
            this.cmbSatici.Location = new System.Drawing.Point(269, 153);
            this.cmbSatici.Name = "cmbSatici";
            this.cmbSatici.Size = new System.Drawing.Size(337, 28);
            this.cmbSatici.TabIndex = 2;
            // 
            // cmbAlici
            // 
            this.cmbAlici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAlici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAlici.FormattingEnabled = true;
            this.cmbAlici.Location = new System.Drawing.Point(269, 105);
            this.cmbAlici.Name = "cmbAlici";
            this.cmbAlici.Size = new System.Drawing.Size(337, 28);
            this.cmbAlici.TabIndex = 3;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(269, 254);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(337, 27);
            this.txtFiyat.TabIndex = 4;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(269, 309);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(337, 27);
            this.dtpTarih.TabIndex = 5;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(359, 357);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(144, 40);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // lblSatislar
            // 
            this.lblSatislar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSatislar.AutoSize = true;
            this.lblSatislar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatislar.Location = new System.Drawing.Point(157, 60);
            this.lblSatislar.Name = "lblSatislar";
            this.lblSatislar.Size = new System.Drawing.Size(80, 20);
            this.lblSatislar.TabIndex = 7;
            this.lblSatislar.Text = "Satışlar:";
            // 
            // lblAlici
            // 
            this.lblAlici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlici.AutoSize = true;
            this.lblAlici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlici.Location = new System.Drawing.Point(163, 105);
            this.lblAlici.Name = "lblAlici";
            this.lblAlici.Size = new System.Drawing.Size(74, 20);
            this.lblAlici.TabIndex = 8;
            this.lblAlici.Text = "Alıcılar:";
            // 
            // lblSatici
            // 
            this.lblSatici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSatici.AutoSize = true;
            this.lblSatici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatici.Location = new System.Drawing.Point(152, 156);
            this.lblSatici.Name = "lblSatici";
            this.lblSatici.Size = new System.Drawing.Size(85, 20);
            this.lblSatici.TabIndex = 9;
            this.lblSatici.Text = "Satıcılar:";
            // 
            // lblAraclar
            // 
            this.lblAraclar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAraclar.AutoSize = true;
            this.lblAraclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAraclar.Location = new System.Drawing.Point(157, 208);
            this.lblAraclar.Name = "lblAraclar";
            this.lblAraclar.Size = new System.Drawing.Size(76, 20);
            this.lblAraclar.TabIndex = 10;
            this.lblAraclar.Text = "Araçlar:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(177, 257);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(56, 20);
            this.lblFiyat.TabIndex = 11;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // lblTarih
            // 
            this.lblTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(175, 314);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(58, 20);
            this.lblTarih.TabIndex = 12;
            this.lblTarih.Text = "Tarih:";
            // 
            // SatisGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblAraclar);
            this.Controls.Add(this.lblSatici);
            this.Controls.Add(this.lblAlici);
            this.Controls.Add(this.lblSatislar);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.cmbAlici);
            this.Controls.Add(this.cmbSatici);
            this.Controls.Add(this.cmbArac);
            this.Controls.Add(this.cmbSatislar);
            this.Name = "SatisGuncelleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatisGuncelleForm";
            this.Load += new System.EventHandler(this.SatisGuncelleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSatislar;
        private System.Windows.Forms.ComboBox cmbArac;
        private System.Windows.Forms.ComboBox cmbSatici;
        private System.Windows.Forms.ComboBox cmbAlici;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblSatislar;
        private System.Windows.Forms.Label lblAlici;
        private System.Windows.Forms.Label lblSatici;
        private System.Windows.Forms.Label lblAraclar;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblTarih;
    }
}