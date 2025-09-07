using System;

namespace OtoGaleriApp.Interfaces
{
    public interface IAracGuncelleView
    {
        int SecilenAracId { get; }
        string Marka { get; }
        string Model { get; }
        string Plaka { get; }
        string Yil { get; }
        bool Durum { get; }

        void ShowMessage(string message);
        void CloseForm();
        void SetAraclar(object araclar); // ComboBox’a araçları yüklemek için
        void SetFormFields(string marka, string model, string plaka, string yil, bool durum); // Seçilen aracı forma doldur
    }
}

