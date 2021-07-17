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

            badgeRepo.DisplayBadgeDictionary();

            CollectionAssert.AllItemsAreUnique(badgeRepo.badgeDictionary);
        }
        [TestMethod]
        public void UpdateDoorsOnBadge_ChangedDoorAccessForBadge_DoorAccessIsUpdated()
        {
            var badgeRepo = new BadgesRepo();
            badgeRepo.badgeDictionary.Add(Badge)
            int badgeID = 1234;
            string newDoorAccess = "A1, A2, A3";

            badgeRepo.UpdateDoorsOnBadge(badgeID);


        }
    }
}
