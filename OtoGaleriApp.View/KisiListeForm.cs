using OtoGaleriApp.DataAccess;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OtoGaleriApp.View
{
    public partial class KisiListeForm : Form
    {
        public KisiListeForm()
        {
            InitializeComponent();
        }

        private void KisiListeForm_Load(object sender, EventArgs e)
        {
            using (var context = new GaleriContext())
            {
                var kisiler = context.Kisiler
                    .Select(k => new
                    {
                        k.Id,
                        k.Ad,
                        k.Soyad,
                        k.TC,
                        k.Telefon
                    })
                    .ToList();

                dataGridViewKisiler.DataSource = kisiler;
            }
        }
    }
}
