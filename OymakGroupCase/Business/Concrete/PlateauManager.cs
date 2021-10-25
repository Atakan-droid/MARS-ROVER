using OymakGroupCase.Business.Abstract;
using OymakGroupCase.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OymakGroupCase.Business.Concrete
{
    public static class PlateauManager 
    {
        public static bool IsPositionCorrect(this Plateau plateau, Position position)
        {
            return plateau.Min_Width <= position.x && position.x <= plateau.Width && plateau.Min_Height <= position.y && position.y <= plateau.Height;
        }
    }
}
