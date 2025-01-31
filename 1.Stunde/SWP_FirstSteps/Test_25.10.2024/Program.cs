Console.WriteLine("Geben Sie eine ganze Zahl ein");
string ganzZahlInput = Console.ReadLine();
MatheOperation operation = new MatheOperation();
if(int.TryParse(ganzZahlInput, out var ganzZahl))
{
    Console.WriteLine("Sie haben eine GanzZahl eingegeben. Wählen Sie Ihre Matheoperation aus:\n1)Addition\n2)Multiplikation\n3)Division\n4)Fakultät\n5)Wurzel ziehen");
    string auswahlZahl = Console.ReadLine();
    if(int.TryParse(auswahlZahl, out var auswahlZahlInt))
    {
        switch(auswahlZahlInt)
        {
            case 1: 
                operation.Addition(ganzZahl);
                break;
            case 2:
                operation.Multiplikation(ganzZahl);
                break;
            case 3:
                operation.Division(ganzZahl);
                break;
            case 4:
                operation.fakultaet(ganzZahl);
                break;
            case 5:
                double wurzelErgebnis = Math.Sqrt(ganzZahl);
                Console.WriteLine("Ihre Zahl lautet:" + wurzelErgebnis);
                break;
        }
    }
} else
{
    Console.WriteLine("Sie haben eine Zeichenkette eingegeben. Was wollen Sie mit der machen\n1)Selbstlaute entfernen\n2)Die Zeichenkette umkehren\n3)Die Anzahl der Zeichen angeben");
    string textAuswahl = Console.ReadLine();
    if(int.TryParse(textAuswahl, out var textAuswahlInt))
    {
        switch(textAuswahlInt)
        {
            case 1:
                operation.deleteVocals(ganzZahlInput);
                break;
            case 2:
                string umkehrung = ganzZahlInput.Reverse().ToString();
                Console.WriteLine("Die umgekehrte Zeichenkette ist: " + umkehrung);
                break;
            case 3:
                int textLänge = ganzZahlInput.Length;
                Console.WriteLine("Die Länge des Textes ist: " + textLänge);
                break;
        }
    }
}
class MatheOperation
{
    public void Addition(int Zahl1)
    {
        string ganzZahlInput2 = AbfrageZahl2("Addieren");
        if(int.TryParse(ganzZahlInput2 , out var ganzZahl))
        {
            int summe = Zahl1 + ganzZahl;
            Console.WriteLine("Ihre Zahl lautet: " + summe);
        }
    }
    public void Multiplikation(int Zahl1)
    {
        string ganzZahlInput2 = AbfrageZahl2("Multiplizieren");
        if(int.TryParse(ganzZahlInput2, out var ganzZahl))
        {
            int multiplikation = Zahl1 * ganzZahl;
            Console.WriteLine("Ihre Zahl lautet: " + multiplikation);
        }
    }
    public void Division(int Zahl1)
    {
        string ganzZahlInput2 = AbfrageZahl2("Dividieren");
        if (int.TryParse(ganzZahlInput2, out var ganzZahl))
        {
            int division = Zahl1 / ganzZahl;
            Console.WriteLine("Ihre Zahl lautet: " + division);
        }
    }
    public void fakultaet(int Zahl1)
    {
        long ergebnis = 1;
        for (int i = 1; i <= Zahl1; i++)
        {
            ergebnis *= i;
        }
        Console.WriteLine("Ihre Zahl lautet: " + ergebnis);
    }
    string AbfrageZahl2(string operation)
    {
        Console.WriteLine("Geben Sie Ihre 2.Zahl ein zum "+operation);
        string ganzZahlInput2 = Console.ReadLine();
        return ganzZahlInput2;
    }
    public void deleteVocals(string inputText)
    {
        string inputToLower = inputText.ToLower();
        string[] charsToRemove = { "a", "e", "i", "o", "u" };
        foreach (var i in charsToRemove)
        {
            inputToLower = inputToLower.Replace(i, "");
        }
        Console.WriteLine("Ihre neue Zeichenkette ist " + inputToLower);
    }
}
//1) Was ist eine Kontrollstruktur? Welche Kontrollstrukturen kennen Sie in C#
//    Dadurch kann ein Programm auf bestimmte Eingaben reagieren, Entscheidungen treffen und verschiedene Abläufe durchlaufen
//    switch()
//    if else
//    if
//    else
//    try catch
//    for loops
//    while loops
//2) Was bedeutet der Begriff Clean Code in der Softwareentwicklung? Welche Clean-Code-Prinzipien kennen Sie?
//    Clean Code ist da damit andere Entwickler den Code besser verstehen kann und damit keine errors im Programm verursacht werden
//    Dont Repeat Yourself
//    nicht zu kompliziert alles in etwas reinstecken sondern kleine funktionen für bestimmte Aufgaben machen
//    debuggen gehört auch teilweise dazu um zu schauen ob es funktioniert
//    sinnvole variablenamen
//    kleine funktionen für operationen
//    keine leerzeilen bzw zeichen
//    keine error beim umwandeln von datentypen
//3) Was ist der Unterschied zwischen der Methode Parse und TryParse in C#? Aus was müssen Sie bei Verweung der Methode Parse achten?
//tryparse gibt einen "True" oder "False" und versucht es aus und Parse versucht es gleich umzuwandeln egal ob es nicht funktionieren würde oder nd
//4) Was genau macht folgender C#-Code: int myInt = 42;
//Eine Variable vom Datentyp integer/ganzzahl mit einem Namen myInt die Zahl 42 festlegen