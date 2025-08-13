using OtoGaleriApp.DataAccess;
using OtoGaleriApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    public partial class SatisYapForm : Form
    {
        public SatisYapForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SatisYapForm_Load(object sender, EventArgs e)
        {
            using (var context = new GaleriContext())
            {
                // Satılabilir araçlar (Durum = Satışta)
                cmbAraclar.DataSource = context.Araclar
                    .Where(a => a.Durum == true)
                    .Select(a => new { a.Id, a.Plaka })
                    .ToList();
                cmbAraclar.DisplayMember = "Plaka";
                cmbAraclar.ValueMember = "Id";

                // Alıcılar (Kisiler)
                cmbAlici.DataSource = context.Kisiler
                    .Select(k => new { k.Id, AdSoyad = k.Ad + " " + k.Soyad })
                    .ToList();
                cmbAlici.DisplayMember = "AdSoyad";
                cmbAlici.ValueMember = "Id";

                // Satıcılar (Kullanicilar)
                cmbSatici.DataSource = context.Kullanicilar
                    .Select(u => new { u.Id, u.KullaniciAdi })
                    .ToList();
                cmbSatici.DisplayMember = "KullaniciAdi";
                cmbSatici.ValueMember = "Id";

                // Tarihi bugüne ayarla
                dtpTarih.Value = DateTime.Now;
            }
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            if (cmbAraclar.SelectedItem == null || cmbAlici.SelectedItem == null || cmbSatici.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            if (!decimal.TryParse(txtFiyat.Text, out decimal fiyat))
            {
                MessageBox.Show("Geçerli bir fiyat girin.");
                return;
            }

            using (var context = new GaleriContext())
            {
                int aracId = (int)cmbAraclar.SelectedValue;
                int aliciId = (int)cmbAlici.SelectedValue;
                int saticiId = (int)cmbSatici.SelectedValue;

                // Yeni satış kaydı
                var satis = new Satis
                {
                    AracId = aracId,
                    AliciId = aliciId,
                    SaticiId = saticiId,
                    SatisFiyati = fiyat,
                    Tarih = dtpTarih.Value
                };

                context.Satislar.Add(satis);

                // Aracın durumunu güncelle
                var arac = context.Araclar.Find(aracId);
                if (arac != null)
                {
                    arac.Durum = false ;
                }

                context.SaveChanges();
                MessageBox.Show("Satış başarıyla tamamlandı.");

                this.Close(); // formu kapat
            }
        }

    }
}
