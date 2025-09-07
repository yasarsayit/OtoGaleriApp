using OtoGaleriApp.DataAccess;
using OtoGaleriApp.Interfaces;
using System.Linq;

namespace OtoGaleriApp.Presenter
{
    public class KisiGuncellePresenter
    {
        private readonly IKisiGuncelleView _view;

        public KisiGuncellePresenter(IKisiGuncelleView view)
        {
            _view = view;
        }

        public void Yukle()
        {
            using (var context = new GaleriContext())
            {
                var kisiler = context.Kisiler
                    .Select(k => new { k.Id, AdSoyad = k.Id + " - " + k.Ad + " " + k.Soyad })
                    .ToList();

                _view.SetKisiler(kisiler);
            }
        }




        public void KisiSecildi()
        {
            using (var context = new GaleriContext())
            {
                var kisi = context.Kisiler.Find(_view.SecilenKisiId);
                if (kisi != null)
                {
                    _view.SetFormFields(kisi.Ad, kisi.Soyad, kisi.TC, kisi.Telefon);
                }
            }
        }


        public void Guncelle()
        {
            using (var context = new GaleriContext())
            {
                var kisi = context.Kisiler.Find(_view.SecilenKisiId);
                if (kisi == null)
                {
                    _view.ShowMessage("Kişi bulunamadı.");
                    return;
                }

                
                if (string.IsNullOrWhiteSpace(_view.TC) ||
                    _view.TC.Length != 11 ||
                    !_view.TC.All(char.IsDigit))
                {
                    _view.ShowMessage("TC kimlik numarası 11 haneli ve sadece rakamlardan oluşmalıdır.");
                    return;
                }

                
                if (string.IsNullOrWhiteSpace(_view.Telefon) ||
                    _view.Telefon.Length != 10 ||
                    !_view.Telefon.All(char.IsDigit))
                {
                    _view.ShowMessage("Telefon numarası 10 haneli ve sadece rakamlardan oluşmalıdır.");
                    return;
                }

                
                bool tcVar = context.Kisiler.Any(k => k.Id != kisi.Id && k.TC == _view.TC);
                bool telVar = context.Kisiler.Any(k => k.Id != kisi.Id && k.Telefon == _view.Telefon);

                if (tcVar || telVar)
                {
                    string msg = "Güncelleme yapılamadı:";
                    if (tcVar) msg += "\n- Bu TC başka bir kişide kayıtlı.";
                    if (telVar) msg += "\n- Bu telefon başka bir kişide kayıtlı.";
                    _view.ShowMessage(msg);
                    return;
                }

                
                kisi.Ad = _view.Ad;
                kisi.Soyad = _view.Soyad;
                kisi.TC = _view.TC;
                kisi.Telefon = _view.Telefon;

                context.SaveChanges();
                _view.ShowMessage("Kişi başarıyla güncellendi.");
                _view.CloseForm();
            }
        }

    }
}
