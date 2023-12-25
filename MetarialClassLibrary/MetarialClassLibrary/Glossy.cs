using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetarialClassLibrary
{
    public class Glossy : MaterialDecorator
    {
        public Glossy(Material material) : base(material)
        {
            Discription = "Glossy paint";
        }
        public override string GetDiscription()
        {
            return string.Format("{0}, {1}", material.GetDiscription(),Discription);
        }
        public override double CalculatorVolume()
        {
            return material.CalculatorVolume() + 0.5;
        }
    }
}
