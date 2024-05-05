using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Creates a new Journal
        Journal theJournal = new Journal();
       
       Console.WriteLine("Welcome to Your Daily Journal!");

       while (true)
       {
        Console.WriteLine("Menu Options");
         Console.WriteLine("1. Add Entry");
          Console.WriteLine("2. Display");
           Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
             Console.WriteLine("5. Quit");

             Console.Write("Please select an option (1-5)");
             string choice = Console.ReadLine();

             //calls class methods per user selection
             switch (choice)
             {
                case "1":
                theJournal.AddEntry();
                break;

                case "2":
                theJournal.DisplayEntries();
                break;

                case "3":
                theJournal.LoadFromFile();
                break;

                case "4":
                theJournal.SaveToFile();
                break;

                case "5":
                Console.WriteLine("Goodbye");
                return;

                default:
                Console.WriteLine("Invalid selection, please enter a number 1-5.");
                break;
             }
       }
    }

}
