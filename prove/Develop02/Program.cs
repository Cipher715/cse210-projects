using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Console.WriteLine("Welcome to CSE210 Shared Journal.");
        Console.WriteLine("Please select one of the following choices:");
        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();

        while(choice != 5) {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if(choice == 1) {
                Entry e = new Entry();
                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();
                string promptText = prompts.GetRandomPrompt();
                Console.WriteLine("Who is writing this?");
                string username = Console.ReadLine(); 
                Console.WriteLine(promptText);
                Console.Write(">");
                string entryText = Console.ReadLine();
                e._date = dateText;
                e._promptText = promptText;
                e._entryText = entryText;
                e._username = username;

                journal.AddEntry(e);
            }
            else if(choice == 2){
                journal.DisplayAll();
            }
            else if(choice == 3){
                Console.WriteLine("What is the file name?");
                Console.Write(">");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if(choice == 4){
                Console.WriteLine("What is the file name?");
                Console.Write(">");
                string file = Console.ReadLine();
                journal.SaveToFile(file);                
            }

        }
        
    }
}