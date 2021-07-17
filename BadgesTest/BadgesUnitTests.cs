using BadgesREPO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
            Badge badge = new Badge();

            badgeRepo.CreateNewBadge(1, badge);
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
        public void DisplayBadgeByID_ValidBadgeEntered_ReturnsBadge()
        {
            var badgeRepo = new BadgesRepo();
            int badgeNum = 1;
            Badge badge = new Badge();
            badgeRepo.CreateNewBadge(1, badge);

            badgeRepo.DisplayBadgeByID(badgeNum);

            Assert.IsNotNull(badgeNum);
        }
        [TestMethod]
        public void DisplayBadgeByID_InvalidBadgeEntered_ReturnsNull()
        {
            var badgeRepo = new BadgesRepo();
            int badgeNum = 3;
            Badge badge = new Badge();
            badgeRepo.CreateNewBadge(1, badge);

            badgeRepo.DisplayBadgeByID(badgeNum);

            Assert.AreNotEqual(badgeNum, "I'm sorry, that badge does not exist.");
        }
        [TestMethod]
        public void DeleteAllDoorsOnABadge_ValidBadgeEntered_ClearsDoorAccess()
        {
            var badgeRepo = new BadgesRepo();
            int badgeNum = 1;
            List<string> doorAccess = new List<string>();
            doorAccess.Add("A1");
            doorAccess.Add("B1");
            doorAccess.Add("C1");
            int badgeID = 12345;
            Badge badge = new Badge(badgeID, doorAccess);
            badgeRepo.CreateNewBadge(1, badge);
            
            badgeRepo.DeleteAllDoorsOnABadge(badgeNum);
            int doorAccessCountAfter = doorAccess.Count;

            Assert.AreEqual(0, doorAccessCountAfter);
        }
        [TestMethod]
        public void DeleteAllDoorsOnABadge_InvalidBadgeEntered_ClearsDoorAccess()
        {
            var badgeRepo = new BadgesRepo();
            int badgeNum = 3;
            List<string> doorAccess = new List<string>();
            doorAccess.Add("A1");
            doorAccess.Add("B1");
            doorAccess.Add("C1");
            int badgeID = 12345;
            Badge badge = new Badge(badgeID, doorAccess);
            badgeRepo.CreateNewBadge(1, badge);

            badgeRepo.DeleteAllDoorsOnABadge(badgeNum);
            int doorAccessCountAfter = doorAccess.Count;

            Assert.AreNotEqual(badgeNum, "I'm sorry, that badge does not exist.");
        }
    }
}
