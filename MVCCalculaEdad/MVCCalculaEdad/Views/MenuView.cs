using Microsoft.VisualBasic.FileIO;
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
            Console.WriteLine("[0] Salir");
            string option = Console.ReadLine();

            if(int.TryParse(option, out int opcion)) {
                return opcion;
            }

            Console.WriteLine("Entrada incorrecta");
            return ShowMenu(name);
        }

        public bool tierra()
        {
            Console.WriteLine("[1] En la tierra");
            Console.WriteLine("[2] En otros planetas");
            string option = Console.ReadLine();

            if (int.TryParse(option, out int opcion))
            {
                bool esTierra = (opcion == 1) ? true : false;
                if (opcion == 1)
                {
                    esTierra = true;
                    return esTierra;
                } else if (opcion == 2)
                {
                    esTierra = false;
                    return esTierra;
                }
                else
                {
                    Console.WriteLine("Entrada incorrecta");
                    return tierra();
                }
                
            } else {
                Console.WriteLine("Entrada incorrecta");
                return tierra();
            }
        }


    }
}
