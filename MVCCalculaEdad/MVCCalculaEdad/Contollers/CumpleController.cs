using MVCCalculaEdad.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCalculaEdad.Contollers
{
    internal class CumpleController
    {

        private UserModel user;
        private CumpleView cumpleView;

        public CumpleController()
        {
            user = new UserModel(); //creo un usuario llamado user,
            cumpleView = new CumpleView();
        }

        public void ManageMenu(string nombre)
        {
            user.nombre = nombre;
            GetMenu();
        }
        public void GetMenu()
        {
            int opcion = cumpleView.ShowMenu(); //ShowMenu devuelve un int (la entrada que han metido)
            switch (opcion)
            {
                case 1:
                    DateTime fechaNacimiento = cumpleView.ShowCalcularEdadEU(user.nombre);
                    EdadModel edad = new EdadModel();
                    DateTime fechaAnterior = DateTime.Now;
                    edad = user.calcularEdad(fechaNacimiento, fechaAnterior);
                    cumpleView.ShowEdad(user.nombre, edad.edadAnios, edad.edadMeses, edad.edadDias);
                    break;
                case 2:
                    DateTime fechaNacimiento2 = cumpleView.ShowCalcularEdadAM(user.nombre);
                    EdadModel edad2 = new EdadModel();
                    DateTime fechaAnterior2 = DateTime.Now;
                    edad = user.calcularEdad(fechaNacimiento2, fechaAnterior2);
                    cumpleView.ShowEdad(user.nombre, edad.edadAnios, edad.edadMeses, edad.edadDias);
                    break; 
                case 0:
                    MenuController menu = new MenuController();
                    menu.ManageMenu();
                    break;
                default:
                    GetMenu();
                    break;
            }
        }
    }
}
