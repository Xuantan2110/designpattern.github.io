using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetarialClassLibrary
{
    public class Metal : Material
    {
        public Metal()
        {
            Discription = "Metal material";
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
