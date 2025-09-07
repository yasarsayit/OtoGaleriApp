using OtoGaleriApp.Interfaces;
using OtoGaleriApp.Model;
using OtoGaleriApp.Presenter;
using System;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    public partial class SatisGuncelleForm : Form, ISatisGuncelleView
    {
        private readonly SatisGuncellePresenter _presenter;

        public SatisGuncelleForm()
        {
            InitializeComponent();
            _presenter = new SatisGuncellePresenter(this);
        }

        public int SecilenSatisId => cmbSatislar.SelectedValue != null ? Convert.ToInt32(cmbSatislar.SelectedValue) : 0;
        public int SecilenAracId => cmbArac.SelectedValue != null ? Convert.ToInt32(cmbArac.SelectedValue) : 0;
        public int SecilenAliciId => cmbAlici.SelectedValue != null ? Convert.ToInt32(cmbAlici.SelectedValue) : 0;
        public int SecilenSaticiId => cmbSatici.SelectedValue != null ? Convert.ToInt32(cmbSatici.SelectedValue) : 0;
        public decimal Fiyat => decimal.TryParse(txtFiyat.Text, out var f) ? f : 0;
        public DateTime Tarih => dtpTarih.Value;

        public void ShowMessage(string message) => MessageBox.Show(message);
        public void CloseForm() => this.Close();

        public void SetAraclar(object dataSource)
        {
            cmbArac.DataSource = dataSource;
            cmbArac.DisplayMember = "Gosterim";
            cmbArac.ValueMember = "Id";
        }

        public void SetKisiler(object dataSource)
        {
            cmbAlici.DataSource = dataSource;
            cmbAlici.DisplayMember = "AdSoyad";
            cmbAlici.ValueMember = "Id";
        }

        public void SetKullanicilar(object dataSource)
        {
            cmbSatici.DataSource = dataSource;
            cmbSatici.DisplayMember = "KullaniciAdi";
            cmbSatici.ValueMember = "Id";
        }

        public void SetSatislar(object dataSource)
        {
            cmbSatislar.DataSource = dataSource;
            cmbSatislar.DisplayMember = "Aciklama"; 
            cmbSatislar.ValueMember = "Id";
        }

        public void SetSelectedSatis(object satis)
        {
            if (satis is Satis s)
            {
                cmbArac.SelectedValue = s.AracId;
                cmbAlici.SelectedValue = s.AliciId;
                cmbSatici.SelectedValue = s.SaticiId;
                txtFiyat.Text = s.SatisFiyati.ToString();
                dtpTarih.Value = s.Tarih;
            }
        }

        private void SatisGuncelleForm_Load(object sender, EventArgs e)
        {
            _presenter.LoadData();

            
            cmbSatislar.SelectedIndexChanged -= cmbSatislar_SelectedIndexChanged;
            if (cmbSatislar.Items.Count > 0)
            {
                cmbSatislar.SelectedIndex = 0;
                _presenter.SatisSecildi();
            }
            cmbSatislar.SelectedIndexChanged += cmbSatislar_SelectedIndexChanged;
        }

        private void cmbSatislar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSatislar.SelectedValue == null) return;

            int id;
            if (int.TryParse(cmbSatislar.SelectedValue.ToString(), out id) && id > 0)
            {
                _presenter.SatisSecildi();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _presenter.SatisGuncelle();
        }
    }
}
