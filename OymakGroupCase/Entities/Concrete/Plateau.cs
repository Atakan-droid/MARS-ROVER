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
        public int _Width { get; set; }
        public int _Height { get; set; }

        public Plateau(int Width,int Height)
        {
            _Width = Width;
            _Height = Height;
        }
    }
}
