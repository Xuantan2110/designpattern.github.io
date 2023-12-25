using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetarialClassLibrary
{
    public abstract class Material
    {
        public string Discription { get; set; }
        public abstract string GetDiscription();
        public abstract double CalculatorVolume();
    }
}
