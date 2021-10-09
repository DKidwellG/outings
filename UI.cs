using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4_Company_Outings
{ 
    class UI
    {
        private OutingRepos _outings = new OutingRepos();
        public void Run()
        {
            SeedEventList();
            OutingRepos();
        }
        private void OutingRepos()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("select an option from the Menu then press enter:\n" +
                    "1. Enter a new event\n" +
                    "2. List of all events\n" +
                    "3. Cost of a event\n" +
                    "4. Cost of all events\n" +
                    "5. Exit");

                //get input
                string input = Console.ReadLine();

                //evaluate input
                switch (input)
                {
                    case "1":
                        //create
                        CreatNewEvent();
                        break;
                    case "2":
                        //list 
                        ViewAllEvents();
                        break;

                    case "3":
                        //list by number
                        ViewCostOfEvent();
                        break;
                    case "4":
                        //delete 
                        ViewCostOfAllEvents();
                        break;
                    case "10":
                        //exit
                        Console.WriteLine("Bu-by");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("pleas enter a number from the menu");
                        break;




                }
                Console.WriteLine("Press any key to continue.....");
                Console.ReadKey();
                Console.Clear();
            }
        }
                         /*Here's what they'd like:

                        Display a list of all outings.
                        Add individual outings to a list(don't need to worry about delete yet)*/
        private void CreatNewEvent()
        {    
            Console.Clear();

            OutingRepos newItem = new OutingRepos
            
            Console.WriteLine(" enter the event type, then press enter");
            newItem.EventType = Console.ReadLine();           
                      

            Console.WriteLine(" enter the number of people that attended, then press enter");
            string numOfPepAsString = Console.ReadLine();
            newItem.NumberOfPeople = int.Parse(numOfPepAsString);

            Console.WriteLine(" enter event price, then press enter");
            newItem.CostPerEvent = decimal.Parse(Console.ReadLine());

            _outings.AddEventItemToList(newItem);


        }
        //view all 
        private void ViewAllEvents()
        {
            Console.Clear();
            List<OutingRepos> listOfItems = _outings.GetEvent();
            foreach (OutingRepos content in listOfItems)
            {
                Console.WriteLine($"Event: {content.EventType}\n" +
                    $"number of people: {content.NumberOfPeople}\n" +
                    $"date: {content.Date}\n" +
                    $"price per person {content.CostPerPerson}\n" +
                    $"price per event {content.CostPerEvent}\n" +
                    $"press enter to continue");
            }
        }
            /*They'd like to see a display of outing costs by type.*/
        private void ViewCostOfEvent();
        


        //delete item
   /*Calculations:
        They'd like to see a display for the combined cost for all outings.
            For example, all bowling outings for the year were $2000.00. All Concert outings cost $5000.00.*/
        private void ViewCostOfAllEvents();

        //seed
        private void SeedEventList()
        {
            OutingRepos ipaConcert = new OutingRepos();
            OutingRepos bowling = new OutingRepos();

            _outings.AddMenuItemToList(ipaConcert);
            _outings.AddMenuItemToList(bowling);
        }


    }


}
