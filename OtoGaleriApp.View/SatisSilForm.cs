using OtoGaleriApp.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity; // Include için gerekli namespace

namespace OtoGaleriApp.View
{
    public partial class SatisSilForm : Form
    {
        public SatisSilForm()
        {
            InitializeComponent();
        }

        private void SatisSilForm_Load(object sender, EventArgs e)
        {
            using (var context = new GaleriContext())
            {
                var satislar = context.Satislar
                    .Include("Arac")
                    .Include("Alici")
                    .ToList() // RAM'e al
                    .Select(s => new
                    {
                        s.Id,
                        Aciklama = s.Arac.Plaka + " - " + s.Alici.Ad + " " + s.Alici.Soyad + " - " + s.Tarih.ToShortDateString()
                    })
                    .ToList();

                cmbSatislar.DataSource = satislar;
                cmbSatislar.DisplayMember = "Aciklama";
                cmbSatislar.ValueMember = "Id";
            }
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (cmbSatislar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek satışı seçin.");
                return;
            }

            int secilenSatisId = (int)cmbSatislar.SelectedValue;

            using (var context = new GaleriContext())
            {
                var satis = context.Satislar.Find(secilenSatisId);

                if (satis != null)
                {
                    // 1. Satışı sil
                    context.Satislar.Remove(satis);

                    // 2. Aracın durumunu geri "Satışta" yap
                    var arac = context.Araclar.Find(satis.AracId);
                    if (arac != null)
                    {
                        arac.Durum = true; // Satışta
                    }

                    context.SaveChanges();

                    MessageBox.Show("Satış başarıyla silindi.");
                    this.Close();

                    // Satış listesini güncelle
                    SatisSilForm_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Satış bulunamadı.");
                }
            }
        }

        private void cmbSatislar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
