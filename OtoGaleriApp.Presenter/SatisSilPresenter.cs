using OtoGaleriApp.DataAccess;
using System;
using System.Linq;

namespace OtoGaleriApp.Presenter
{
    public class SatisSilPresenter
    {
        private readonly Interfaces.ISatisSilView _view;

        public SatisSilPresenter(Interfaces.ISatisSilView view)
        {
            _view = view;
        }

        public void LoadSatislar()
        {
            using (var context = new GaleriContext())
            {
                var satislar = context.Satislar
                    .Select(s => new
                    {
                        s.Id,
                        s.Arac.Plaka,
                        AliciAd = s.Alici.Ad,
                        AliciSoyad = s.Alici.Soyad,
                        s.Tarih
                    })
                    .ToList() 
                    .Select(s => new
                    {
                        s.Id,
                        Aciklama = s.Plaka + " - " + s.AliciAd + " " + s.AliciSoyad + " - " + s.Tarih.ToShortDateString()
                    })
                    .ToList();

                _view.SetSatislar(satislar);
            }

        }

        public void SatisSil()
        {
            if (_view.SecilenSatisId == 0)
            {
                _view.ShowMessage("Lütfen silinecek satışı seçin.");
                return;
            }

            try
            {
                using (var context = new GaleriContext())
                {
                    var satis = context.Satislar.Find(_view.SecilenSatisId);
                    if (satis == null)
                    {
                        _view.ShowMessage("Satış bulunamadı.");
                        return;
                    }

                    
                    context.Satislar.Remove(satis);

                    
                    var arac = context.Araclar.Find(satis.AracId);
                    if (arac != null) arac.Durum = true;

                    context.SaveChanges();

                    _view.ShowMessage("Satış başarıyla silindi.");
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
