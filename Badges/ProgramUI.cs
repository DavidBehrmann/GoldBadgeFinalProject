using BadgesREPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badges
{
    class ProgramUI
    {
        BadgesRepo _badgesRepo = new BadgesRepo();
        private bool _isRunning = true;
        public void Start()
        {
            RunMenu();
        }
        

        public void RunMenu()
        {
            while (_isRunning)
            {
                string userInput = MainMenu();
                UserInputSelection(userInput);
            }
        }

        private string MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Komodo Insurance Badge System.\n" +
                "What would you like to do?\n" +
                "1. Add a badge\n" +
                "2. Edit a badge\n" +
                "3. List all badges\n" +
                "4. Exit\n");
            string userInput = Console.ReadLine();
            return userInput;
        }
        private void UserInputSelection(string userInput)
        {
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    AddNewBadge();
                    break;
                case "2":
                    EditDoorsOnBadge();
                    break;
                case "3":
                    DisplayAllBadgesInDictionary();
                    break;
                case "4":
                    _isRunning = false;
                    break;
                default:
                    Console.WriteLine("That is not a valid input.\n" +
                        "Please enter a number from the Main Menu.\n" +
                        "Press 'Enter' to continue.");
                    Console.ReadKey();

                    return;
            }
        }

        public void DisplayAllBadgesInDictionary()
        {
            Console.Clear();
            Console.WriteLine("Badge#  ||  BadgeID  ||  Door Access:");
            Dictionary<int, Badge> badgeDictionary = _badgesRepo.DisplayBadgeDictionary();
            foreach (KeyValuePair<int, Badge> badge in badgeDictionary)
            {
                List<string> currentDoor = badge.Value.doorAccess;
                string doorAccess = string.Join(",", currentDoor);
                
                Console.WriteLine(badge.Key + "\t\t"  + badge.Value.badgeID+ "\t\t" + doorAccess);
            }
           /* foreach (var formattedBadge in badgeDictionary.Select(i => $"{i.Key}  ||  {i.Value.badgeID}  ||  {i.Value.doorAccess}").ToList())
            {
                Console.WriteLine(formattedBadge);
            }*/
            PressEnterToReturnToMainMenu();
        }



        public void EditDoorsOnBadge()
        {
            
            Console.Clear();
            Console.WriteLine("Please enter the badge number you would like to edit.");
            int badgeNum = int.Parse(Console.ReadLine());
            _badgesRepo.DisplayBadgeByID(badgeNum);

            //bug, if a null is returned the program still proceeds. Need program to return to main menu or ask for an ID again.
            

            Console.WriteLine("What would you like to do to this badge?\n" +
                    "1. Add door access.\n" +
                    "2. Remove door access\n" +
                    "3. Remove access to all doors.\n" +
                    "4. Nothing and return to Main Menu.\n");
            string input = Console.ReadLine();

           
                
                switch (input)
                {
                    case "1":
                        CreateDoorAccessList();
                        break;
                    case "2":
                        RemoveDoorAccess();
                        break;
                    case "3":
                        Console.WriteLine("You are about to remove access to ALL doors on this badge. Do you wish to proceed? y/n");
                    input = Console.ReadLine();
                        switch (input)
                        {
                        case "y":
                            _badgesRepo.DeleteAllDoorsOnABadge(badgeNum);
                            break;
                        case "n":
                            break;
                        }
                        break;
                    case "4":
                        break;
                }
            
            PressEnterToReturnToMainMenu();

        }

        public void AddNewBadge()
        {
            Console.Clear();
            Console.WriteLine("Please assign a number to this badge.\n" +
                "(this is a reference number, not a badge ID number)");
            int badgeNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a badge ID number.");
            int badgeID = int.Parse(Console.ReadLine());

            List<string> doorAccess = CreateDoorAccessList();

            Badge newBadge = new Badge(badgeID, doorAccess);

            _badgesRepo.badgeDictionary.Add(badgeNum, newBadge);
            PressEnterToReturnToMainMenu();
        }

        public List<string> CreateDoorAccessList()
        {
            bool addDoors = true;
            List<string> doorAccess = new List<string>();



            Console.WriteLine("Enter a door this badge has access to.");
            doorAccess.Add(Console.ReadLine());
            Console.WriteLine("Does this badge need access to more doors? y/n");
            string input = Console.ReadLine().ToLower();

            while (addDoors)
            {
                switch (input)
                {
                    case "y":
                        Console.WriteLine("Enter a door this badge has access to.");
                        doorAccess.Add(Console.ReadLine());
                        Console.WriteLine("Does this badge need access to more doors? y/n");
                        input = Console.ReadLine().ToLower();
                        break;
                    case "n":
                        addDoors = false;
                        break;
                }

            }
            return doorAccess;



        }
        public List<string> RemoveDoorAccess()
        {
            bool removeDoor = true;
            List<string> doorAccess = new List<string>();



            Console.WriteLine("Enter a door to remove access.");
            doorAccess.Remove(Console.ReadLine());
            Console.WriteLine("Do you want to remove more doors? y/n");
            string input = Console.ReadLine().ToLower();
            while (removeDoor)
            {
                switch (input)
                {
                    case "y":
                        Console.WriteLine("Enter a door to remove access.");
                        doorAccess.Remove(Console.ReadLine());
                        Console.WriteLine("Do you want to remove more doors? y/n");
                        input = Console.ReadLine().ToLower();
                        break;
                    case "n":
                        removeDoor = false;
                        break;
                }

            }


            return doorAccess;

        }
        public void PressEnterToReturnToMainMenu()
        {
            Console.WriteLine("Press enter to return to Main Menu.");
            Console.ReadKey();
            RunMenu();
        }
    }
}
