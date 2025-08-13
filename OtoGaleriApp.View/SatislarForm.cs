using OtoGaleriApp.DataAccess;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    public partial class SatislarForm : Form
    {
        public SatislarForm()
        {
            InitializeComponent();
        }

        private void SatislarForm_Load(object sender, EventArgs e)
        {
            using (var context = new GaleriContext())
            {
                var satislar = context.Satislar
                    .Select(s => new
                    {
                        ID = s.Id,
                        Plaka = s.Arac.Plaka,
                        Marka = s.Arac.Marka,
                        Model = s.Arac.Model,
                        Yil = s.Arac.Yil,
                        Alici = s.Alici.Ad + " " + s.Alici.Soyad,
                        Satici = s.Satici.KullaniciAdi,
                        Fiyat = s.SatisFiyati,
                        Tarih = s.Tarih
                    })
                    .ToList();

                dgvSatislar.DataSource = satislar;
            }
        }

        private void dgvSatislar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
