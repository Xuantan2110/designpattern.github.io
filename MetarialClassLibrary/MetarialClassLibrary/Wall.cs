using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetarialClassLibrary
{
    public class Wall : Material
    {
        public Wall()
        {
            Discription = "Wall material";
        }
        public override double CalculatorVolume()
        {
            return 0;
        }

        public override string GetDiscription()
        {
            return Discription;
        }
    }
}
