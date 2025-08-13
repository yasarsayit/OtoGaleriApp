namespace OtoGaleriApp.View
{
    partial class SatislarForm
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
            this.dgvSatislar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSatislar
            // 
            this.dgvSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatislar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSatislar.Location = new System.Drawing.Point(0, 0);
            this.dgvSatislar.Name = "dgvSatislar";
            this.dgvSatislar.RowHeadersWidth = 51;
            this.dgvSatislar.RowTemplate.Height = 24;
            this.dgvSatislar.Size = new System.Drawing.Size(956, 546);
            this.dgvSatislar.TabIndex = 0;
            this.dgvSatislar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSatislar_CellContentClick);
            // 
            // SatislarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 546);
            this.Controls.Add(this.dgvSatislar);
            this.Name = "SatislarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatislarForm";
            this.Load += new System.EventHandler(this.SatislarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSatislar;
    }
}