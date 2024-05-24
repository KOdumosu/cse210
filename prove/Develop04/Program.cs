using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");
        int userOption = -1;
        while (userOption != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string option = Console.ReadLine();
            userOption = int.Parse(option);
            if (userOption == 1)
            {
                BreathingActivity breathingactivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0, "Breathe in...", "Breathe out...");
                breathingactivity.RunActivity();
                breathingactivity.Breathing();
                breathingactivity.EndActivity();
                Console.Clear();
            }
            if (userOption == 2)
            {
                ReflectingActivity reflectingactivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                reflectingactivity.RunActivity();
                reflectingactivity.Reflecting();
                reflectingactivity.EndActivity();
                Console.Clear();
            }
            if (userOption == 3)
            {
                ListingActivity listingactivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
                listingactivity.RunActivity();
                listingactivity.Listing();
                listingactivity.EndActivity();
                Console.Clear();
            }
            if (userOption == 4)
            {
                Console.Write("\n\nBE REST ASSURED THAT YOU ARE SO PRECIOUS");
                for (int i = 5; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.Write("\nGOODBYE!!");
            }
        }
    }
}