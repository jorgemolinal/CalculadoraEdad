using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCalculaEdad
{
    public class PlanetaModel
    {

        public DateTime edad { get; set; }

        public int CalculadoraEdadPlaneta(DateTime fechaFutura, string Planeta)
        {
            UserModel user = new UserModel();
            DateTime fechaAnterior = DateTime.Now;

            EdadModel edadTierra = user.calcularEdad(fechaFutura, fechaAnterior);

            int diasTierra = edadTierra.edadAnios * 365 + edadTierra.edadMeses * 30 + edadTierra.edadDias;
            int diasPlaneta = 0;
            if (Planeta == "mercurio")
            {
                diasPlaneta = 88;
            }
            else if (Planeta == "jupiter")
            {
                diasPlaneta = 4329;
            }
            else if (Planeta == "marte")
            {
                diasPlaneta = 687;
            }
            else if (Planeta == "venus")
            {
                diasPlaneta = 225;
            }
            else if (Planeta == "saturno")
            {
                diasPlaneta = 10753;
            }
            else if (Planeta == "urano")
            {
                diasPlaneta = 30664;
            }

            int edadPlaneta = diasTierra / diasPlaneta;
            return edadPlaneta;
        }

        public int llamadaPlaneta(string planeta, DateTime fechaNacimiento)
        {
            int anos = CalculadoraEdadPlaneta(fechaNacimiento, planeta);
            return anos;
        }

    }
}
