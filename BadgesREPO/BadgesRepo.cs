using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesREPO
{
    public class BadgesRepo
    {

        public Dictionary<int, Badge> badgeDictionary = new Dictionary<int, Badge>();

        //create new badge
        public void CreateNewBadge(int badgeNum, Badge badge)
        {
            badgeDictionary.Add(badgeNum, badge);
        }



        //show a list with all badge numbers and door access
        public Dictionary<int, Badge> DisplayBadgeDictionary()
        {
            return badgeDictionary;
        }

        public Badge DisplayBadgeByID(int badgeNum)
        {
            
            if (badgeDictionary.ContainsKey(badgeNum))
            {
                return badgeDictionary[badgeNum];
            }

            Console.WriteLine("I'm sorry, that badge does not exist.");
            return null;
        }

        //delete all doors from an existing badge

        public Badge DeleteAllDoorsOnABadge(int badgeNum)
        {
            if (badgeDictionary.ContainsKey(badgeNum))
            {
                badgeDictionary[badgeNum].doorAccess = new List<string>();
                Console.WriteLine("You have removed access to every door from this badge.");
            }

            Console.WriteLine("I'm sorry, that badge does not exist.");
            return null;
            
        }
    }
}
