using OtoGaleriApp.DataAccess;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    public partial class AracListeleForm : Form
    {
        public AracListeleForm()
        {
            InitializeComponent();
        }

        private void AracListeleForm_Load(object sender, EventArgs e)
        {
            cmbDurum.Items.Add("Hepsi");
            cmbDurum.Items.Add("Satışta");
            cmbDurum.Items.Add("Satıldı");
            cmbDurum.SelectedIndex = 0;

            AraclariYukle();
        }

        private void AraclariYukle()
        {
            using (var context = new GaleriContext())
            {
                var araclar = context.Araclar
                    .Select(a => new
                    {
                        a.Id,
                        a.Marka,
                        a.Model,
                        a.Plaka,
                        a.Yil,
                        a.Durum
                    })
                    .ToList();

                dgvAraclar.DataSource = araclar;
            }
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            using (var context = new GaleriContext())
            {
                var query = context.Araclar.AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtMarka.Text))
                    query = query.Where(a => a.Marka.Contains(txtMarka.Text));

                if (!string.IsNullOrWhiteSpace(txtModel.Text))
                    query = query.Where(a => a.Model.Contains(txtModel.Text));

                if (!string.IsNullOrWhiteSpace(txtPlaka.Text))
                    query = query.Where(a => a.Plaka.Contains(txtPlaka.Text));

                if (!string.IsNullOrWhiteSpace(txtYil.Text) && int.TryParse(txtYil.Text, out int yil))
                    query = query.Where(a => a.Yil == yil);

                if (cmbDurum.SelectedItem.ToString() != "Hepsi")
                {
                    bool durumFiltre = cmbDurum.SelectedItem.ToString() == "Satışta";
                    query = query.Where(a => a.Durum == durumFiltre);
                }


                dgvAraclar.DataSource = query
                    .Select(a => new
                    {
                        a.Id,
                        a.Marka,
                        a.Model,
                        a.Plaka,
                        a.Yil,
                        a.Durum
                    })
                    .ToList();
            }
        }

        private void dgvAraclar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFiltrele_Click_1(object sender, EventArgs e)
        {
            using (var context = new GaleriContext())
            {
                var query = context.Araclar.AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtMarka.Text))
                    query = query.Where(a => a.Marka.Contains(txtMarka.Text));

                if (!string.IsNullOrWhiteSpace(txtModel.Text))
                    query = query.Where(a => a.Model.Contains(txtModel.Text));

                if (!string.IsNullOrWhiteSpace(txtPlaka.Text))
                    query = query.Where(a => a.Plaka.Contains(txtPlaka.Text));

                if (!string.IsNullOrWhiteSpace(txtYil.Text) && int.TryParse(txtYil.Text, out int yil))
                    query = query.Where(a => a.Yil == yil);

                if (cmbDurum.SelectedItem.ToString() != "Hepsi")
                {
                    bool durumFiltre = cmbDurum.SelectedItem.ToString() == "Satışta";
                    query = query.Where(a => a.Durum == durumFiltre);
                }


                dgvAraclar.DataSource = query
                    .Select(a => new
                    {
                        a.Id,
                        a.Marka,
                        a.Model,
                        a.Plaka,
                        a.Yil,
                        a.Durum
                    })
                    .ToList();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
