using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutingsREPO;
using System;

namespace OutingsTest
{
    [TestClass]
    public class OutingsUnitTest
    {
        [TestMethod]
        public void AddOutingToList_AddOutingToList()
        {
            var outingRepo = new OutingRepo();
            OutingEvent outing = new OutingEvent();
            int listBefore = outingRepo._outingsList.Count;

            outingRepo.AddOutingToList(outing);
            int listAfter = outingRepo._outingsList.Count;

            Assert.AreEqual(listBefore, listAfter - 1);
        }

        [TestMethod]
        public void ReadListOfOutings_ReturnedItemsAreUnique()
        {
            var outingRepo = new OutingRepo();

            outingRepo.ReadListOfOutings();

            CollectionAssert.AllItemsAreUnique(outingRepo._outingsList);
        }

        [TestMethod]
        public void CombinedCostOfAllOutings_ReturnTotalSum()
        {
            var outingRepo = new OutingRepo();
            decimal totalSumBefore = 0;
            OutingEvent outing = new OutingEvent(12345);
            outingRepo._outingsList.Add(outing);

            outingRepo.CombinedCostOfAllOutings();
            decimal totalSumAfter = outingRepo.CombinedCostOfAllOutings();

            Assert.AreNotEqual(totalSumBefore, totalSumAfter);
        }

        [TestMethod]
        public void CombinedCostOfAllOutingsByType_()
        {
            var outingRepo = new OutingRepo();
            decimal totalSumBefore = 0;
            OutingEvent outing = new OutingEvent(EventType.Golf, 12345);
            outingRepo._outingsList.Add(outing);

            outingRepo.CombinedCostOfAllOutingsByType(EventType.Golf);
            decimal totalSumAfter = outingRepo.CombinedCostOfAllOutingsByType(EventType.Golf);

            Assert.AreNotEqual(totalSumBefore, totalSumAfter);
        }
    }
}
