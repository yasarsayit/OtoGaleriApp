using OtoGaleriApp.DataAccess;
using OtoGaleriApp.Interfaces;
using OtoGaleriApp.Model;
using System.Linq;

namespace OtoGaleriApp.Presenter
{
    public class SatisGuncellePresenter
    {
        private readonly ISatisGuncelleView _view;

        public SatisGuncellePresenter(ISatisGuncelleView view)
        {
            _view = view;
        }

        
        public void LoadData()
        {
            using (var context = new GaleriContext())
            {
                _view.SetAraclar(
                    context.Araclar
                        .Select(a => new { a.Id, Gosterim = a.Plaka + " - " + a.Model })
                        .ToList()
                );

                _view.SetKisiler(
                    context.Kisiler
                        .Select(k => new { k.Id, AdSoyad = k.Ad + " " + k.Soyad })
                        .ToList()
                );

                _view.SetKullanicilar(
                    context.Kullanicilar
                        .Select(u => new { u.Id, u.KullaniciAdi })
                        .ToList()
                );

                _view.SetSatislar(
                    context.Satislar
                        .Select(s => new
                        {
                            s.Id,
                            Aciklama = s.Id.ToString()
                        })
                        .ToList()
                );
            }
        }

        
        public void SatisSecildi()
        {
            if (_view.SecilenSatisId <= 0) return;

            using (var context = new GaleriContext())
            {
                var satis = context.Satislar.FirstOrDefault(s => s.Id == _view.SecilenSatisId);
                if (satis != null)
                {
                    _view.SetSelectedSatis(satis);
                }
            }
        }

        
        public void SatisGuncelle()
        {
            if (_view.SecilenSatisId <= 0 ||
                _view.SecilenAracId <= 0 ||
                _view.SecilenAliciId <= 0 ||
                _view.SecilenSaticiId <= 0)
            {
                _view.ShowMessage("Lütfen tüm alanları seçin.");
                return;
            }

            if (_view.Fiyat <= 0)
            {
                _view.ShowMessage("Geçerli bir fiyat girin.");
                return;
            }

            using (var context = new GaleriContext())
            {
                var satis = context.Satislar.FirstOrDefault(s => s.Id == _view.SecilenSatisId);
                if (satis == null)
                {
                    _view.ShowMessage("Satış bulunamadı.");
                    return;
                }

                satis.AracId = _view.SecilenAracId;
                satis.AliciId = _view.SecilenAliciId;
                satis.SaticiId = _view.SecilenSaticiId;
                satis.SatisFiyati = _view.Fiyat;
                satis.Tarih = _view.Tarih;

                context.SaveChanges();
                _view.ShowMessage("Satış başarıyla güncellendi.");
                _view.CloseForm();
            }
        }
    }
}
