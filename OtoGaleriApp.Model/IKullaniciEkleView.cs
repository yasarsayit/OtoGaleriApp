using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriApp.Interfaces
{
    public interface IKullaniciEkleView
    {
        string KullaniciAdi { get; }
        string Sifre { get; }
        string SifreTekrar { get; }

        void ShowMessage(string message);
        void CloseForm();
    }
}

