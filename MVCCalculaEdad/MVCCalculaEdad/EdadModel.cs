using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCalculaEdad
{
    public class EdadModel
    {
        public int edadAnios;
        public int edadMeses;
        public int edadDias;

        public EdadModel()
        {
        }

        public EdadModel(int edadAnios_, int edadMeses_, int edadDias_)
        {
            edadAnios = edadAnios_;
            edadMeses = edadMeses_;
            edadDias = edadDias_;
        }
    }
}