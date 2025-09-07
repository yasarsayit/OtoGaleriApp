using OtoGaleriApp.Interfaces;
using OtoGaleriApp.Presenter;
using System;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    public partial class KullaniciEkleForm : Form, IKullaniciEkleView
    {
        private readonly KullaniciEklePresenter _presenter;

        public KullaniciEkleForm()
        {
            InitializeComponent();
            _presenter = new KullaniciEklePresenter(this);
        }

        public string KullaniciAdi => txtKullaniciAdi.Text.Trim();
        public string Sifre => txtSifre.Text;
        public string SifreTekrar => txtSifreTekrar.Text;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void CloseForm()
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _presenter.Kaydet();
        }
    }
}
