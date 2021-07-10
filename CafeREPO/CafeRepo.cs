using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CafeREPO.CafePoco;

namespace CafeREPO
{
    public class CafeRepo
    {
        public readonly List<CafePoco> _menuList = new List<CafePoco>();
        //Create menu items
        public void CreateMenuItem(CafePoco menuItem)
        {
            _menuList.Add(menuItem);
        }
        //Read list of menue items
        public List<CafePoco> ReadListOfMenuItems()
        {
            return _menuList;
        }
        //Delete menu items
        public void RemoveItemsFromMenu()
        {

        }

    }

    





}
