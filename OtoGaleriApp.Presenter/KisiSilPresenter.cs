using System.Linq;
using OtoGaleriApp.DataAccess;
using OtoGaleriApp.Interfaces;

namespace OtoGaleriApp.Presenter
{
    public class KisiSilPresenter
    {
        private readonly IKisiSilView _view;
        private readonly GaleriContext _context;

        public KisiSilPresenter(IKisiSilView view)
        {
            _view = view;
            _context = new GaleriContext();
        }

        public void Yukle()
        {
            var kisiler = _context.Kisiler
                .Select(k => new
                {
                    k.Id,
                    Gosterim = k.Ad + " " + k.Soyad + " - " + " " + k.TC
                })
                .ToList<object>();

            _view.SetKisiler(kisiler);
        }

        public void KisiSil()
        {
            int id = _view.SecilenKisiId;
            var kisi = _context.Kisiler.Find(id);

            if (kisi != null)
            {
                _context.Kisiler.Remove(kisi);
                _context.SaveChanges();
            }
        }
    }
}
