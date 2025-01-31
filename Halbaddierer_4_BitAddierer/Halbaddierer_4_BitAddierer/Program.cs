using System;

class Program
{
    static (int Sum, int Carry) HalfAdder(int A, int B)
    {
        int sum = A ^ B;
        int carry = A & B;
        return (sum, carry);
    }

    static void Main()
    {
        int[][] testCases = {
            new int[] { 0, 0 },
            new int[] { 0, 1 },
            new int[] { 1, 0 },
            new int[] { 1, 1 }
        };

        Console.WriteLine("A  B  | Sum  Carry");
        Console.WriteLine("------------------");

        foreach (var test in testCases)
        {
            int A = test[0], B = test[1];
            var result = HalfAdder(A, B);
            Console.WriteLine($"{A}  {B}  |  {result.Sum}    {result.Carry}");
        }
    }
}
