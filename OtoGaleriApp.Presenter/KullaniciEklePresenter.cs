using OtoGaleriApp.DataAccess;
using OtoGaleriApp.Interfaces;
using OtoGaleriApp.Model;
using System.Linq;

namespace OtoGaleriApp.Presenter
{
    public class KullaniciEklePresenter
    {
        private readonly IKullaniciEkleView _view;

        public KullaniciEklePresenter(IKullaniciEkleView view)
        {
            _view = view;
        }

        public void Kaydet()
        {
            if (_view.Sifre != _view.SifreTekrar)
            {
                _view.ShowMessage("Şifreler eşleşmiyor!");
                return;
            }

            using (var context = new GaleriContext())
            {
                // Tekillik kontrolü
                bool exists = context.Kullanicilar.Any(u => u.KullaniciAdi == _view.KullaniciAdi);
                if (exists)
                {
                    _view.ShowMessage("Bu kullanıcı adı zaten kayıtlı.");
                    return;
                }

                var kullanici = new Kullanici
                {
                    KullaniciAdi = _view.KullaniciAdi,
                    Sifre = _view.Sifre
                };

                context.Kullanicilar.Add(kullanici);
                context.SaveChanges();

                _view.ShowMessage("Kullanıcı başarıyla eklendi.");
                _view.CloseForm();
            }
        }
    }
}
