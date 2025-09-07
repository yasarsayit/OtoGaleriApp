using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

