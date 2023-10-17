using MVCCalculaEdad.Contollers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCalculaEdad
{
    public class MenuController
    {
        private UserModel user;
        private MenuView menuView;
        private bool final = false;
        public MenuController() {
            user = new UserModel(); //creo un usuario llamado user, 
            menuView = new MenuView();
        }

        public void ManageMenu()
        {
            menuView.ShowWelcome();
            GetName();
            GetMenu();
        }
        public void GetName() { 
            string name = menuView.GetNameInput();  
            user.nombre = name;
        }
        public void GetMenu()
        {
            do
            {
                int opcion = menuView.ShowMenu(user.nombre); //ShowMenu devuelve un int (la entrada que han metido)
                switch(opcion)
                {
                    case 1:
                        bool tierra = menuView.tierra();
                        if (tierra)
                        {
                            CumpleController menuCumple = new CumpleController();
                            menuCumple.ManageMenu(user.nombre);
                            break;
                        }
                        else
                        {
                            PlanetasController menu = new PlanetasController();
                            menu.ManageMenu(user.nombre);
                            break;
                        }
                       
                    case 2:
                        GetName();
                        GetMenu();
                        break;
                        
                    case 0:
                        final = true; break;
                    default:
                        GetMenu(); 
                        break;

                }
            } while (!final);

        }
    }
}
