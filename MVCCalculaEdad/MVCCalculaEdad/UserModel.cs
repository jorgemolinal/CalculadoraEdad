using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCalculaEdad
{
    public class UserModel
    {
        public string name { get; set; }
        public DateTime fechaNacimiento { get; set; }

        public EdadModel calcularEdad()
        {
            DateTime actual = DateTime.Now;
            EdadModel edad = new EdadModel()
            {
                edadAnios = actual.Year - fechaNacimiento.Year,
                edadMeses = actual.Year - fechaNacimiento.Month,
                edadDias = actual.Day - fechaNacimiento.Day,
            };

            if (edad.edadDias < 0)
            {
                edad.edadMeses--;
                int ultimoDiaMesPrevio = DateTime.DaysInMonth(actual.Year, actual.Month - 1);
                edad.edadDias += ultimoDiaMesPrevio;
            }
            if (edad.edadMeses < 0)
            {
                edad.edadAnios--;
                edad.edadMeses += 12;
            }

            return edad;

        }

    }
}
