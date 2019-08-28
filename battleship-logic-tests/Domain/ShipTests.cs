using NUnit.Framework;
using battleship_logic.Domain;

namespace battleship_logic_tests.Domain
{
    public class ShipTests
    {
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var expectedValue = 3;
            var ship = new Ship(expectedValue);
            Assert.AreEqual(expectedValue, ship.Size);
        }
    }
}