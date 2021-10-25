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
    }
}
