using CafeREPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    class ProgramUI
    {
        CafeRepo _cafeRepo = new CafeRepo();
        bool _isRunning = true;

        public void Start()
        {
            RunMenu();
        }
        private void RunMenu()
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
            Console.WriteLine("Komodo Cafe Menu Modification.\n" +
                "What would you like to do?\n" +
                "1. Add new item to the Menu\n" +
                "2. View Menu\n" +
                "3. Remove item from Menu\n" +
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
                    CreateNewMenuItem();
                    break;
                case "2":
                    DisplayMenu();
                    break;
                case "3":
                    DeleteMenuItem();
                    break;
                case "4":
                    _isRunning = false;
                    break;
                default:
                    Console.WriteLine("That is not a valid input.\n" +
                        "Please enter a number from the Main Menu.\n" +
                        "Press 'Enter' to continue.");
                    Console.ReadKey();
                    MainMenu();
                    return;
            }
        }

        private void CreateNewMenuItem()
        {

        }
        private void DisplayMenu()
        {

        }

        private void DeleteMenuItem()
        {

        }
        //Create new menu items


        //Display current menu


        //Delete Menu items


    }
}
