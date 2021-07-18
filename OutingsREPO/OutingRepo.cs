using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutingsREPO
{    
    public class OutingRepo
    {
        public List<OutingEvent> _outingsList = new List<OutingEvent>();
        public OutingEvent outing = new OutingEvent();

        public void AddOutingToList(OutingEvent outing)
        {
            _outingsList.Add(outing);
        }
        public List<OutingEvent> ReadListOfOutings()
        {
            return _outingsList;
        }


      
        public decimal CombinedCostOfAllOutings()
        {
            decimal totalSum = 0;
            
            foreach(OutingEvent outing in _outingsList)
            {                
                totalSum += outing.TotalCost;
            }
            return totalSum;
            
        }
        public decimal CombinedCostOfAllOutingsByType(EventType eventType)
        {
            decimal totalSumByEvent = 0;

            foreach (OutingEvent outing in _outingsList)
            {
                if (outing.EventType == eventType)
                totalSumByEvent += outing.TotalCost;
            }
            return totalSumByEvent;
        }
    }
}
