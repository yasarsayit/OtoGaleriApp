namespace OtoGaleriApp.Interfaces
{
    public interface ISatisSilView
    {
        int SecilenSatisId { get; }
        void ShowMessage(string message);
        void CloseForm();
        void SetSatislar(object satislar);
    }
}
