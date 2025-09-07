using OtoGaleriApp.Interfaces;
using OtoGaleriApp.Presenter;
using System;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    public partial class AracGuncelleForm : Form, IAracGuncelleView
    {
        private readonly AracGuncellePresenter _presenter;

        public AracGuncelleForm()
        {
            InitializeComponent();
            _presenter = new AracGuncellePresenter(this);
        }

        public int SecilenAracId
        {
            get
            {
                if (cmbAraclar.SelectedValue == null) return 0;

                
                if (cmbAraclar.SelectedValue is int id)
                    return id;

                
                try
                {
                    return (int)cmbAraclar.SelectedValue;
                }
                catch
                {
                    return 0;
                }
            }
        }


        public string Marka => txtMarka.Text;
        public string Model => txtModel.Text;
        public string Plaka => txtPlaka.Text;
        public string Yil => txtYil.Text;
        public bool Durum => chkDurum.Checked;

        public void SetAraclar(object dataSource)
        {
            cmbAraclar.DataSource = dataSource;
            cmbAraclar.DisplayMember = "Aciklama"; 
            cmbAraclar.ValueMember = "Id";
        }

        public void SetFormFields(string marka, string model, string plaka, string yil, bool durum)
        {
            txtMarka.Text = marka;
            txtModel.Text = model;
            txtPlaka.Text = plaka;
            txtYil.Text = yil;
            chkDurum.Checked = durum;
        }

        public void ShowMessage(string message) => MessageBox.Show(message);
        public void CloseForm() => this.Close();

        private void AracGuncelleForm_Load(object sender, EventArgs e)
        {
            _presenter.Yukle();

            if (cmbAraclar.Items.Count > 0)
            {
                cmbAraclar.SelectedIndexChanged -= cmbAraclar_SelectedIndexChanged;
                cmbAraclar.SelectedIndex = 0;
                _presenter.AracSecildi();
                cmbAraclar.SelectedIndexChanged += cmbAraclar_SelectedIndexChanged;
            }
        }

        private void cmbAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.AracSecildi();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _presenter.Guncelle();
        }
    }
}
