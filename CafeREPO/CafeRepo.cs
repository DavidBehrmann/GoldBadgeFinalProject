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
        public CafePoco GetMealByNumber(int mealNumber)
        {
            foreach (CafePoco item in _menuList)
            {
                if (item.MealNumber == mealNumber)
                {
                    return item;
                }
            }
            return null;
        }

        //Delete menu items
        public bool RemoveItemsFromMenu(CafePoco menuItem)
        {
            return _menuList.Remove(menuItem);
        }
        
        public bool DeleteMealByNumber(int mealNumber)
        {
            CafePoco mealToBeDeleted = GetMealByNumber(mealNumber);

            return RemoveItemsFromMenu(mealToBeDeleted);
        }

    }

    





}
