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

namespace OtoGaleriApp.View
{
    public partial class KisiSilForm : Form
    {
        public KisiSilForm()
        {
            InitializeComponent();
        }

        private void KisiSilForm_Load(object sender, EventArgs e)
        {
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

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            if (cmbKisiler.SelectedValue != null)
            {
                int secilenId = (int)cmbKisiler.SelectedValue;

                using (var context = new GaleriContext())
                {
                    var kisi = context.Kisiler.Find(secilenId);

                    if (kisi != null)
                    {
                        context.Kisiler.Remove(kisi);
                        context.SaveChanges();
                        MessageBox.Show("Kişi başarıyla silindi.");

                        this.Close(); // Formu kapat
                    }
                    else
                    {
                        MessageBox.Show("Kişi bulunamadı.");
                    }
                }
            }
        }

    }

}
