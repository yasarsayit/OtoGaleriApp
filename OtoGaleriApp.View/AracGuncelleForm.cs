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
    public partial class AracGuncelleForm : Form
    {
        private AnaForm _anaForm;
        private int _aracId;

        public AracGuncelleForm()
        {
            InitializeComponent();
        }

        public AracGuncelleForm(AnaForm anaForm, int aracId)
        {
            InitializeComponent();
            _anaForm = anaForm;
            _aracId = aracId;
        }

        private void AracGuncelleForm_Load(object sender, EventArgs e)
        {
            using (var context = new GaleriContext())
            {
                var araclar = context.Araclar
                    .Select(a => new { a.Id, a.Plaka, a.Model })
                    .ToList();

                cmbAraclar.DataSource = araclar;
                cmbAraclar.DisplayMember = "Plaka";
                cmbAraclar.ValueMember = "Id";
                cmbAraclar.ValueMember = "Model";
            }
        }





        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int secilenId = (int)cmbAraclar.SelectedValue;

            using (var context = new GaleriContext())
            {
                var arac = context.Araclar.Find(secilenId);
                if (arac != null)
                {
                    arac.Marka = txtMarka.Text;
                    arac.Model = txtModel.Text;
                    arac.Plaka = txtPlaka.Text;
                    arac.Yil = int.Parse(txtYil.Text);
                    arac.Durum = chkDurum.Checked;

                    context.SaveChanges();
                    MessageBox.Show("Araç başarıyla güncellendi.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Araç bulunamadı.");
                }
            }
        }


        private void cmbAraclar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbAraclar.SelectedItem == null)
                return;

            dynamic secilenArac = cmbAraclar.SelectedItem;
            int secilenId = secilenArac.Id;

            using (var context = new GaleriContext())
            {
                var arac = context.Araclar.Find(secilenId);
                if (arac != null)
                {
                    txtMarka.Text = arac.Marka;
                    txtModel.Text = arac.Model;
                    txtPlaka.Text = arac.Plaka;
                    txtYil.Text = arac.Yil.ToString();
                    chkDurum.Checked = arac.Durum;
                }
            }
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            int secilenId = (int)cmbAraclar.SelectedValue;

            using (var context = new GaleriContext())
            {
                var arac = context.Araclar.Find(secilenId);
                if (arac != null)
                {
                    arac.Marka = txtMarka.Text;
                    arac.Model = txtModel.Text;
                    arac.Plaka = txtPlaka.Text;
                    arac.Yil = int.Parse(txtYil.Text);
                    arac.Durum = chkDurum.Checked;

                    context.SaveChanges();
                    MessageBox.Show("Araç başarıyla güncellendi.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Araç bulunamadı.");
                }
            }
        }

        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblAraclar_Click(object sender, EventArgs e)
        {

        }
    }

}
