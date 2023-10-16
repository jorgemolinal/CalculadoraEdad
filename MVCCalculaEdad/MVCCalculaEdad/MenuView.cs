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
            string option = Console.ReadLine();

            if(!int.TryParse(option, out int opcion)) {
                Console.WriteLine("Entrada incorrecta");
                return ShowMenu(name);
            }
            return opcion;
        }
    }
}
