using Microsoft.VisualStudio.TestTools.UnitTesting;
using OymakGroupCase.Business.Abstract;
using OymakGroupCase.Business.Concrete;
using OymakGroupCase.Entities.Concrete;
using System;

namespace OymakGroupCase.UnitTests
{
    [TestClass]
    public class OymakGroupCase
    {
        static Position position = new Position(1, 2);
        static Plateau plateau = new Plateau(5, 5);
        Rover rover = new Rover(plateau, position, Properties.Directions.North);
        [TestMethod]
        public void Given_5_5_plateau_and_1_2_positionIsCorrect()
        {
            
            IsRoverWorks ýsRoverWorks = new IsRoverWorks(new RoverManager(rover));
            var output = ýsRoverWorks.IsOutputCorrect();
            Assert.AreEqual("1 3 North",output);

        }


    }
    public interface IisRoverWorks
    {
        string IsOutputCorrect();
        bool IsInputCorrect(string input);
    }
    class IsRoverWorks:IisRoverWorks
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
    }
}
