using OtoGaleriApp.Interfaces;
using OtoGaleriApp.Presenter;
using System;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    public partial class SatislarForm : Form, ISatisListeView
    {
        private readonly SatisListePresenter _presenter;

        public SatislarForm()
        {
            InitializeComponent();
            _presenter = new SatisListePresenter(this);
        }

        public void SetSatislar(object satislar)
        {
            dgvSatislar.DataSource = satislar;
        }

        private void SatislarForm_Load(object sender, EventArgs e)
        {
            _presenter.LoadSatislar();
        }
    }
}
