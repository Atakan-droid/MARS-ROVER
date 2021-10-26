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
        static Plateau plateau = new Plateau(5, 5);
        [TestMethod]
        public void Given_5_5_plateau_and_1_2_positionIsCorrect()
        {        
            Rover rover = new Rover(plateau, new Position(1,2),Directions.North);
            IsRoverWorks ýsRoverWorks = new IsRoverWorks(new RoverManager(rover));
            var input = "LMLMLMLMM";
            var output = ýsRoverWorks.IsOutputCorrect(input);
            Assert.AreEqual("1 3 North",output);

        }

        [TestMethod]
        public void Given_5_5_plateau_and_3_3_positionIsCorrect()
        {
            Rover rover = new Rover(plateau, new Position(3,3),Directions.East);
            IsRoverWorks ýsRoverWorks = new IsRoverWorks(new RoverManager(rover));
            var input = "MMRMMRMRRM";
            var output = ýsRoverWorks.IsOutputCorrect(input);
            Assert.AreEqual("5 1 East", output);

        }

    }
    public interface IisRoverWorks
    {
        string IsOutputCorrect(string input);
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

        public string IsOutputCorrect(string input)
        {
            _roverService.Moving(input);
            return _roverService.CurrentPosition();
        }

    }
}
