using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
