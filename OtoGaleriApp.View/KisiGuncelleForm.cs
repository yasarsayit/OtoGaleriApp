using OtoGaleriApp.DataAccess;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    public partial class KisiGuncelleForm : Form
    {
        public KisiGuncelleForm()
        {
            InitializeComponent();
        }

        // ------ Yardımcılar ------
        private bool IsAllDigits(string s) =>
            !string.IsNullOrWhiteSpace(s) && s.All(char.IsDigit);

        private bool IsValidTckn(string tckn) =>
            IsAllDigits(tckn) && tckn.Length == 11;

        private bool IsValidPhone10NoLeadingZero(string phone) =>
            IsAllDigits(phone) && phone.Length == 10 && phone[0] != '0';

        private void DigitsOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void KisiGuncelleForm_Load(object sender, EventArgs e)
        {
            txtTC.KeyPress += DigitsOnly_KeyPress;
            txtTelefon.KeyPress += DigitsOnly_KeyPress;

            using (var context = new GaleriContext())
            {
                var kisiler = context.Kisiler
                    .Select(k => new { k.Id, AdSoyad = k.Ad + " " + k.Soyad })
                    .ToList();

                cmbKisiler.DataSource = kisiler;
                cmbKisiler.DisplayMember = "AdSoyad";
                cmbKisiler.ValueMember = "Id";
            }
        }

        private void cmbKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKisiler.SelectedValue != null &&
                int.TryParse(cmbKisiler.SelectedValue.ToString(), out int secilenId))
            {
                using (var context = new GaleriContext())
                {
                    var kisi = context.Kisiler.Find(secilenId);
                    if (kisi != null)
                    {
                        txtAd.Text = kisi.Ad;
                        txtSoyad.Text = kisi.Soyad;
                        txtTC.Text = kisi.TC.ToString();
                        txtTelefon.Text = kisi.Telefon;
                    }
                }
            }
        }

        private void btnKisiGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbKisiler.SelectedValue == null ||
                !int.TryParse(cmbKisiler.SelectedValue.ToString(), out int secilenId))
            {
                MessageBox.Show("Lütfen güncellenecek kişiyi seçiniz.");
                return;
            }

            var tcknText = txtTC.Text?.Trim();
            var telText = txtTelefon.Text?.Trim();

            // --- Doğrulamalar ---
            if (!IsValidTckn(tcknText))
            {
                MessageBox.Show("T.C. Kimlik Numarası 11 haneli olmalı ve sadece rakamlardan oluşmalıdır.",
                    "Geçersiz TCKN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTC.Focus(); txtTC.SelectAll();
                return;
            }

            if (!IsValidPhone10NoLeadingZero(telText))
            {
                MessageBox.Show("Telefon numarasını başında 0 olmadan 10 haneli giriniz (örn: 5301234567).",
                    "Geçersiz Telefon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefon.Focus(); txtTelefon.SelectAll();
                return;
            }

            try
            {
                long tcLong = long.Parse(tcknText);

                using (var context = new GaleriContext())
                {
                    var kisi = context.Kisiler.Find(secilenId);
                    if (kisi == null)
                    {
                        MessageBox.Show("Kişi bulunamadı.");
                        return;
                    }

                    // --- TEKİLLİK KONTROLLERİ (kendisi hariç) ---
                    bool existsByTc = context.Kisiler.Any(k => k.Id != secilenId && k.TC == (int)tcLong);
                    bool existsByTel = context.Kisiler.Any(k => k.Id != secilenId && k.Telefon == telText);

                    if (existsByTc || existsByTel)
                    {
                        string msg = "Güncelleme yapılamadı:";
                        if (existsByTc) msg += "\n- Bu T.C. Kimlik Numarası başka bir kişide kayıtlı.";
                        if (existsByTel) msg += "\n- Bu telefon numarası başka bir kişide kayıtlı.";
                        MessageBox.Show(msg, "Çakışan Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // güncelle
                    kisi.Ad = txtAd.Text?.Trim();
                    kisi.Soyad = txtSoyad.Text?.Trim();
                    kisi.TC = (int)tcLong;     // model int ise
                    kisi.Telefon = telText;

                    context.SaveChanges();
                    MessageBox.Show("Kişi başarıyla güncellendi.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void lblTelefon_Click(object sender, EventArgs e) { }
    }
}
