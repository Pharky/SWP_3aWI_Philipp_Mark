using System.Numerics;

Console.WriteLine("Welche Operation willst du benutzen?");
Console.WriteLine("1.Multiplizieren");
Console.WriteLine("2.Dividieren");
Console.WriteLine("3.Addieren");
Console.WriteLine("4.Potenzieren");
Console.WriteLine("5.Wurzelziehen");
Console.WriteLine("6.Fakultät");
Console.WriteLine("7.Invertieren");

try
{
    int input = int.Parse(Console.ReadLine());
    MathOperations ops = new MathOperations();
    switch (input)
    {
        case 1:
            ops.multiply();
            break;
        case 2:
            Console.WriteLine("Gib deinen Dividend ein: ");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Gib deinen Divisor ein: ");
            int divisor = int.Parse(Console.ReadLine());
            Console.WriteLine("Dein Ergebnis lautet: " + ops.divide(dividend, divisor));
            break;
        case 3:
            Console.WriteLine("Gib deine 1.Zahl ein: ");
            int zahl1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Gib deine 2.Zahl ein: ");
            int zahl2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dein Ergebnis lautet: " + ops.addition(zahl1, zahl2));
            break;
        case 4:
            Console.WriteLine("Gib deine Hochzahl ein: ");
            int potenz = int.Parse(Console.ReadLine());
            Console.WriteLine("Gib deine Base ein: ");
            int basis = int.Parse(Console.ReadLine());
            Console.WriteLine("Dein Ergebnis lautet: " + ops.potenzieren(potenz, basis));
            break;
        case 5:
            Console.WriteLine("Gib deine Zahl ein: ");
            int wurzelZahl = int.Parse(Console.ReadLine());
            Console.WriteLine("Dein Ergebnis lautet: " + Math.Sqrt(wurzelZahl));
            break;
        case 6:
            Console.WriteLine("Gib deine Zahl um zu fakultieren ein: ");
            int fakultaetZahl = int.Parse(Console.ReadLine());
            Console.WriteLine("Dein Ergebnis lautet: " + ops.fakultaet(fakultaetZahl));
            break;
        case 7:
            Console.WriteLine("Gib deine Zahl ein: ");
            int invertZahl = int.Parse(Console.ReadLine());
            Console.WriteLine("Dein Ergebnis lautet: " + ops.invertieren(invertZahl));
            break;
    }
} catch
{
    Console.WriteLine("Ungültige Zahl!");
}
class MathOperations
{
    public void multiply()
    {
        Console.WriteLine("Gib deine 1. Zahl ein: ");
        int inputZahl1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Gib deine 2.Zahl ein: ");
        int inputZahl2 = int.Parse(Console.ReadLine());
        int ergebnis = inputZahl1 * inputZahl2;
        Console.WriteLine("Das Ergebnis lautet: " + ergebnis);
        
    }
    public long fakultaet(int zahl)
    {
        long ergebnis = 1;
        for (int i = 1; i <= zahl; i++)
        {
            ergebnis *= i;
        }
        return ergebnis;
    }
    public int divide(int x, int y)
    {
        int ergebnis = x / y;
        return ergebnis;
    }
    public int addition(int x, int y)
    {
        return x + y;
    }
    public int potenzieren(int amount, int zahl)
    {
        int ergebnis = 1;
        for (int i = 0; i < amount; i++) 
        { 
            ergebnis *= zahl;
        }
        return ergebnis;
    }
    public double invertieren(int zahl)
    {
        return 1/zahl;
    }   
}