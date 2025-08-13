using System;
using System.Linq;
using System.Windows.Forms;
using OtoGaleriApp.Model;
using OtoGaleriApp.DataAccess;

namespace OtoGaleriApp.View
{
    public partial class KisiEkleForm : Form
    {
        public KisiEkleForm()
        {
            InitializeComponent();
        }

        // ------ Yardımcılar ------
        private bool IsAllDigits(string s) =>
            !string.IsNullOrWhiteSpace(s) && s.All(char.IsDigit);

        private bool IsValidTckn(string tckn) =>
            IsAllDigits(tckn) && tckn.Length == 11;

        // Telefon: başında 0 YOK, toplam 10 hane
        private bool IsValidPhone10NoLeadingZero(string phone) =>
            IsAllDigits(phone) && phone.Length == 10 && phone[0] != '0';

        private void DigitsOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void KisiEkleForm_Load(object sender, EventArgs e)
        {
            // Sadece rakam girilebilsin
            txtTC.KeyPress += DigitsOnly_KeyPress;
            txtTelefon.KeyPress += DigitsOnly_KeyPress;
        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var ad = txtAd.Text?.Trim();
                var soyad = txtSoyad.Text?.Trim();
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

                long tcLong = long.Parse(tcknText);

                using (var context = new GaleriContext())
                {
                    // --- TEKİLLİK KONTROLLERİ ---
                    bool existsByTc = context.Kisiler.Any(k => k.TC == (int)tcLong);
                    bool existsByTel = context.Kisiler.Any(k => k.Telefon == telText);

                    if (existsByTc || existsByTel)
                    {
                        string msg = "Kayıt eklenemedi:";
                        if (existsByTc) msg += "\n- Bu T.C. Kimlik Numarası zaten kayıtlı.";
                        if (existsByTel) msg += "\n- Bu telefon numarası zaten kayıtlı.";
                        MessageBox.Show(msg, "Çakışan Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var yeniKisi = new Kisi
                    {
                        Ad = ad,
                        Soyad = soyad,
                        Telefon = telText,
                        TC = (int)tcLong
                    };

                    context.Kisiler.Add(yeniKisi);
                    context.SaveChanges();

                    MessageBox.Show("Kişi başarıyla eklendi.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Designer forwarding (varsa)
        private void btnKisiEkle_Click_1(object sender, EventArgs e)
        {
            btnKisiEkle_Click(sender, e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Kullanılmıyor
        }
    }
}
