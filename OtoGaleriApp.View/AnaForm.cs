using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtoGaleriApp.DataAccess;
using OtoGaleriApp.View;

namespace OtoGaleriApp.View
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        public void btnAracEkle_Click(object sender, EventArgs e)
        {
            AracEkleForm form = new AracEkleForm();
            form.ShowDialog();
        }


        private void btnSatislar_Click(object sender, EventArgs e)
        {
            var form = new SatislarForm();
            form.ShowDialog(); 
        }



        private void btnAracSil_Click(object sender, EventArgs e)
        {
            AracSilForm form = new AracSilForm(this);
            form.ShowDialog();
        }

        private void btnAracGuncelle_Click(object sender, EventArgs e)
        {
            AracGuncelleForm form = new AracGuncelleForm();
            form.ShowDialog();
    
        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            KisiEkleForm kisiEkleForm = new KisiEkleForm();
            kisiEkleForm.ShowDialog(); 
        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            KisiSilForm form = new KisiSilForm();
            form.ShowDialog();
        }

        private void btnKisiGuncelle_Click(object sender, EventArgs e)
        {
            KisiGuncelleForm form = new KisiGuncelleForm();
            form.ShowDialog();
        }

        private void btnKisiler_Click(object sender, EventArgs e)
        {
            KisiListeForm kisiListeForm = new KisiListeForm();
            kisiListeForm.ShowDialog();
        }


        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            SatisYapForm satisForm = new SatisYapForm();
            satisForm.Show(); 
        }

        private void btnSatisSil_Click(object sender, EventArgs e)
        {
            var form = new SatisSilForm();
            form.ShowDialog();
        }

        private void btnSatisGuncelle_Click(object sender, EventArgs e)
        {
            var form = new SatisGuncelleForm();
            form.ShowDialog();
        }

        private void btnAraclar_Click(object sender, EventArgs e)
        {
            AracListeleForm aracForm = new AracListeleForm();
            aracForm.ShowDialog();
        }

    }
}
