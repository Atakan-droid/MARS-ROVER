using Microsoft.VisualStudio.TestTools.UnitTesting;
using OymakGroupCase.Business.Abstract;
using OymakGroupCase.Business.Concrete;
using OymakGroupCase.Entities.Concrete;
using OymakGroupCase.Properties;
using System;

namespace OymakGroupCase.UnitTests
{
    [TestClass]
    public class OymakGroupCase
    {
        
        [TestMethod]
        public void Given_5_5_plateau_and_1_2_positionIsCorrect()
        {
            Position position = new Position(1, 2);
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(plateau, position, Properties.Directions.North);
            IsRoverWorks ýsRoverWorks = new IsRoverWorks(new RoverManager(rover));
            var output = ýsRoverWorks.IsOutputCorrect();
            Assert.AreEqual("1 3 North",output);

        }

        [TestMethod]
        public void Given_5_5_plateau_and_3_3_positionIsCorrect()
        {
            Position position = new Position(3, 3);
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(plateau, position, Properties.Directions.East);
            IsRoverWorks ýsRoverWorks = new IsRoverWorks(new RoverManager(rover));
            var output = ýsRoverWorks.NextOutputCorrect();
            Assert.AreEqual("5 1 East", output);

        }

    }
    public interface IisRoverWorks
    {
        string IsOutputCorrect();
        string NextOutputCorrect();
        bool IsInputCorrect(string input);

    }
    public class IsRoverWorks:IisRoverWorks 
    {
        public IRoverService _roverService;
        public IsRoverWorks(IRoverService roverService)
        {
            _roverService = roverService;
        }

        public bool IsInputCorrect(string input)
        {
            if (_roverService.IsCorrectDirection())
            {
                return true;
            }
            return false;
        }

        public string IsOutputCorrect()
        {
            _roverService.Moving("LMLMLMLMM");
            return _roverService.CurrentPosition();
        }

        public string NextOutputCorrect()
        {
            _roverService.Moving("MMRMMRMRRM");
            return _roverService.CurrentPosition();
        }
    }
}
