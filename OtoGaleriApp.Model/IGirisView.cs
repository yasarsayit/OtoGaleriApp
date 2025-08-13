using System;

namespace OtoGaleriApp.Model
{
    public interface IGirisView
    {
        event Action OnLogin;
        string KullaniciAdi { get; }
        string Sifre { get; }
        void MesajGoster(string mesaj);
        void GecisYap();
    }
}
