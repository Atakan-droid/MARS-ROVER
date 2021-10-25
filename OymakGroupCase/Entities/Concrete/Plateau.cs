using OymakGroupCase.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OymakGroupCase.Entities.Concrete
{
    public class Plateau:IPlateau
    {   
        //props
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
