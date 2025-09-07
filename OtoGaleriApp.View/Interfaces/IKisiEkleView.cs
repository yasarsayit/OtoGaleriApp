using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtoGaleriApp.View.Interfaces;


namespace OtoGaleriApp.View.Interfaces
{
    public interface IKisiEkleView
    {
        string Ad { get; }
        string Soyad { get; }
        string TC { get; }
        string Telefon { get; }

        void MesajGoster(string mesaj);
        void Kapat();
    }
}

