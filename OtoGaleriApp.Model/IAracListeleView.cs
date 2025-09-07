using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriApp.Model
{
    
    public interface IAracListeleView
    {
        string FiltreMarka { get; }
        string FiltreModel { get; }
        string FiltrePlaka { get; }
        string FiltreYil { get; }
        string FiltreDurum { get; }

        void SetAraclar(object araclar);
    }

}
