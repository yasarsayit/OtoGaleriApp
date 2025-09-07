using System;

namespace OtoGaleriApp.Interfaces
{
    public interface ISatisYapView
    {
        int SecilenAracId { get; }
        int SecilenAliciId { get; }
        int SecilenSaticiId { get; }
        decimal Fiyat { get; }
        DateTime Tarih { get; }

        void ShowMessage(string message);
        void CloseForm();
    }
}
