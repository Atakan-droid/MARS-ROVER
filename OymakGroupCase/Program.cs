using OymakGroupCase.Business.Concrete;
using OymakGroupCase.Entities.Concrete;
using System;

namespace OymakGroupCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Position position = new Position(1,3);
            Plateau plateau = new Plateau(5,5);
            Rover rover = new Rover(plateau,position,Properties.Directions.East);
            Console.WriteLine(RoverManager.CurrentPosition(rover)); 
        }
    }
}
