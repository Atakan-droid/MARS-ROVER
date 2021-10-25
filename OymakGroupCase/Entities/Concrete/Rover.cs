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
        public Plateau _plateau { get; set; }
        public Position _position { get; set; }
        public Directions  _directions { get; set; }

        public Rover(Plateau plateau,Position position,Directions directions)
        {
            _plateau = plateau;
            _position = position;
            _directions = directions;
        }
    }
}
