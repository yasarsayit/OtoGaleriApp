using System.Collections.Generic;

namespace OtoGaleriApp.Interfaces
{
    public interface IKisiSilView
    {
        void SetKisiler(List<object> kisiler);
        int SecilenKisiId { get; }
    }
}

