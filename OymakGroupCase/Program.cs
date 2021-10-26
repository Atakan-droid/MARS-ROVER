using OymakGroupCase.Business.Concrete;
using OymakGroupCase.Entities.Concrete;
using System;

namespace OymakGroupCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Position position = new Position(1,2);
            Plateau plateau = new Plateau(5,5);
            Rover rover = new Rover(plateau,position,Properties.Directions.North);
            RoverManager roverManager = new RoverManager(rover);
            roverManager.Moving("LMLMLMLMM");
       
            Console.WriteLine(roverManager.CurrentPosition());

            var roversPosition=roverManager.CurrentPosition().Split(" ");
            Position position1 = new Position(Int32.Parse(roversPosition[0]),Int32.Parse(roversPosition[1]));

            var newDirection=roverManager.setDirection(roversPosition[2]);
            Rover rover1 = new Rover(plateau,position1,newDirection);
            roverManager.NewPosition(rover1,3,3,Properties.Directions.East);
            roverManager.Moving("MMRMMRMRRM");
                Console.WriteLine(roverManager.CurrentPosition());

        }
    }
}
