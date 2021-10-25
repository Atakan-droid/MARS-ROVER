using OymakGroupCase.Entities.Concrete;
using OymakGroupCase.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OymakGroupCase.Business.Abstract
{
    public interface IRoverService
    {
        string CurrentPosition();
        bool Move();
        Directions IsCorrectDirection();
        void Moving(string command);
    }
}
