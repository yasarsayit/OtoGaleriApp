using OtoGaleriApp.DataAccess;
using OtoGaleriApp.Interfaces;
using System.Linq;

namespace OtoGaleriApp.Presenter
{
    public class SatisListePresenter
    {
        private readonly ISatisListeView _view;

        public SatisListePresenter(ISatisListeView view)
        {
            _view = view;
        }

        public void LoadSatislar()
        {
            using (var context = new GaleriContext())
            {
                // Önce raw verileri al
                var satislar = context.Satislar
                    .Select(s => new
                    {
                        s.Id,
                        s.Arac.Plaka,
                        s.Arac.Marka,
                        s.Arac.Model,
                        s.Arac.Yil,
                        AliciAd = s.Alici.Ad,
                        AliciSoyad = s.Alici.Soyad,
                        SaticiAdi = s.Satici.KullaniciAdi,
                        s.SatisFiyati,
                        s.Tarih
                    })
                    .ToList()
                    .Select(s => new
                    {
                        s.Id,
                        s.Plaka,
                        s.Marka,
                        s.Model,
                        s.Yil,
                        Alici = s.AliciAd + " " + s.AliciSoyad,
                        Satici = s.SaticiAdi,
                        Fiyat = s.SatisFiyati,
                        Tarih = s.Tarih.ToShortDateString()
                    })
                    .ToList();

                _view.SetSatislar(satislar);
            }
        }
    }
}
