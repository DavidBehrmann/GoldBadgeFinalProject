using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesREPO
{
	public class Badge
	{	
		
		public int badgeID { get; set; }
		public List<string> doorList { get; } = new List<string> { "A1", "A2", "A3", "B1", "B17", "C32"};
		
		public Badge() { }
        public Badge(int BadgeID)
        {
            badgeID = BadgeID;
        }
        public Badge(int BadgeID, List<string> DoorAccess)
		{
			badgeID = BadgeID;
			doorList = DoorAccess;
			
		}
	}
}
