using OymakGroupCase.Business.Abstract;
using OymakGroupCase.Entities.Concrete;
using OymakGroupCase.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OymakGroupCase.Business.Concrete
{
    public static class RoverManager 
    {

        public static readonly Directions directions = Directions.North;
        public static string CurrentPosition(Rover rover)
        {
            return rover.position.x + " " + rover.position.y + " " + rover.directions;
        }

        public static Directions IsCorrectDirection(Rover rover)
        {
            Directions direction;
            try
            {
                direction = rover.directions;
            }
            catch (Exception)
            {
                direction = Directions.North;
                Console.WriteLine("Geçerli Yön değil...");
            }
            return direction;
        }

        public static bool Move(Rover rover)
        {
            if (!rover.plateau.IsPositionCorrect(rover.position))
            {
                return false;
            }
            switch (directions)
            {
                case Directions.North:
                    rover.position.y += 1;
                    break;
                case Directions.East:
                    rover.position.x += 1;
                    break;
                case Directions.South:
                    rover.position.y -= 1;
                    break;
                case Directions.West:
                    rover.position.x -= 1;
                    break;
            }
            return true;
        }
    }
}
