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
        public int Min_Height { get; set; }
        public int Min_Width { get; set; }


        public Plateau(int _Width,int _Height)
        {
            Width = _Width;
            Height = _Height;
            Min_Height = 0;
            Min_Width = 0;
        }
    }
}
