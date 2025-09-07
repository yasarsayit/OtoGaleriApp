namespace OtoGaleriApp.View
{
    partial class KisiSilForm
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
            this.cmbKisiler = new System.Windows.Forms.ComboBox();
            this.btnKisiSil = new System.Windows.Forms.Button();
            this.lblSilinecekKisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbKisiler
            // 
            this.cmbKisiler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbKisiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKisiler.FormattingEnabled = true;
            this.cmbKisiler.Location = new System.Drawing.Point(290, 158);
            this.cmbKisiler.Name = "cmbKisiler";
            this.cmbKisiler.Size = new System.Drawing.Size(315, 28);
            this.cmbKisiler.TabIndex = 0;
            // 
            // btnKisiSil
            // 
            this.btnKisiSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKisiSil.BackColor = System.Drawing.SystemColors.Info;
            this.btnKisiSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisiSil.Location = new System.Drawing.Point(390, 202);
            this.btnKisiSil.Name = "btnKisiSil";
            this.btnKisiSil.Size = new System.Drawing.Size(109, 41);
            this.btnKisiSil.TabIndex = 1;
            this.btnKisiSil.Text = "Kişi Sil";
            this.btnKisiSil.UseVisualStyleBackColor = false;
            this.btnKisiSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblSilinecekKisi
            // 
            this.lblSilinecekKisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSilinecekKisi.AutoSize = true;
            this.lblSilinecekKisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSilinecekKisi.Location = new System.Drawing.Point(145, 166);
            this.lblSilinecekKisi.Name = "lblSilinecekKisi";
            this.lblSilinecekKisi.Size = new System.Drawing.Size(129, 20);
            this.lblSilinecekKisi.TabIndex = 2;
            this.lblSilinecekKisi.Text = "Silinecek Kişi:";
            // 
            // KisiSilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSilinecekKisi);
            this.Controls.Add(this.btnKisiSil);
            this.Controls.Add(this.cmbKisiler);
            this.Name = "KisiSilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KisiSilForm";
            this.Load += new System.EventHandler(this.KisiSilForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKisiler;
        private System.Windows.Forms.Button btnKisiSil;
        private System.Windows.Forms.Label lblSilinecekKisi;
    }
}