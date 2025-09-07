using System;

namespace OtoGaleriApp.Interfaces
{
    public interface IAracEkleView
    {
        string Marka { get; }
        string Model { get; }
        string Plaka { get; }
        string Yil { get; }
        

        void ShowMessage(string message);
        void CloseForm();
    }
}
