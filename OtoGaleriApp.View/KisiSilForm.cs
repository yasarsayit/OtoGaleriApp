using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OtoGaleriApp.Interfaces;
using OtoGaleriApp.Presenter;

namespace OtoGaleriApp.View
{
    public partial class KisiSilForm : Form, IKisiSilView
    {
        private readonly KisiSilPresenter _presenter;

        public KisiSilForm()
        {
            InitializeComponent();
            _presenter = new KisiSilPresenter(this);
        }

        private void KisiSilForm_Load(object sender, EventArgs e)
        {
            _presenter.Yukle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (cmbKisiler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek kişiyi seçin.");
                return;
            }

            _presenter.KisiSil();
            MessageBox.Show("Kişi başarıyla silindi.");
            this.Close();
        }

        
        public void SetKisiler(List<object> kisiler)
        {
            cmbKisiler.DataSource = kisiler;
            cmbKisiler.DisplayMember = "Gosterim";
            cmbKisiler.ValueMember = "Id";
        }

        public int SecilenKisiId => (int)cmbKisiler.SelectedValue;
    }
}
