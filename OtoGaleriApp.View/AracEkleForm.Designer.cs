namespace OtoGaleriApp.View
{
    partial class AracEkleForm
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
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYil = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.chkSatildi = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblMarka
            // 
            this.lblMarka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.Location = new System.Drawing.Point(322, 101);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(92, 36);
            this.lblMarka.TabIndex = 0;
            this.lblMarka.Text = "Marka:";
            this.lblMarka.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblModel
            // 
            this.lblModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.Location = new System.Drawing.Point(322, 166);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(65, 20);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model:";
            // 
            // lblYil
            // 
            this.lblYil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYil.Location = new System.Drawing.Point(349, 231);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(57, 32);
            this.lblYil.TabIndex = 2;
            this.lblYil.Text = "Yıl:";
            // 
            // lblPlaka
            // 
            this.lblPlaka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlaka.Location = new System.Drawing.Point(322, 293);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(96, 31);
            this.lblPlaka.TabIndex = 3;
            this.lblPlaka.Text = "Plaka:";
            // 
            // txtMarka
            // 
            this.txtMarka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarka.Location = new System.Drawing.Point(420, 98);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(221, 27);
            this.txtMarka.TabIndex = 4;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlaka.Location = new System.Drawing.Point(420, 290);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(221, 27);
            this.txtPlaka.TabIndex = 5;
            // 
            // txtYil
            // 
            this.txtYil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYil.Location = new System.Drawing.Point(420, 228);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(221, 27);
            this.txtYil.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModel.Location = new System.Drawing.Point(420, 163);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(221, 27);
            this.txtModel.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(465, 399);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(142, 37);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Araç Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // lblDurum
            // 
            this.lblDurum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(318, 359);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(88, 36);
            this.lblDurum.TabIndex = 9;
            this.lblDurum.Text = "Durum:";
            // 
            // chkSatildi
            // 
            this.chkSatildi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkSatildi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSatildi.Location = new System.Drawing.Point(420, 348);
            this.chkSatildi.Name = "chkSatildi";
            this.chkSatildi.Size = new System.Drawing.Size(169, 45);
            this.chkSatildi.TabIndex = 10;
            this.chkSatildi.Text = "Satışta mı?";
            this.chkSatildi.UseVisualStyleBackColor = true;
            // 
            // AracEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.chkSatildi);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.lblYil);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Name = "AracEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracEkleForm";
            this.Load += new System.EventHandler(this.AracEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.CheckBox chkSatildi;
    }
}