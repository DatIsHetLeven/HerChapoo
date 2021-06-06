using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class MenuItem
    {
        //public int  MenuItemId { get; set; }
        public int Prijs { get; set; }
        public string MenuItemNaam { get; set; }
        public int MenuId { get; set; }
        //public string MenuItemCategorie { get; set; }

        public MenuItem(int prijs, string menuItemNaam, int menuId)
        {
            //this.MenuItemId = menuItemId;
            this.MenuId = menuId;
            this.Prijs = prijs;
            this.MenuItemNaam = menuItemNaam;
            //this.MenuItemCategorie = menuItemCategorie;
        }

    }
}
