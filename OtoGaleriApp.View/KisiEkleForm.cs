using OtoGaleriApp.Interfaces;
using OtoGaleriApp.Presenters;
using System;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    public partial class KisiEkleForm : Form, IKisiEkleView
    {
        private readonly KisiEklePresenter _presenter;

        public KisiEkleForm()
        {
            InitializeComponent();
            _presenter = new KisiEklePresenter(this);
        }

        
        public string Ad => txtAd.Text.Trim();
        public string Soyad => txtSoyad.Text.Trim();
        public string TC => txtTC.Text.Trim();
        public string Telefon => txtTelefon.Text.Trim();

        public void ShowMessage(string message) => MessageBox.Show(message);
        public void CloseForm() => this.Close();

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            _presenter.Kaydet();
        }

        private void KisiEkleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
