using OtoGaleriApp.Interfaces;
using OtoGaleriApp.Presenter;
using System;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    public partial class AracEkleForm : Form, IAracEkleView
    {
        private readonly AracEklePresenter _presenter;

        public AracEkleForm()
        {
            InitializeComponent();
            _presenter = new AracEklePresenter(this);
        }

        public string Marka => txtMarka.Text;
        public string Model => txtModel.Text;
        public string Plaka => txtPlaka.Text;
        public string Yil => txtYil.Text;
        public bool Durum => chkSatildi.Checked;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void CloseForm()
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _presenter.AracEkle();
        }

        private void AracEkleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
