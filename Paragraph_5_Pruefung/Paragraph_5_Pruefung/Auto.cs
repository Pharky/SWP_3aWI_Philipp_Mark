using System;
using System.Collections.Generic;
using System.Linq;

namespace Paragraph_5_Pruefung;

public class Auto : Fahrzeug
{
    public string Antriebsart { get; private set; }

    public Auto(int sitzplaetze, DateTime fabrikationsdatum, double maximaleGeschwindigkeit, string antriebsart)
        : base(sitzplaetze, fabrikationsdatum, maximaleGeschwindigkeit)
    {
        if (!new[] { "Benzin", "Diesel", "Elektro" }.Contains(antriebsart, StringComparer.OrdinalIgnoreCase))
            throw new ArgumentException("Antriebsart muss entweder 'Benzin', 'Diesel' oder 'Elektro' sein.");
        Antriebsart = antriebsart;  
    }
}