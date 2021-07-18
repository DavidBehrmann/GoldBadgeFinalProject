using OutingsREPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outings
{
    class ProgramUI
    {
        OutingRepo _outingRepo = new OutingRepo();
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
            Console.WriteLine("Komodo Outings. What would you like to do?\n" +
                "1. See a list of all Outings.\n" +
                "2. Create a new Outings.\n" +
                "3. See total cost for all outings.\n" +
                "4. see total cost for all outings of a certain type.\n" +
                "5. Exit.");
            string userInput = Console.ReadLine();
            return userInput;
        }
        private void UserInputSelection(string userInput)
        {
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    DisplayListOfAllOutings();
                    break;
                case "2":
                    CreateANewOuting();
                    break;
                case "3":
                    DisplayTotalCostOfAllOutings();
                    break;
                case "4":
                    DisplayTotalCostOfAllOutingsOfACertainType();
                    break;
                case "5":
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

        private void DisplayListOfAllOutings()
        {
            Console.Clear();
            List<OutingEvent> _outingList = _outingRepo.ReadListOfOutings();
            foreach (OutingEvent outing in _outingList)
            {
                DisplayOuting(outing);
            }
            PressEnterToReturnToMainMenu();
        }
        private void DisplayOuting(OutingEvent outing)
        {
            Console.WriteLine($"Event Type: {outing.EventType}\n" +
                $"Attendance: {outing.NumOfPeopleAttended}\n" +
                $"Date of Event: {outing.Date}\n" +
                $"Total Cost of event: ${outing.TotalCost}\n" +
                $"Cost per person: ${outing.TotalCostPerPerson}\n");
        }

        private void CreateANewOuting()
        {
            Console.Clear();
            Console.WriteLine("What kind of outing will this be. Please enter one of the following:\n" +
                "Golf, Bowling, AmusmentPark, Concert");
            //Enum.TryParse(Console.ReadLine(), out EventType eventType);
            EventType eventType = (EventType)Enum.Parse(typeof(EventType), Console.ReadLine());

            Console.WriteLine("How many people attended?");
            int numOfPeopleAttended = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the Year of the event?");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the Month of the event?");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the Day of the event? (numerical)");
            int day = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(year, month, day);

            Console.WriteLine("What is the total cost for this Outing?");
            decimal totalCost = decimal.Parse(Console.ReadLine());

            decimal totalCostPerPerson = totalCost / numOfPeopleAttended;

            OutingEvent outing = new OutingEvent(eventType, numOfPeopleAttended, date, totalCost, totalCostPerPerson);
            _outingRepo.AddOutingToList(outing);
            PressEnterToReturnToMainMenu();
        }

        private void DisplayTotalCostOfAllOutings()
        {
            //_outingRepo.CombinedCostOfAllOutings();
            Console.WriteLine($"The cost of all company outings is: ${_outingRepo.CombinedCostOfAllOutings()}");
            PressEnterToReturnToMainMenu();
        }

        private void DisplayTotalCostOfAllOutingsOfACertainType()
        {
            Console.WriteLine("What type of Outing would you like to see the cost of?");
            EventType eventType = (EventType)Enum.Parse(typeof(EventType), Console.ReadLine());

            Console.WriteLine($"The cost of all company {eventType} is: ${_outingRepo.CombinedCostOfAllOutingsByType(eventType)}");
            PressEnterToReturnToMainMenu();
        }
        public void PressEnterToReturnToMainMenu()
        {
            Console.WriteLine("Press enter to return to Main Menu.");
            Console.ReadKey();
            RunMenu();
        }
    }
}
