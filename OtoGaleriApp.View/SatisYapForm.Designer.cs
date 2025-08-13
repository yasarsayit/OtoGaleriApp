namespace OtoGaleriApp.View
{
    partial class SatisYapForm
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
            this.cmbAraclar = new System.Windows.Forms.ComboBox();
            this.cmbAlici = new System.Windows.Forms.ComboBox();
            this.cmbSatici = new System.Windows.Forms.ComboBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.lblAraclar = new System.Windows.Forms.Label();
            this.lblAlici = new System.Windows.Forms.Label();
            this.lblSatici = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAraclar
            // 
            this.cmbAraclar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAraclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAraclar.FormattingEnabled = true;
            this.cmbAraclar.Location = new System.Drawing.Point(293, 92);
            this.cmbAraclar.Name = "cmbAraclar";
            this.cmbAraclar.Size = new System.Drawing.Size(344, 28);
            this.cmbAraclar.TabIndex = 0;
            // 
            // cmbAlici
            // 
            this.cmbAlici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAlici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAlici.FormattingEnabled = true;
            this.cmbAlici.Location = new System.Drawing.Point(293, 139);
            this.cmbAlici.Name = "cmbAlici";
            this.cmbAlici.Size = new System.Drawing.Size(344, 28);
            this.cmbAlici.TabIndex = 1;
            // 
            // cmbSatici
            // 
            this.cmbSatici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSatici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSatici.FormattingEnabled = true;
            this.cmbSatici.Location = new System.Drawing.Point(293, 184);
            this.cmbSatici.Name = "cmbSatici";
            this.cmbSatici.Size = new System.Drawing.Size(344, 28);
            this.cmbSatici.TabIndex = 2;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(293, 229);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(344, 27);
            this.txtFiyat.TabIndex = 3;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(293, 272);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(344, 27);
            this.dtpTarih.TabIndex = 4;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSatisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisYap.Location = new System.Drawing.Point(390, 317);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(140, 35);
            this.btnSatisYap.TabIndex = 5;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // lblAraclar
            // 
            this.lblAraclar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAraclar.AutoSize = true;
            this.lblAraclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAraclar.Location = new System.Drawing.Point(133, 95);
            this.lblAraclar.Name = "lblAraclar";
            this.lblAraclar.Size = new System.Drawing.Size(137, 20);
            this.lblAraclar.TabIndex = 6;
            this.lblAraclar.Text = "Satılacak Araç:";
            // 
            // lblAlici
            // 
            this.lblAlici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlici.AutoSize = true;
            this.lblAlici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlici.Location = new System.Drawing.Point(218, 142);
            this.lblAlici.Name = "lblAlici";
            this.lblAlici.Size = new System.Drawing.Size(52, 20);
            this.lblAlici.TabIndex = 7;
            this.lblAlici.Text = "Alıcı:";
            // 
            // lblSatici
            // 
            this.lblSatici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSatici.AutoSize = true;
            this.lblSatici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatici.Location = new System.Drawing.Point(207, 187);
            this.lblSatici.Name = "lblSatici";
            this.lblSatici.Size = new System.Drawing.Size(63, 20);
            this.lblSatici.TabIndex = 8;
            this.lblSatici.Text = "Satıcı:";
            this.lblSatici.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFiyat
            // 
            this.lblFiyat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(214, 232);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(56, 20);
            this.lblFiyat.TabIndex = 9;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // lblTarih
            // 
            this.lblTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(212, 277);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(58, 20);
            this.lblTarih.TabIndex = 10;
            this.lblTarih.Text = "Tarih:";
            // 
            // SatisYapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblSatici);
            this.Controls.Add(this.lblAlici);
            this.Controls.Add(this.lblAraclar);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.cmbSatici);
            this.Controls.Add(this.cmbAlici);
            this.Controls.Add(this.cmbAraclar);
            this.Name = "SatisYapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatisYapForm";
            this.Load += new System.EventHandler(this.SatisYapForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAraclar;
        private System.Windows.Forms.ComboBox cmbAlici;
        private System.Windows.Forms.ComboBox cmbSatici;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Label lblAraclar;
        private System.Windows.Forms.Label lblAlici;
        private System.Windows.Forms.Label lblSatici;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblTarih;
    }
}