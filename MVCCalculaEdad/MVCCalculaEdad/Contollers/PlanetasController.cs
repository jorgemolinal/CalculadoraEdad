using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVCCalculaEdad
{
    public class PlanetasController
    {
        private UserModel user;
        private PlanetaModel planetaModel;
        private PlanetasView planetasView;

        public PlanetasController()
        {
            user = new UserModel(); //creo un usuario llamado user,
            planetaModel = new PlanetaModel(); 
            planetasView = new PlanetasView();
        }

        public void ManageMenu(string nombre)
        {
            user.nombre = nombre;
            GetMenu();
        }
        public void GetMenu()
        {
            int opcion = planetasView.ShowMenu(); //ShowMenu devuelve un int (la entrada que han metido)
            DateTime fechaNacimiento = planetasView.ShowCalcularEdad(user.nombre);
            switch (opcion)
            {
                case 1:
                    int anos = planetaModel.llamadaPlaneta("mercurio", fechaNacimiento);
                    planetasView.ShowEdad(anos, "mercurio");
                    break;
                case 2:
                    int anos2 = planetaModel.llamadaPlaneta("jupiter", fechaNacimiento);
                    planetasView.ShowEdad(anos2, "jupiter");
                    break;
                case 3:
                    int anos3 = planetaModel.llamadaPlaneta("venus", fechaNacimiento);
                    planetasView.ShowEdad(anos3, "venus");
                    break;
                case 4:
                    int anos4 = planetaModel.llamadaPlaneta("marte", fechaNacimiento);
                    planetasView.ShowEdad(anos4, "marte");
                    break;
                case 5:
                    int anos5 = planetaModel.llamadaPlaneta("saturno", fechaNacimiento);
                    planetasView.ShowEdad(anos5, "saturno");
                    break;
                case 6:
                    int anos6 = planetaModel.llamadaPlaneta("urano", fechaNacimiento);
                    planetasView.ShowEdad(anos6, "urano");
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
