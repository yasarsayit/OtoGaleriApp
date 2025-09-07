using OtoGaleriApp.Interfaces;
using OtoGaleriApp.Presenter;
using OtoGaleriApp.DataAccess;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    public partial class SatisYapForm : Form, ISatisYapView
    {
        private readonly SatisYapPresenter _presenter;

        public SatisYapForm()
        {
            InitializeComponent();
            _presenter = new SatisYapPresenter(this);
        }

        
        public int SecilenAracId => cmbAraclar.SelectedValue != null ? Convert.ToInt32(cmbAraclar.SelectedValue) : 0;
        public int SecilenAliciId => cmbAlici.SelectedValue != null ? Convert.ToInt32(cmbAlici.SelectedValue) : 0;
        public int SecilenSaticiId => cmbSatici.SelectedValue != null ? Convert.ToInt32(cmbSatici.SelectedValue) : 0;
        public decimal Fiyat => decimal.TryParse(txtFiyat.Text, out var f) ? f : 0;
        public DateTime Tarih => dtpTarih.Value;

        public void ShowMessage(string message) => MessageBox.Show(message);
        public void CloseForm() => this.Close();

        private void SatisYapForm_Load(object sender, EventArgs e)
        {
            using (var context = new GaleriContext())
            {
                cmbAraclar.DataSource = context.Araclar
                    .Where(a => a.Durum)
                    .Select(a => new
                    {
                        a.Id,
                        Gosterim = a.Plaka + " - " + a.Model
                    })
                    .ToList();
                cmbAraclar.DisplayMember = "Gosterim";  
                cmbAraclar.ValueMember = "Id";

                cmbAlici.DataSource = context.Kisiler
                    .Select(k => new { k.Id, AdSoyad = k.Ad + " " + k.Soyad })
                    .ToList();
                cmbAlici.DisplayMember = "AdSoyad";
                cmbAlici.ValueMember = "Id";

                cmbSatici.DataSource = context.Kullanicilar
                    .Select(u => new { u.Id, u.KullaniciAdi })
                    .ToList();
                cmbSatici.DisplayMember = "KullaniciAdi";
                cmbSatici.ValueMember = "Id";

                dtpTarih.Value = DateTime.Now;
            }
        }


        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            _presenter.SatisYap();
        }
    }
}
