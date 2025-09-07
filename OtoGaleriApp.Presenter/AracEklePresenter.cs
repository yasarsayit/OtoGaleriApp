using OtoGaleriApp.DataAccess;
using OtoGaleriApp.Interfaces;
using System;

namespace OtoGaleriApp.Presenter
{
    public class AracEklePresenter
    {
        private readonly IAracEkleView _view;

        public AracEklePresenter(IAracEkleView view)
        {
            _view = view;
        }

        public void AracEkle()
        {
            try
            {
                if (!int.TryParse(_view.Yil, out int yil))
                {
                    _view.ShowMessage("Geçerli bir yıl girin.");
                    return;
                }

                using (var context = new GaleriContext())
                {
                    var arac = new Model.Arac
                    {
                        Marka = _view.Marka,
                        Model = _view.Model,
                        Plaka = _view.Plaka,
                        Yil = yil,
                        Durum = true

                    };

                    context.Araclar.Add(arac);
                    context.SaveChanges();
                }

                _view.ShowMessage("Araç başarıyla eklendi.");
                _view.CloseForm();
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Hata: " + ex.Message);
            }
        }
    }
}

