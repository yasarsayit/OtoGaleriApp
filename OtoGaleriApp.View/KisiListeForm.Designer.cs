namespace OtoGaleriApp.View
{
    partial class KisiListeForm
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
            this.dataGridViewKisiler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisiler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKisiler
            // 
            this.dataGridViewKisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKisiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKisiler.EnableHeadersVisualStyles = false;
            this.dataGridViewKisiler.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewKisiler.Name = "dataGridViewKisiler";
            this.dataGridViewKisiler.RowHeadersWidth = 51;
            this.dataGridViewKisiler.RowTemplate.Height = 24;
            this.dataGridViewKisiler.Size = new System.Drawing.Size(766, 450);
            this.dataGridViewKisiler.TabIndex = 0;
            // 
            // KisiListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.dataGridViewKisiler);
            this.Name = "KisiListeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KisiListeForm";
            this.Load += new System.EventHandler(this.KisiListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisiler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKisiler;
    }
}