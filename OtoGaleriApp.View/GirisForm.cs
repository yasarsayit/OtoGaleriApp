using System;
using System.Windows.Forms;
using OtoGaleriApp.Presenter;
using OtoGaleriApp.View;
using OtoGaleriApp.Model;

namespace OtoGaleriApp.View
{
    public partial class GirisForm : Form, IGirisView
    {
        //public GirisPresenter _presenter;
        public event Action OnLogin;
        public GirisForm()
        {
            InitializeComponent();
            //_presenter = new GirisPresenter(this);
        }

        public string KullaniciAdi => UsernametextBox1.Text;
        public string Sifre => PasswordtextBox2.Text;

        public void MesajGoster(string mesaj)
        {
            MessageBox.Show(mesaj);
        }

        public void GecisYap()
        {
            this.Hide(); 
            AnaForm anaForm = new AnaForm(); 
            anaForm.FormClosed += (s, e) => this.Close(); 
            anaForm.Show(); 
        }

        public void GirisForm_Load(object sender, EventArgs e)
        {

        }

        private void Loginbutton1_Click(object sender, EventArgs e)
        {
            //_presenter.GirisYap();
            OnLogin?.Invoke();
        }

       

        private void BtnKullaniciEkle_Click_1(object sender, EventArgs e)
        {
            KullaniciEkleForm form = new KullaniciEkleForm();
            form.ShowDialog();
        }

        private void UsernametextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSifre_Click(object sender, EventArgs e)
        {

        }
    }
}
