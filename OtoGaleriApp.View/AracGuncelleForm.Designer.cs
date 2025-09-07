namespace OtoGaleriApp.View
{
    partial class AracGuncelleForm
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
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbAraclar = new System.Windows.Forms.ComboBox();
            this.chkDurum = new System.Windows.Forms.CheckBox();
            this.lblAraclar = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYil = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMarka
            // 
            this.txtMarka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarka.Location = new System.Drawing.Point(290, 127);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(286, 27);
            this.txtMarka.TabIndex = 0;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlaka.Location = new System.Drawing.Point(290, 255);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(286, 27);
            this.txtPlaka.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModel.Location = new System.Drawing.Point(290, 166);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(286, 27);
            this.txtModel.TabIndex = 2;
            // 
            // txtYil
            // 
            this.txtYil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYil.Location = new System.Drawing.Point(290, 211);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(286, 27);
            this.txtYil.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.Info;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(373, 329);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(117, 41);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbAraclar
            // 
            this.cmbAraclar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAraclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAraclar.FormattingEnabled = true;
            this.cmbAraclar.Location = new System.Drawing.Point(290, 82);
            this.cmbAraclar.Name = "cmbAraclar";
            this.cmbAraclar.Size = new System.Drawing.Size(286, 28);
            this.cmbAraclar.TabIndex = 6;
            this.cmbAraclar.SelectedIndexChanged += new System.EventHandler(this.cmbAraclar_SelectedIndexChanged);
            // 
            // chkDurum
            // 
            this.chkDurum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkDurum.AutoSize = true;
            this.chkDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkDurum.Location = new System.Drawing.Point(290, 299);
            this.chkDurum.Name = "chkDurum";
            this.chkDurum.Size = new System.Drawing.Size(126, 24);
            this.chkDurum.TabIndex = 7;
            this.chkDurum.Text = "Satışta mı?";
            this.chkDurum.UseVisualStyleBackColor = true;
            // 
            // lblAraclar
            // 
            this.lblAraclar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAraclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAraclar.Location = new System.Drawing.Point(175, 72);
            this.lblAraclar.Name = "lblAraclar";
            this.lblAraclar.Size = new System.Drawing.Size(109, 42);
            this.lblAraclar.TabIndex = 8;
            this.lblAraclar.Text = "Araç:";
            this.lblAraclar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMarka
            // 
            this.lblMarka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.Location = new System.Drawing.Point(186, 113);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(82, 50);
            this.lblMarka.TabIndex = 9;
            this.lblMarka.Text = "Marka:";
            this.lblMarka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModel
            // 
            this.lblModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.Location = new System.Drawing.Point(186, 158);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(82, 39);
            this.lblModel.TabIndex = 10;
            this.lblModel.Text = "Model:";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYil
            // 
            this.lblYil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYil.Location = new System.Drawing.Point(209, 208);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(62, 30);
            this.lblYil.TabIndex = 11;
            this.lblYil.Text = "Yıl:";
            this.lblYil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlaka
            // 
            this.lblPlaka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlaka.Location = new System.Drawing.Point(189, 240);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(82, 52);
            this.lblPlaka.TabIndex = 12;
            this.lblPlaka.Text = "Plaka:";
            this.lblPlaka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDurum
            // 
            this.lblDurum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(189, 283);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(82, 50);
            this.lblDurum.TabIndex = 13;
            this.lblDurum.Text = "Durum:";
            this.lblDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AracGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.lblYil);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblAraclar);
            this.Controls.Add(this.chkDurum);
            this.Controls.Add(this.cmbAraclar);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtMarka);
            this.Name = "AracGuncelleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracGuncelleForm";
            this.Load += new System.EventHandler(this.AracGuncelleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cmbAraclar;
        private System.Windows.Forms.CheckBox chkDurum;
        private System.Windows.Forms.Label lblAraclar;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblDurum;
    }
}