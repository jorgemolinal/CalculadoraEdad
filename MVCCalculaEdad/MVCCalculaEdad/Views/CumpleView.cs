using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCalculaEdad.Views
{
    public class CumpleView
    {
        private string name;

        public int ShowMenu()
        {
            Console.WriteLine("[1] edad en dd/mm/aaaa");
            Console.WriteLine("[2] edad en aaaa/mm/dd");
            Console.WriteLine("[0] volver");
            string option = Console.ReadLine();

            if (int.TryParse(option, out int opcion))
            {
                return opcion;
            }

            Console.WriteLine("Entrada incorrecta");
            return ShowMenu();
        }

        public DateTime ShowCalcularEdadEU(string name)
        {
            Console.WriteLine($"Hola {name}, cuál es tu fecha de nacimiento (dd/mm/aaaa)?: ");
            string fecha = Console.ReadLine();

            if (DateTime.TryParse(fecha, out DateTime date))
            {
                return date;
            }
            Console.WriteLine("Entrada incorrecta.");
            return ShowCalcularEdadEU(name);
        }

        public DateTime ShowCalcularEdadAM(string name)
        {
            Console.WriteLine($"Hola {name}, cuál es tu fecha de nacimiento (aaaa/mm/dd)?: ");
            string fecha = Console.ReadLine();

            if (DateTime.TryParse(fecha, out DateTime date))
            {
                return date;
            }
            Console.WriteLine("Entrada incorrecta.");
            return ShowCalcularEdadEU(name);
        }

        public void ShowEdad(string name, int anos, int meses, int dias)
        {
            Console.WriteLine($"Hola {name}, tienes {anos} años, {meses} meses y {dias} dias");
        }


    }
}
