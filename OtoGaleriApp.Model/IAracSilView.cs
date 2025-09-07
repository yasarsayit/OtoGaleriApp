using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriApp.Interfaces
{
    public interface IAracSilView
    {
        int SecilenAracId { get; }

        void ShowMessage(string message);
        void CloseForm();
        void SetAraclar(object araclar); 
    }
}

