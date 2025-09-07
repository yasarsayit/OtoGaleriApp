using OtoGaleriApp.DataAccess;
using OtoGaleriApp.Interfaces;
using System.Linq;

namespace OtoGaleriApp.Presenter
{
    public class AracSilPresenter
    {
        private readonly IAracSilView _view;

        public AracSilPresenter(IAracSilView view)
        {
            _view = view;
        }

        
        public void Yukle()
        {
            using (var context = new GaleriContext())
            {
                var araclar = context.Araclar
                    .Select(a => new { a.Id, Display = a.Marka + " " + a.Model + " - " + a.Yil + " - " + a.Plaka })
                    .ToList();

                _view.SetAraclar(araclar);
            }
        }

        
        public void Sil()
        {
            if (_view.SecilenAracId == 0)
            {
                _view.ShowMessage("Lütfen silinecek aracı seçin.");
                return;
            }

            using (var context = new GaleriContext())
            {
                var arac = context.Araclar.Find(_view.SecilenAracId);

                if (arac != null)
                {
                    context.Araclar.Remove(arac);
                    context.SaveChanges();
                    _view.ShowMessage("Araç başarıyla silindi.");
                    _view.CloseForm();
                }
                else
                {
                    _view.ShowMessage("Araç bulunamadı.");
                }
            }
        }
    }
}
