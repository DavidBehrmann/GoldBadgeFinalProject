using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutingsREPO
{    
    public class OutingRepo
    {
        public readonly List<Outings> _outingsList = new List<Outings>();
        public Outings outing = new Outings();

        public void CreateOuting(Outings outing)
        {
            _outingsList.Add(outing);
        }
        public List<Outings> ReadListOfOutings()
        {
            return _outingsList;
        }


      
        public decimal CombinedCostOfAllOutings()
        {
            decimal totalSum = 0;
            
            foreach(Outings outing in _outingsList)
            {                
                totalSum += outing.TotalCost;
            }
            return totalSum;
            
        }
        public decimal CombinedCostOfAllOutingsByType(EventType eventType)
        {
            decimal totalSumByEvent = 0;

            foreach (Outings outing in _outingsList)
            {
                if (outing.EventType == eventType)
                totalSumByEvent += outing.TotalCost;
            }
            return totalSumByEvent;
        }
    }
}
