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
		public List<string> _doorNames { get; } = new List<string>();
		
		public Badge() { }
        public Badge(int BadgeID)
        {
			badgeID = BadgeID;
        }
		public Badge(int BadgeID, List<string> DoorAccess)
		{
			badgeID = BadgeID;
			_doorNames = DoorAccess;
			
		}
	}
}
