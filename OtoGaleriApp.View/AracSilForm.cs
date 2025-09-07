using OtoGaleriApp.Interfaces;
using OtoGaleriApp.Presenter;
using System;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    public partial class AracSilForm : Form, IAracSilView
    {
        private readonly AracSilPresenter _presenter;

        public AracSilForm()
        {
            InitializeComponent();
            _presenter = new AracSilPresenter(this);
        }

        public int SecilenAracId
        {
            get
            {
                if (cmbAraclar.SelectedValue != null && int.TryParse(cmbAraclar.SelectedValue.ToString(), out int id))
                    return id;
                return 0;
            }
        }

        public void ShowMessage(string message) => MessageBox.Show(message);
        public void CloseForm() => this.Close();

        public void SetAraclar(object araclar)
        {
            cmbAraclar.DataSource = araclar;
            cmbAraclar.DisplayMember = "Display";
            cmbAraclar.ValueMember = "Id";
        }

        private void AracSilForm_Load(object sender, EventArgs e)
        {
            _presenter.Yukle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _presenter.Sil();
        }
    }
}
