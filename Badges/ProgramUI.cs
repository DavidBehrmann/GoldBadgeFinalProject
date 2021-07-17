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
        /*string path = @"C: \Users\david\Desktop\Software Development Course\ElevenFiftyProjects\GoldBadgeFinalProject\Cafe\Badges\DoorList.txt";
        string text = System.IO.File.ReadAllText(path);
        List<string> doorList = text.Split(',').ToList();*/

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

        private void DisplayAllBadgesInDictionary()
        {
            Console.Clear();
            Console.WriteLine("Badge#  ||  BadgeID  ||  Door Access:");
            Dictionary<int, Badge> badgeDictionary = _badgesRepo.DisplayBadgeDictionary();
            foreach (KeyValuePair<int, Badge> badge in badgeDictionary)
            {
                badgeDictionary.Select(i => $"{i.Key}  ||  {i.Value}").ToList().ForEach(Console.WriteLine);

            }
            PressEnterToReturnToMainMenu();
        }



        private void EditDoorsOnBadge()
        {
            Console.Clear();
            Console.WriteLine("Please enter the badge ID you would like to edit.");

        }

        private void AddNewBadge()
        {
            Console.Clear();
            Console.WriteLine("Please enter a badge ID number.");
            int badgeID = int.Parse(Console.ReadLine());

            List<string> doorAccess = CreateDoorAccessList();

            Badge newBadge = new Badge(badgeID, doorAccess);
        }

        public List<string> CreateDoorAccessList()
        {
            bool addDoors = true;
            List<string> doorAccess = new List<string>();
            while (addDoors)
            {
                string input = Console.ReadLine().ToLower();
                Console.WriteLine("Enter a door this badge has access to.");
                doorAccess.Add(Console.ReadLine());
                Console.WriteLine("Does this badge need access to more doors? y/n");
                input = Console.ReadLine().ToLower();
                while (input != "y" || input != "n")
                {
                    Console.WriteLine("Please enter y/n.");
                    input = Console.ReadLine().ToLower();
                }
                switch (input)
                {
                    case "y":
                        Console.WriteLine("Enter a door this badge has access to.");
                        doorAccess.Add(Console.ReadLine());
                        Console.WriteLine("Does this badge need access to more doors? y/n");
                        break;
                    case "n":
                        addDoors = false;
                        break;
                }
                
            }
            return doorAccess;

        }
        private void PressEnterToReturnToMainMenu()
        {
            Console.WriteLine("Press enter to return to Main Menu.");
            Console.ReadKey();
            MainMenu();
        }
    }
}
