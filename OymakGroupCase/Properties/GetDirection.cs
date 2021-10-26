using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OymakGroupCase.Properties
{
    public static class GetDirection
    {
        public static Directions setDirection(string direction)
        {
            Directions _directions = Directions.North;
            switch (direction)
            {
                case "North":
                    _directions = Directions.North;
                    break;
                case "East":
                    _directions = Directions.East;
                    break;
                case "South":
                    _directions = Directions.South;
                    break;
                case "West":
                    _directions = Directions.West;
                    break;

            }
            return _directions;
        }
    }
}

