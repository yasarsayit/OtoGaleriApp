using System;
using System.Windows.Forms;
using OtoGaleriApp.Model;
using OtoGaleriApp.DataAccess;

namespace OtoGaleriApp.View
{
    public partial class AracEkleForm : Form
    {
        public AracEkleForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
        }


        private void label1_Click(object sender, EventArgs e)
        {
            // Bu alan boş kalabilir ya da etkileşim varsa eklenir.
        }

        private void AracEkleForm_Load(object sender, EventArgs e)
        {
            // Form ilk açıldığında yapılacak işlemler varsa buraya eklenir.
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            using (var context = new GaleriContext())
            {
                try
                {
                    Arac yeniArac = new Arac
                    {
                        Marka = txtMarka.Text,
                        Model = txtModel.Text,
                        Plaka = txtPlaka.Text,
                        Yil = int.Parse(txtYil.Text),
                        Durum = chkSatildi.Checked
                    };

                    context.Araclar.Add(yeniArac);
                    context.SaveChanges();

                    MessageBox.Show("Araç başarıyla eklendi!");
                    
                    this.Close(); // Formu kapat
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                if (string.IsNullOrWhiteSpace(txtMarka.Text) || string.IsNullOrWhiteSpace(txtModel.Text) || string.IsNullOrWhiteSpace(txtPlaka.Text) || string.IsNullOrWhiteSpace(txtYil.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

            }
        }
    }


}


