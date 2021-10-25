using OymakGroupCase.Business.Concrete;
using OymakGroupCase.Entities.Abstract;
using OymakGroupCase.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OymakGroupCase.Entities.Concrete
{
    public class Rover:IRover
    {
        public Plateau plateau { get; set; }
        public Position position { get; set; }
        public Directions directions = RoverManager.directions;

        public Rover(Plateau _plateau,Position _position,Directions _directions)
        {
            plateau = _plateau;
            position = _position;
            directions = _directions;
        }
    }
}
