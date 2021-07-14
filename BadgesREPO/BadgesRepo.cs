using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesREPO
{
    public class BadgesRepo
    {

        public class BadgeDictionary
        {
            Dictionary<int, List<string>> badgeDictionary = new Dictionary<int, List<string>>();

            public void AddToBadgeDictionary(int BadgeID, string DoorList)
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
            }
        }
        /*IDictionary<int, string> badgeDictionary = new Dictionary<int, string>()
        {
            {1, "A1, A2, C5" },
            {2, "A1, B2, C1" },
        };*/


    }
}
