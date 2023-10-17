using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCalculaEdad
{
    public class PlanetasView
    {

        private string name;
        public int ShowMenu()
        {
            Console.WriteLine("[1] edades en Mercurio");
            Console.WriteLine("[2] edades en Pluton");
            Console.WriteLine("[3] edades en Venus");
            Console.WriteLine("[4] edades en Marte");
            Console.WriteLine("[5] edades en Saturno");
            Console.WriteLine("[6] edades en Urano");
            Console.WriteLine("[0] Volver");

            string option = Console.ReadLine();

            if (int.TryParse(option, out int opcion))
            {
                return opcion;
            }

            Console.WriteLine("Entrada incorrecta");
            return ShowMenu();
        }

        public DateTime ShowCalcularEdad(string name)
        {
            Console.WriteLine($"Hola {name}, cuál es tu fecha de nacimiento (dd/mm/aaaa)?: ");
            string fecha = Console.ReadLine();

            if (DateTime.TryParse(fecha, out DateTime date))
            {
                return date;
            }
            Console.WriteLine("Entrada incorrecta.");
            return ShowCalcularEdad(name);
        }

        public void ShowEdad(int anos, string planeta)
        {
            Console.WriteLine($"Hola, tienes {anos} años en {planeta}");
        }

       
    }
}
