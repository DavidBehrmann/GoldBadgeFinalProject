using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesREPO
{
    public class BadgesRepo
    {
        public Dictionary<int, string> badgeDictionary = new Dictionary<int, string>();
        //public List<string> doorList = new List<string> { "A1", "A2", "A3", "B1", "B17", "C32" };

        //create new badge
        public void CreateNewBadge(int badgeID, string doorAccess)
        {
            badgeDictionary.Add(badgeID, doorAccess);
        }

        //update doors on an existing badge



        public void UpdateDoorsOnBadge(int badgeID)
        {
            if (badgeDictionary.ContainsKey(badgeID))
            {
                Console.WriteLine("What doors should this badge have access to?");
                string newDoorAccess = Console.ReadLine();
                badgeDictionary[badgeID] = newDoorAccess;
            }

            Console.WriteLine("I'm sorry, that badge does not exist.");

        }

        //show a list with all badge numbers and door access
        public Dictionary<int, string> DisplayBadgeDictionary()
        {
            return badgeDictionary;
        }

        public int DisplayBadgeByID(int badgeID)
        {
            if (badgeDictionary.ContainsKey(badgeID))
            {
                return badgeID;
            }

            Console.WriteLine("I'm sorry, that badge does not exist.");
            return 0;
        }

        //delete all doors form an existing badge


    }
}
