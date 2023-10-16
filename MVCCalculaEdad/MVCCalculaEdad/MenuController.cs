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

        public MenuController() {
            user = new UserModel();
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
            user.name = name;
        }
        public string GetMenu()
        {
            int opcion = menuView.ShowMenu(user.name);
            return "SIN ACABAR";
        }
    }
}
