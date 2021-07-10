using CafeREPO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CafeTest
{
    [TestClass]
    public class CafeRepoTests
    {
        [TestMethod]
        public void CreateMenuItem_ShouldAddToMenuList()
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
    }
}
