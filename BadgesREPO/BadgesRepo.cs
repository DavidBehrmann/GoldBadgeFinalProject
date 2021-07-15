using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesREPO
{
    public class BadgesRepo
    {
        public Dictionary<int,string> badgeDictionary = new Dictionary<int, string>();
        //public List<string> doorList = new List<string> { "A1", "A2", "A3", "B1", "B17", "C32" };

        //create new badge
        public void CreateNewBadge(int badgeID, string doorAccess)
        {
            badgeDictionary.Add(badgeID, doorAccess);
        }

        //update doors on an existing badge


        
        public void AddDoorsOnBadge(int badgeID)
        {
            
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
        






       /* public void AddToBadgeDictionary(int BadgeID, string DoorList)
        {
            if (this.badgeDictionary.ContainsKey(BadgeID))
            {
                List<string> doorList = this.badgeDictionary[BadgeID];
                if (doorList.Contains(DoorList) == false)
                {
                    doorList.Add(DoorList);
                }
            }
            else
            {
                List<string> doorList = new List<string>();
                doorList.Add(DoorList);
                this.badgeDictionary.Add(BadgeID, doorList);
            }
        }*/



        /*IDictionary<int, string> badgeDictionary = new Dictionary<int, string>()
        {
            {1, "A1, A2, C5" },
            {2, "A1, B2, C1" },
        };*/


    }
}
