using OtoGaleriApp.Interfaces;
using OtoGaleriApp.Presenter;
using System;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    public partial class KisiGuncelleForm : Form, IKisiGuncelleView
    {
        private readonly KisiGuncellePresenter _presenter;
        private bool _loading = false;

        public KisiGuncelleForm()
        {
            InitializeComponent();
            _presenter = new KisiGuncellePresenter(this);
            cmbKisiler.SelectionChangeCommitted += cmbKisiler_SelectionChangeCommitted;
        }

        public int SecilenKisiId
        {
            get
            {
                if (cmbKisiler.SelectedValue == null) return 0;
                if (cmbKisiler.SelectedValue is int) return (int)cmbKisiler.SelectedValue;
                if (int.TryParse(cmbKisiler.SelectedValue.ToString(), out int id)) return id;
                return 0;
            }
        }

        


        public string Ad => txtAd.Text;
        public string Soyad => txtSoyad.Text;
        public string TC => txtTC.Text;
        public string Telefon => txtTelefon.Text;

        public void ShowMessage(string message) => MessageBox.Show(message);
        public void CloseForm() => this.Close();

        public void SetKisiler(object kisiler)
        {
            _loading = true;
            cmbKisiler.DataSource = null;
            cmbKisiler.DisplayMember = "Id"; 
            cmbKisiler.ValueMember = "Id";
            cmbKisiler.DataSource = kisiler;
            _loading = false;
        }




        public void SetFormFields(string ad, string soyad, string tc, string telefon)
        {
            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            txtTC.Text = tc;
            txtTelefon.Text = telefon;
        }

        private void KisiGuncelleForm_Load(object sender, EventArgs e)
        {
            _presenter.Yukle();
            if (SecilenKisiId != 0)
                _presenter.KisiSecildi();
        }


        private void cmbKisiler_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_loading) return;
            if (SecilenKisiId != 0)
                _presenter.KisiSecildi();
        }



        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _presenter.Guncelle();
        }
    }
}
