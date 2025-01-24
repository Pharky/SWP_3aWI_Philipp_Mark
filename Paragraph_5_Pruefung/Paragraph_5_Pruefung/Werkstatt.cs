using System;
using System.Collections.Generic;
using System.Linq;

namespace Paragraph_5_Pruefung;

public class Werkstatt
{
    private readonly List<Auto> _autos = new List<Auto>();

    public int AlterDesAutosInMonaten(Auto auto)
    {
        if (auto == null) throw new ArgumentNullException(nameof(auto));
        return auto.AlterInMonaten();
    }

    public void AutoHinzufuegen(Auto auto)
    {
        _autos.Add(auto);
    }

    public bool AutoEntfernen(Auto auto)
    {
        return _autos.Remove(auto);
    }

    public int AnzahlAutosInWerkstatt()
    {
        return _autos.Count;
    }

    public double DurchschnittlichesAlterInMonaten()
    {
        if (!_autos.Any()) return 0;
        return _autos.Average(auto => auto.AlterInMonaten());
    }
}