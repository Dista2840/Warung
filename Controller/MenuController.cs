using System;
using System.Collections.Generic;
using System.Text;
using WARUNG.Model;

namespace WARUNG.Controller
{
    class MenuController
    {
        private List<Item> menuItem;

        public MenuController()
        {
            menuItem = new List<Item>();
        }

        public void addItem(Item item)
        {
            menuItem.Add(item);
        }

        public List<Item> getItems()
        {
            return menuItem;
        }
    }
}
