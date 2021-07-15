using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badges
{
    class ProgramUI
    {

        public void Run()
        {
            string path = @"C: \Users\david\Desktop\Software Development Course\ElevenFiftyProjects\GoldBadgeFinalProject\Cafe\Badges\DoorList.txt";
            string text = System.IO.File.ReadAllText(path);
            List<string> doorList = text.Split(',').ToList();


        }


    }
}
