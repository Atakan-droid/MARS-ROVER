using OymakGroupCase.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OymakGroupCase.Business.Abstract
{
    public interface IPlateauService
    {
        bool IsPositionCorrect(Plateau plateau,Position position);
    }
}
