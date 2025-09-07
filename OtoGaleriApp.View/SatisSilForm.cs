using OtoGaleriApp.Interfaces;
using OtoGaleriApp.Presenter;
using System;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    public partial class SatisSilForm : Form, ISatisSilView
    {
        private readonly SatisSilPresenter _presenter;

        public SatisSilForm()
        {
            InitializeComponent();
            _presenter = new SatisSilPresenter(this);
        }

        public int SecilenSatisId => cmbSatislar.SelectedValue != null ? (int)cmbSatislar.SelectedValue : 0;

        public void ShowMessage(string message) => MessageBox.Show(message);

        public void CloseForm() => this.Close();

        public void SetSatislar(object satislar)
        {
            cmbSatislar.DataSource = satislar;
            cmbSatislar.DisplayMember = "Aciklama";
            cmbSatislar.ValueMember = "Id";
        }

        private void SatisSilForm_Load(object sender, EventArgs e)
        {
            _presenter.LoadSatislar();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _presenter.SatisSil();
        }
    }
}
