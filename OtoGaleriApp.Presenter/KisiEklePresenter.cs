using OtoGaleriApp.DataAccess;
using OtoGaleriApp.Interfaces;
using OtoGaleriApp.Model;
using System.Linq;

namespace OtoGaleriApp.Presenters
{
    public class KisiEklePresenter
    {
        private readonly IKisiEkleView _view;

        public KisiEklePresenter(IKisiEkleView view)
        {
            _view = view;
        }

        public void Kaydet()
        {
            string tc = _view.TC?.Trim();
            string telefon = _view.Telefon?.Trim();

           
            if (string.IsNullOrEmpty(tc) || tc.Length != 11 || !tc.All(char.IsDigit))
            {
                _view.ShowMessage("TC Kimlik Numarası 11 haneli ve sadece rakamlardan oluşmalıdır.");
                return;
            }

            
            if (string.IsNullOrEmpty(telefon) || telefon.Length != 10 || !telefon.All(char.IsDigit))
            {
                _view.ShowMessage("Telefon numarası 10 haneli ve sadece rakamlardan oluşmalıdır.");
                return;
            }

            if (telefon.StartsWith("0"))
            {
                _view.ShowMessage("Telefon numarası 0 ile başlamamalıdır.");
                return;
            }

            using (var context = new GaleriContext())
            {
                
                bool existsByTc = context.Kisiler.Any(k => k.TC == tc);
                bool existsByTel = context.Kisiler.Any(k => k.Telefon == telefon);

                if (existsByTc || existsByTel)
                {
                    string msg = "Kayıt eklenemedi:";
                    if (existsByTc) msg += "\n- Bu T.C. Kimlik Numarası zaten kayıtlı.";
                    if (existsByTel) msg += "\n- Bu telefon numarası zaten kayıtlı.";
                    _view.ShowMessage(msg);
                    return;
                }

                
                var yeniKisi = new Kisi
                {
                    Ad = _view.Ad.Trim(),
                    Soyad = _view.Soyad.Trim(),
                    TC = tc,
                    Telefon = telefon
                };

                context.Kisiler.Add(yeniKisi);
                context.SaveChanges();

                _view.ShowMessage("Kişi başarıyla eklendi.");
                _view.CloseForm();
            }
        }
    }
}
