using System;
using System.Collections.Generic;

namespace Module5Lab1
{
    interface IVariables
    {
        string Name { get; set; }
        string Event { get; set; }
        string Hours { get; set; }
        string Status { get; set; }
    }
    class Base : IVariables
    {

        public string Name { get; set; }
        public string Event { get; set; }
        public string Hours { get; set; }
        public string Status { get; set; }
    
    

        static void Main(string[] args)
        {
            IVariables e = new Base();
            Console.WriteLine("Welcome to the Fund Raising sign up program.");//welcome message
            int choice;//variables
            Console.WriteLine("Please enter your name:");//menu selection
            e.Name = Console.ReadLine();
            List<string> events = new List<string>();
            do
            {
                Console.WriteLine("Choose the event you would like to sign up for:");
                Console.WriteLine("Press 1 to sign up for the Walkathon");
                Console.WriteLine("Press 2 to sign up for Golfing");
                Console.WriteLine("Press 3 to sign up for Brat Fry");
                Console.WriteLine("Press 4 to sign up for Bake Sale");
                Console.WriteLine("Press 5 to sign up for Book Fair");
                Console.WriteLine("Press 6 to finish adding vulenteer activities.");
                Int32.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Thanks for signing up for the Walkaton event.");
                        string event1 = "Walkaton";
                        events.Add(event1);
                        break;
                    case 2:
                        Console.WriteLine("Thanks for signing up for the Golfing event.");
                        string event2 = "Golfing";
                        events.Add(event2);
                        break;
                    case 3:
                        Console.WriteLine("Thanks for signing up for the Brat Fry event.");
                        string event3 = "Brat Fry";
                        events.Add(event3);
                        break;
                    case 4:
                        Console.WriteLine("Thanks for signing up for the Bake Sale event.");
                        string event4 = "Bake Sale";
                        events.Add(event4);
                        break;
                    case 5:
                        Console.WriteLine("Thanks for signing up for the Book Fair event.");
                        string event5 = "Book Fair";
                        events.Add(event5);
                        break;
                }

            }
            while (choice != 6);//program end if user selects 4

            Console.WriteLine("3.Please enter the number of hours you can work per week:");
            e.Hours = Console.ReadLine();
            Console.WriteLine("4.Are you a new volunteer?(Yes/No)");
            string status = Console.ReadLine();
            if (status.Equals("Yes") || status.Equals("yes"))
            {
                e.Status = "New";
            }
            else if(status.Equals("Yes") || status.Equals("yes"))
            {
                e.Status = "Returning Volunteer";
            }
            e.Event = string.Join(", ", events);

            Console.WriteLine("\nName: {0}  \nEvents: {1} \nHours/week: {2} \nStatus: {3}", e.Name, e.Event, e.Hours, e.Status);
        }
    }
}
