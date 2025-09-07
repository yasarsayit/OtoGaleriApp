using OtoGaleriApp.Model;
using OtoGaleriApp.Presenter;
using System;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    public partial class AracListeleForm : Form, IAracListeleView
    {
        private readonly AracPresenter _presenter;

        public AracListeleForm()
        {
            InitializeComponent();
            _presenter = new AracPresenter(this);
        }

     
        public string FiltreMarka => txtMarka.Text;
        public string FiltreModel => txtModel.Text;
        public string FiltrePlaka => txtPlaka.Text;
        public string FiltreYil => txtYil.Text;
        public string FiltreDurum => cmbDurum.SelectedItem?.ToString() ?? "Hepsi";

        public void SetAraclar(object araclar)
        {
            dgvAraclar.DataSource = araclar;
        }

        private void AracListeleForm_Load(object sender, EventArgs e)
        {
            cmbDurum.Items.AddRange(new[] { "Hepsi", "Satışta", "Satıldı" });
            cmbDurum.SelectedIndex = 0;

            _presenter.Yukle();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            _presenter.Filtrele();
        }
    }
}
