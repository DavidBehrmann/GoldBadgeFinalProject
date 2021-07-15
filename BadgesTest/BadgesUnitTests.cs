using BadgesREPO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BadgesTest
{
    [TestClass]
    public class BadgesUnitTests
    {
        [TestMethod]
        public void CreateNewBadge_NewBadgeCreated_ShouldGiveNewBadgeWithNullDoors()
        {
            var badgeRepo = new BadgesRepo();
            var newBadge = new Badge(1234);
            int dictionaryCountBeforeAdd = badgeRepo.badgeDictionary.Count;

            badgeRepo.CreateNewBadge(newBadge);
            int dictionaryCountAfterAdd = badgeRepo.badgeDictionary.Count;

            Assert.AreEqual(dictionaryCountBeforeAdd, dictionaryCountAfterAdd - 1);
        }
        [TestMethod]
        public void DisplayBadgeDictionary_ReadBadgeDictionary_ReturnsDictionary()
        {
            var badgeRepo = new BadgesRepo();

            var result = badgeRepo.DisplayBadgeDictionary();

            CollectionAssert.AllItemsAreNotNull(badgeRepo.badgeDictionary);
        }
    }
}
