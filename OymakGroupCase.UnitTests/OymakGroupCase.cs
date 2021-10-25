using Microsoft.VisualStudio.TestTools.UnitTesting;
using OymakGroupCase.Entities.Concrete;

namespace OymakGroupCase.UnitTests
{
    [TestClass]
    public class OymakGroupCase
    {
        [TestMethod]
        public void ProgramCs()
        {
            Position position = new Position(5,5);

            System.Console.WriteLine(position);

            Plateau plateau = new Plateau(1,3);

            System.Console.WriteLine(plateau);
            Rover rover = new Rover(plateau,position,Properties.Directions.North);
            System.Console.WriteLine(rover);
        }
    }
}
