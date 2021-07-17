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
                    DisplayFullMenu();
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
                    
                    return;
            }
        }

        private void CreateNewMenuItem()
        {
            Console.Clear();
            Console.WriteLine("You are creating a new meal for the menu.\n" +
                "Enter the meal's number. (i.e. 5)");
            int mealNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the meal's name.");
            string mealName = Console.ReadLine();

            Console.WriteLine("Enter a description of the meal.");
            string description = Console.ReadLine();

            Console.WriteLine("Enter a list of ingredients.");
            string ingredients = Console.ReadLine();

            Console.WriteLine("Enter the price of the meal.");
            double price = double.Parse(Console.ReadLine());
            CafePoco menuItem = new CafePoco(mealNumber, mealName, description, ingredients, price);

            _cafeRepo.CreateMenuItem(menuItem);
            
            PressEnterToReturnToMainMenu();
        }
        private void DisplayFullMenu()
        {
            Console.Clear();
            List<CafePoco> menuList = _cafeRepo.ReadListOfMenuItems();
            foreach(CafePoco menuItem in menuList)
            {
                DisplayMenuItem(menuItem);
            }
            PressEnterToReturnToMainMenu();
        }
        private void DisplayMenuItem(CafePoco menuItem)
        {
            
            Console.WriteLine($"Your menu has the following items:\n" +
                $"Meal Number: {menuItem.MealNumber}\n" +
                $"Meal Name: {menuItem.MealName}\n" +
                $"Description: {menuItem.Description}\n" +
                $"Ingredients List: {menuItem.Ingredients}\n" +
                $"Meal Price: {menuItem.Price}\n");
        }

        private void DeleteMenuItem()
        {
            Console.WriteLine("Enter meal number to be deleted from the menu.");

            _cafeRepo.DeleteMealByNumber(int.Parse(Console.ReadLine()));

            PressEnterToReturnToMainMenu();
        }

        private void PressEnterToReturnToMainMenu()
        {
            Console.WriteLine("Press enter to return to Main Menu.");
            Console.ReadKey();
            RunMenu();
        }
    }
}
