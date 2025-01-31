using System;
using System.Collections.Generic;

namespace SchulVerwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Schule initialisieren
            Schule meineSchule = new Schule();

            // Sch�ler hinzuf�gen
            meineSchule.SchuelerListe.Add(new Schueler { RaumName = "Anna", Geschlecht = "weiblich", Geburtsdatum = new DateTime(2008, 5, 21), KlassenName = "3bWi" });
            meineSchule.SchuelerListe.Add(new Schueler { RaumName = "Max", Geschlecht = "m�nnlich", Geburtsdatum = new DateTime(2007, 9, 12), KlassenName = "3bWi" });

            // Klassenr�ume hinzuf�gen
            meineSchule.KlassenzimmerListe.Add(new Klassenzimmer { Name = "Raum 101", AnzahlPlaetze = 30, HatCynap = true });
            meineSchule.KlassenzimmerListe.Add(new Klassenzimmer { Name = "Raum 102", AnzahlPlaetze = 20, HatCynap = false });

            // Methoden testen
            Console.WriteLine($"Anzahl der Sch�ler: {meineSchule.AnzahlSchueler()}");
            var geschlechter = meineSchule.AnzahlGeschlechter();
            Console.WriteLine($"Anzahl der m�nnlichen Sch�ler: {geschlechter.Maennlich}");
            Console.WriteLine($"Anzahl der weiblichen Sch�ler: {geschlechter.Weiblich}");
            Console.WriteLine($"Durchschnittsalter der Sch�ler: {meineSchule.Durchschnittsalter()} Jahre");
            Console.WriteLine($"Anzahl der Klassenr�ume: {meineSchule.AnzahlKlassenzimmer()}");

            // �berpr�fen, ob ein Raum eine Klasse unterrichten kann
            Console.WriteLine($"Kann die Klasse '3bWi' in Raum 101 unterrichtet werden? {meineSchule.KannKlasseUnterrichten("Raum 101", "3bWi")}");
        }
    }
}
