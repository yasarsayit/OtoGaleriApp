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
    public partial class AracSilForm : Form
    {
        private AnaForm _anaForm;

        public AracSilForm(AnaForm anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
        }

        private void AracSilForm_Load(object sender, EventArgs e)
        {
            using (var context = new GaleriContext())
            {
                var araclar = context.Araclar
                    .Select(a => new
                    {
                        a.Id,
                        Display = a.Marka + " " + a.Model + " - " + a.Yil + " - " + a.Plaka
                    })
                    .ToList();

                cmbAraclar.DataSource = araclar;
                cmbAraclar.DisplayMember = "Display";
                cmbAraclar.ValueMember = "Id";
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            int secilenId = (int)cmbAraclar.SelectedValue;

            using (var context = new GaleriContext())
            {
                var arac = context.Araclar.Find(secilenId);

                if (arac != null)
                {
                    context.Araclar.Remove(arac);
                    context.SaveChanges();
                    MessageBox.Show("Araç silindi.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Araç bulunamadı.");
                }
            }
        }
    }

}

