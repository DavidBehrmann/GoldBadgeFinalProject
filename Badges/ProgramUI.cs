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
            Console.WriteLine("Badge#  ||  Door Access:");
            Dictionary<int, List<string>> badgeDictionary = _badgesRepo.DisplayBadgeDictionary();
            foreach (KeyValuePair<int, List<string>> badge in badgeDictionary)
            {
                badgeDictionary.Select(i => $"{i.Key}  ||  {i.Value}").ToList().ForEach(Console.WriteLine);
                
            }
            PressEnterToReturnToMainMenu();
        }
        
        private void EditDoorsOnBadge()
        {
            throw new NotImplementedException();
        }

        private void AddNewBadge()
        {
            throw new NotImplementedException();
        }
        private void PressEnterToReturnToMainMenu()
        {
            Console.WriteLine("Press enter to return to Main Menu.");
            Console.ReadKey();
            MainMenu();
        }
    }
}
