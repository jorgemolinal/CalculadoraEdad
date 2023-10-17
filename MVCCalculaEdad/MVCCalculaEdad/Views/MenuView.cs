using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCalculaEdad
{
    public class MenuView
    {
        private string name;
        public void ShowWelcome()
        {
            Console.WriteLine("Bienvenido");
        }

        public string GetNameInput()
        {
            Console.WriteLine("Dime tu nombre: ");
            name = Console.ReadLine();   

            if (!string.IsNullOrEmpty(name))
            {
                return name;
            } else {
                return GetNameInput();
            }
        }

        public int ShowMenu(string name)
        {
            Console.WriteLine("Hola, " + name +", que desea hacer? ");
            Console.WriteLine("[1] Calcular la edad");
            Console.WriteLine("[2] Cambiar nombre");
            Console.WriteLine("[3] Calcular edad en planetas");
            Console.WriteLine("[0] Salir");
            string option = Console.ReadLine();

            if(int.TryParse(option, out int opcion)) {
                return opcion;
            }

            Console.WriteLine("Entrada incorrecta");
            return ShowMenu(name);
        }




    }
}
