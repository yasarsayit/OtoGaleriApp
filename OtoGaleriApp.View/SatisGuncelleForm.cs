using OtoGaleriApp.DataAccess;
using OtoGaleriApp.Model;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    public partial class SatisGuncelleForm : Form
    {
        public SatisGuncelleForm()
        {
            InitializeComponent();
        }

        private void SatisGuncelleForm_Load(object sender, EventArgs e)
        {
            using (var context = new GaleriContext())
            {
                // Satış listesi
                var satislar = context.Satislar
                    .Include(s => s.Alici)
                    .Include(s => s.Satici)
                    .Include(s => s.Arac)
                    .ToList();

                cmbSatislar.DataSource = satislar;
                cmbSatislar.DisplayMember = "Id";
                cmbSatislar.ValueMember = "Id";

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

                cmbArac.DataSource = context.Araclar
                    .Select(a => new { a.Id, a.Plaka })
                    .ToList();
                cmbArac.DisplayMember = "Plaka";
                cmbArac.ValueMember = "Id";
            }
        }

        private void cmbSatislar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSatislar.SelectedItem is Satis secilen)
            {
                cmbAlici.SelectedValue = secilen.AliciId;
                cmbSatici.SelectedValue = secilen.SaticiId;
                cmbArac.SelectedValue = secilen.AracId;
                txtFiyat.Text = secilen.SatisFiyati.ToString();
                dtpTarih.Value = secilen.Tarih;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbSatislar.SelectedItem == null) return;

            int satisId = (int)cmbSatislar.SelectedValue;

            using (var context = new GaleriContext())
            {
                var satis = context.Satislar.Find(satisId);
                if (satis == null)
                {
                    MessageBox.Show("Satış bulunamadı.");
                    return;
                }

                satis.AliciId = (int)cmbAlici.SelectedValue;
                satis.SaticiId = (int)cmbSatici.SelectedValue;
                satis.AracId = (int)cmbArac.SelectedValue;
                satis.SatisFiyati = decimal.Parse(txtFiyat.Text);
                satis.Tarih = dtpTarih.Value;

                context.SaveChanges();
                MessageBox.Show("Satış başarıyla güncellendi.");
                this.Close();
            }
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (cmbSatislar.SelectedItem == null) return;

            int satisId = (int)cmbSatislar.SelectedValue;

            using (var context = new GaleriContext())
            {
                var satis = context.Satislar.Find(satisId);
                if (satis == null)
                {
                    MessageBox.Show("Satış bulunamadı.");
                    return;
                }

                satis.AliciId = (int)cmbAlici.SelectedValue;
                satis.SaticiId = (int)cmbSatici.SelectedValue;
                satis.AracId = (int)cmbArac.SelectedValue;
                satis.SatisFiyati = decimal.Parse(txtFiyat.Text);
                satis.Tarih = dtpTarih.Value;

                context.SaveChanges();
                MessageBox.Show("Satış başarıyla güncellendi.");
                this.Close();
            }
        }
    }
}
