using System;
using System.Collections.Generic;
using System.Linq;

namespace Paragraph_5_Pruefung;

public class Fahrzeug
{
    public int Sitzplaetze { get; private set; }
    public DateTime Fabrikationsdatum { get; private set; }
    public double MaximaleGeschwindigkeit { get; private set; }

    public Fahrzeug(int sitzplaetze, DateTime fabrikationsdatum, double maximaleGeschwindigkeit)
    {
        Sitzplaetze = sitzplaetze;
        Fabrikationsdatum = fabrikationsdatum;
        MaximaleGeschwindigkeit = maximaleGeschwindigkeit;
    }

    public int AlterInMonaten()
    {
        var heute = DateTime.Now;
        return (heute.Year - Fabrikationsdatum.Year) * 12 + heute.Month - Fabrikationsdatum.Month;
    }
}