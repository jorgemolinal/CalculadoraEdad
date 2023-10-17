using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCalculaEdad
{
    public class UserModel
    {
        public string nombre { get; set; }
        public DateTime edad { get; set; }

        public EdadModel calcularEdad(DateTime fechaAnterior, DateTime fechaFutura)
        {
            int edadAnios = fechaFutura.Year - fechaAnterior.Year;
            int edadMeses = fechaFutura.Month - fechaAnterior.Month;
            int edadDias = fechaFutura.Day - fechaAnterior.Day;
            if (edadDias < 0)
            {
                edadMeses--;
                int ultimoDiaMesPrevio = DateTime.DaysInMonth(fechaFutura.Year, fechaFutura.Month - 1);
                edadDias += ultimoDiaMesPrevio;
            }
            if (edadMeses < 0)
            {
                edadAnios--;
                edadMeses += 12;
            }
            EdadModel edad = new EdadModel(edadAnios, edadMeses, edadDias);
            return edad;
        }

    }
}
