// See https://aka.ms/new-console-template for more information
using MVCCalculaEdad;


namespace CalculadoraEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuController menu = new MenuController();
            menu.ManageMenu();

        }
    }
}