using System;

namespace OtoGaleriApp.Interfaces
{
    public interface IAracSilView
    {
        int SecilenAracId { get; }

        void ShowMessage(string message);
        void CloseForm();
        void SetAraclar(object araclar); // ComboBox’a araçları yüklemek için
    }
}

