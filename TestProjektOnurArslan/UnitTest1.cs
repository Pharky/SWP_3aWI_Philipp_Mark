using ConsoleApp1;
namespace TestProjektOnurArslan
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void jo2()
        {
            Hallo hallo = new Hallo();
            Assert.That(Hallo.jo);
        }
    }
}