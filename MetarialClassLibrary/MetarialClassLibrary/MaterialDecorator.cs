using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetarialClassLibrary
{
    public class MaterialDecorator : Material
    {
        protected Material material;
        public double Volume;
        public MaterialDecorator(Material material)
        {
            this.material = material;
        }

        public override double CalculatorVolume()
        {
            return material.CalculatorVolume();
        }

        public override string GetDiscription()
        {
            return material.Discription;
        }
    }
}
