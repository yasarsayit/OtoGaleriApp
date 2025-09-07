using OtoGaleriApp.DataAccess;
using System.Linq;

namespace OtoGaleriApp.View
{
    public class KisiListePresenter
    {
        private readonly IKisiListeView _view;

        public KisiListePresenter(IKisiListeView view)
        {
            _view = view;
        }

        public void KisileriYukle()
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

                _view.SetKisiler(kisiler);
            }
        }
    }
}
