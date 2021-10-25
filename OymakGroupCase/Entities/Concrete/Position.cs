using OymakGroupCase.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OymakGroupCase.Entities.Concrete
{
    public class Position:IPosition
    {
        //props
        public int x { get; set; }
        public int y { get; set; }

        public Position(int _x,int _y)
        {
            _x = x;
            _y = y;
        }
    }
}
