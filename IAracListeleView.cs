using System;

// Interfaces/IAracListeleView.cs
public interface IAracListeleView
{
    string FiltreMarka { get; }
    string FiltreModel { get; }
    string FiltrePlaka { get; }
    string FiltreYil { get; }
    string FiltreDurum { get; }

    void SetAraclar(object araclar);
}

