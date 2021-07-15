using BadgesREPO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BadgesTest
{
    [TestClass]
    public class BadgesUnitTests
    {
        [TestMethod]
        public void CreateNewBadge_NewBadgeCreated_AddNewBadgeToDictionary()
        {
            var badgeRepo = new BadgesRepo();
            int dictionaryCountBeforeAdd = badgeRepo.badgeDictionary.Count;

            badgeRepo.CreateNewBadge(1234, "A1, A2");
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
