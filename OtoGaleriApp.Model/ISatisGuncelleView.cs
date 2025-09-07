using System;

namespace OtoGaleriApp.Interfaces
{
    public interface ISatisGuncelleView
    {
        int SecilenSatisId { get; }
        int SecilenAracId { get; }
        int SecilenAliciId { get; }
        int SecilenSaticiId { get; }
        decimal Fiyat { get; }
        DateTime Tarih { get; }

        void ShowMessage(string message);
        void CloseForm();

        void SetAraclar(object dataSource);
        void SetKisiler(object dataSource);
        void SetKullanicilar(object dataSource);
        void SetSatislar(object dataSource);
        void SetSelectedSatis(object satis);
    }
}
