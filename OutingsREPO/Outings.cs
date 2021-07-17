using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutingsREPO
{
    public enum EventType
    {
        Golf,
        Bowling,
        AmusementPark,
        Concert
    }
    class Outings
    {
        public Outings() { }
        public Outings(EventType eventType, int numOfPeopleAttended, DateTime date, double totalCost, double totalCostPerPerson)
        {
            EventType = eventType;
            NumOfPeopleAttended = numOfPeopleAttended;
            Date = date;
            TotalCost = totalCost;
            TotalCostPerPerson = totalCostPerPerson;
        }

        public EventType EventType { get; set; }
        public int NumOfPeopleAttended { get; set; }
        public DateTime Date { get; set; }
        public double TotalCost { get; set; }
        public double TotalCostPerPerson { get; set; }
    }
}
