using System;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    public partial class KisiListeForm : Form, IKisiListeView
    {
        private readonly KisiListePresenter _presenter;

        public KisiListeForm()
        {
            InitializeComponent();
            _presenter = new KisiListePresenter(this);
        }

        private void KisiListeForm_Load(object sender, EventArgs e)
        {
            _presenter.KisileriYukle();
        }

        // View implementasyonu
        public void SetKisiler(object kisiler)
        {
            dataGridViewKisiler.DataSource = kisiler;
        }
    }
}
