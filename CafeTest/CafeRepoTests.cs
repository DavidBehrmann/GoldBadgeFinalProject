using CafeREPO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CafeTest
{
    [TestClass]
    public class CafeRepoTests
    {
        [TestMethod]
        public void CreateMenuItem_AddingMenuItemToList_ShouldAddToMenuList()
        {
            //arrange
            var cafeRepo = new CafeRepo();
            var menuItemToAdd = new CafePoco(1, "BLT", "Bacon, Lettuc and Tomato on toast", "Hickory Smoked Bacon, Vine Ripened Tomatoes, Romaine Lettuce, Whole Wheat Bread, Mayonaise, salt, pepper", 7.99);
            int menuCountBeforeAdd = cafeRepo._menuList.Count;

            //act
            cafeRepo.CreateMenuItem(menuItemToAdd);
            int countAfterAdd = cafeRepo._menuList.Count;

            //assert
            Assert.AreEqual(menuCountBeforeAdd, countAfterAdd - 1);
        }
        [TestMethod]
        public void ReadListOfMenuItems_ReadingMenuList_ReturnsList()
        {
            //arrange
            var cafeRepo = new CafeRepo();

            //act
            var result = cafeRepo.ReadListOfMenuItems();

            //assert
            CollectionAssert.AllItemsAreUnique(result);
        }

        [TestMethod]
        public void GetMealByNumber_IfMealNumberMatches_ReturnItem()
        {
            var cafeRepo = new CafeRepo();
            var menuItem = new CafePoco(1, "BLT", "Bacon, Lettuc and Tomato on toast", "Hickory Smoked Bacon, Vine Ripened Tomatoes, Romaine Lettuce, Whole Wheat Bread, Mayonaise, salt, pepper", 7.99);

            cafeRepo.CreateMenuItem(menuItem);
            var result = cafeRepo.GetMealByNumber(1);

            Assert.AreEqual(menuItem, result);
        }
        [TestMethod]
        public void GetMealByNumber_IfMealNumberNotFound_ReturnNull()
        {
            var cafeRepo = new CafeRepo();
            var menuItem = new CafePoco(1, "BLT", "Bacon, Lettuc and Tomato on toast", "Hickory Smoked Bacon, Vine Ripened Tomatoes, Romaine Lettuce, Whole Wheat Bread, Mayonaise, salt, pepper", 7.99);

            cafeRepo.CreateMenuItem(menuItem);
            var result = cafeRepo.GetMealByNumber(2);

            Assert.AreNotEqual(menuItem, result);
        }

        [TestMethod]
        public void RemoveItemsFromMenu_DeletingMenuItem_ListCountReturnsOneLess()
        {

            var cafeRepo = new CafeRepo();
            var itemToBeDeleted = new CafePoco();
            cafeRepo.CreateMenuItem(itemToBeDeleted);

            cafeRepo.RemoveItemsFromMenu(itemToBeDeleted);

            CollectionAssert.DoesNotContain(cafeRepo._menuList, itemToBeDeleted);
        }
        [TestMethod]
        public void DeleteMealByNumber_MealNumberGiven_MealNumberDeleted()
        {

        }
    }
    

}
