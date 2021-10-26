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
    public class RoverManager : IRoverService
    {
        public  Rover _rover;
        public RoverManager(Rover rover)
        {
            _rover = rover;
        }
        public  Directions directions = Directions.North;
        public string CurrentPosition()
        {
            return _rover.position.x + " " + _rover.position.y + " " + _rover.directions;
        }

        public bool IsCorrectDirection()
        {
            Directions direction;
            try
            {
                direction = _rover.directions;
                return true;
            }
            catch (Exception)
            {
                direction = Directions.North;
                Console.WriteLine("Geçerli Yön değil...");
                return false;
            }
        }

        public bool Move()
        {
            if (!_rover.plateau.IsPositionCorrect(_rover.position))
            {
                return false;
            }
            switch (directions)
            {
                case Directions.North:
                    _rover.position.y += 1;
                    break;
                case Directions.East:
                    _rover.position.x += 1;
                    break;
                case Directions.South:
                    _rover.position.y -= 1;
                    break;
                case Directions.West:
                    _rover.position.x -= 1;
                    break;
            }
            return true;
        }

        public void Moving(string command)
        {
            for (int i = 0; i < command.Length; i++)
            {
                if ('L' == command[i])
                    if ((int)directions - 1 < (int)Directions.North)
                    {
                        directions = Directions.West;
                    }
                    else
                    {
                        directions = (Directions)(int)directions - 1;
                    }
                else if ('R' == command[i])
                    if ((int)directions + 1 > (int)Directions.North)
                    {
                        directions = Directions.West;
                    }
                    else
                    {
                        directions = (Directions)(int)directions + 1;
                    }
                else if ('M' == command[i])
                {
                    if (!Move())
                        Console.WriteLine("Hatalı giriş...");
                }
                else
                {
                    Console.WriteLine("Yanlış girdi...");
                }
            }
        }

        //new position settling
        public void NewPosition(int x, int y, Directions direction)
        {
            _rover.position.x = x;
            _rover.position.y = y;
            directions = direction;
        }

        public Directions setDirection(string direction)
        {
            Directions _directions=Directions.North;
            switch (direction)
            {
                case "North":
                    _directions=Directions.North;
                    break;
                case "East":
                    _directions=Directions.East;
                    break;
                case "South":
                    _directions= Directions.South;
                    break;
                case "West":
                    _directions=Directions.West;
                    break;

            }
            return _directions;
        }
    }
}
