namespace OtoGaleriApp.Interfaces
{
    public interface IKisiGuncelleView
    {
        int SecilenKisiId { get; }
        string Ad { get; }
        string Soyad { get; }
        string TC { get; }
        string Telefon { get; }

        void ShowMessage(string message);
        void CloseForm();
        void SetKisiler(object kisiler);
        void SetFormFields(string ad, string soyad, string tc, string telefon);
    }
}
