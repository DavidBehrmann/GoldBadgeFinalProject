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
    public class Outings
    {
        public Outings() { }
        public Outings(decimal totalCost) 
        {
            TotalCost = totalCost;
        }

        public Outings(EventType eventType, decimal totalCost)
        {
            EventType = eventType;
            TotalCost = totalCost;
        }

        public Outings(EventType eventType, int numOfPeopleAttended, DateTime date, decimal totalCost, decimal totalCostPerPerson)
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
        public decimal TotalCost { get; set; }
        public decimal TotalCostPerPerson { get; set; }
    }
}
