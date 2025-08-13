using System;
using System.Linq;
using OtoGaleriApp.DataAccess;

using OtoGaleriApp.Model;

namespace OtoGaleriApp.Presenter
{
    public class GirisPresenter
    {
        private readonly IGirisView _view;
        private readonly GaleriContext _context;

        public GirisPresenter(IGirisView view)
        {
            _view = view;
            _context = new GaleriContext();

            _view.OnLogin += _view_OnLogin;
        }

        private void _view_OnLogin()
        {
            GirisYap();
        }

        public void GirisYap()
        {
            var kullanici = _context.Kullanicilar
                .AsEnumerable() 
                .FirstOrDefault(k =>
                    string.Equals(k.KullaniciAdi, _view.KullaniciAdi, StringComparison.Ordinal) &&
                    string.Equals(k.Sifre, _view.Sifre, StringComparison.Ordinal)
                );

            if (kullanici != null)
            {
                _view.GecisYap();
            }
            else
            {
                _view.MesajGoster("Kullanıcı adı veya şifre hatalı.");
            }
        }

    }
}
