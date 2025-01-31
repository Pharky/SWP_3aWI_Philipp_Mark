using NUnit.Framework;

[TestFixture]
public class HalfAdderTests
{
    private (int Sum, int Carry) HalfAdder(int A, int B)
    {
        int sum = A ^ B;
        int carry = A & B;
        return (sum, carry);
    }

    [TestCase(0, 0, 0, 0)]
    [TestCase(0, 1, 1, 0)]
    [TestCase(1, 0, 1, 0)]
    [TestCase(1, 1, 0, 1)]
    public void TestHalfAdder(int A, int B, int expectedSum, int expectedCarry)
    {
        var result = HalfAdder(A, B);
        Assert.AreEqual(expectedSum, result.Sum);
        Assert.AreEqual(expectedCarry, result.Carry);
    }
}
