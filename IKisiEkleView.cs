using System;

namespace OtoGaleriApp.Interfaces
{
    public interface IKisiEkleView
    {
        string Ad { get; }
        string Soyad { get; }
        string TC { get; }
        string Telefon { get; }

        void ShowMessage(string message);
        void CloseForm();
    }
}

