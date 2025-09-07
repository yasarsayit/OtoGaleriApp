using OtoGaleriApp.DataAccess;
using OtoGaleriApp.Interfaces;
using System.Linq;

namespace OtoGaleriApp.Presenter
{
    public class AracGuncellePresenter
    {
        private readonly IAracGuncelleView _view;

        public AracGuncellePresenter(IAracGuncelleView view)
        {
            _view = view;
        }

        public void Yukle()
        {
            using (var context = new GaleriContext())
            {
                _view.SetAraclar(
                    context.Araclar
                        .Select(a => new { a.Id, Aciklama = a.Id.ToString() })
                        .ToList()
                );
            }
        }

        public void AracSecildi()
        {
            if (_view.SecilenAracId <= 0) return;

            using (var context = new GaleriContext())
            {
                var arac = context.Araclar.Find(_view.SecilenAracId);
                if (arac != null)
                {
                    _view.SetFormFields(arac.Marka, arac.Model, arac.Plaka, arac.Yil.ToString(), arac.Durum);
                }
            }
        }

        public void Guncelle()
        {
            if (_view.SecilenAracId <= 0) return;

            using (var context = new GaleriContext())
            {
                var arac = context.Araclar.Find(_view.SecilenAracId);
                if (arac != null)
                {
                    if (!int.TryParse(_view.Yil, out int yil))
                    {
                        _view.ShowMessage("Geçerli bir yıl girin.");
                        return;
                    }

                    arac.Marka = _view.Marka;
                    arac.Model = _view.Model;
                    arac.Plaka = _view.Plaka;
                    arac.Yil = yil;
                    arac.Durum = _view.Durum;

                    context.SaveChanges();
                    _view.ShowMessage("Araç başarıyla güncellendi.");
                    _view.CloseForm();
                }
            }
        }
    }
}
