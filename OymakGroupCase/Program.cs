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
        }
    }
}
