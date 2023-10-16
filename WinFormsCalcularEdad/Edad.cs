using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraEdadC_
{
    internal class Edad
    {
        public int edadAnios;
        public int edadMeses;
        public int edadDias;

        public Edad()
        {
        }

        public Edad(int edadAnios_, int edadMeses_, int edadDias_)
        {
            edadAnios = edadAnios_;
            edadMeses = edadMeses_;
            edadDias = edadDias_;
        }
    }
}
