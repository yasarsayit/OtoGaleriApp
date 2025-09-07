using OtoGaleriApp.DataAccess;
using OtoGaleriApp.Interfaces;
using OtoGaleriApp.Model;
using System;
using System.Linq;

namespace OtoGaleriApp.Presenter
{
    public class SatisYapPresenter
    {
        private readonly ISatisYapView _view;

        public SatisYapPresenter(ISatisYapView view)
        {
            _view = view;
        }

        public void SatisYap()
        {
            if (_view.SecilenAracId == 0 || _view.SecilenAliciId == 0 || _view.SecilenSaticiId == 0)
            {
                _view.ShowMessage("Lütfen tüm alanları seçin.");
                return;
            }

            if (_view.Fiyat <= 0)
            {
                _view.ShowMessage("Geçerli bir fiyat girin.");
                return;
            }

            try
            {
                using (var context = new GaleriContext())
                {
                    var arac = context.Araclar.Find(_view.SecilenAracId);
                    if (arac == null)
                    {
                        _view.ShowMessage("Araç bulunamadı.");
                        return;
                    }

                    var satis = new Satis
                    {
                        AracId = _view.SecilenAracId,
                        AliciId = _view.SecilenAliciId,
                        SaticiId = _view.SecilenSaticiId,
                        SatisFiyati = _view.Fiyat,
                        Tarih = _view.Tarih
                    };

                    context.Satislar.Add(satis);
                    arac.Durum = false; 

                    context.SaveChanges();

                    _view.ShowMessage("Satış başarıyla tamamlandı.");
                    _view.CloseForm();
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Hata: " + ex.Message);
            }
        }
    }
}
