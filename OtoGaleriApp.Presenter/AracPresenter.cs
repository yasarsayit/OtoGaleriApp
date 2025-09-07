using OtoGaleriApp.DataAccess;
using OtoGaleriApp.Model;
using System.Linq;

public class AracPresenter
{
    private readonly IAracListeleView _view;

    public AracPresenter(IAracListeleView view)
    {
        _view = view;
    }

    public void Yukle()
    {
        using (var context = new GaleriContext())
        {
            var araclar = context.Araclar
                .Select(a => new { a.Id, a.Marka, a.Model, a.Plaka, a.Yil, a.Durum })
                .ToList();

            _view.SetAraclar(araclar);
        }
    }

    public void Filtrele()
    {
        using (var context = new GaleriContext())
        {
            var query = context.Araclar.AsQueryable();

            if (!string.IsNullOrWhiteSpace(_view.FiltreMarka))
                query = query.Where(a => a.Marka.Contains(_view.FiltreMarka));

            if (!string.IsNullOrWhiteSpace(_view.FiltreModel))
                query = query.Where(a => a.Model.Contains(_view.FiltreModel));

            if (!string.IsNullOrWhiteSpace(_view.FiltrePlaka))
                query = query.Where(a => a.Plaka.Contains(_view.FiltrePlaka));

            if (!string.IsNullOrWhiteSpace(_view.FiltreYil) && int.TryParse(_view.FiltreYil, out int yil))
                query = query.Where(a => a.Yil == yil);

            if (_view.FiltreDurum != "Hepsi")
            {
                bool durumFiltre = _view.FiltreDurum == "Satışta";
                query = query.Where(a => a.Durum == durumFiltre);
            }

            _view.SetAraclar(query.Select(a => new
            {
                a.Id,
                a.Marka,
                a.Model,
                a.Plaka,
                a.Yil,
                a.Durum
            }).ToList());
        }
    }
}
