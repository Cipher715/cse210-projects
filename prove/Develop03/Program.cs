using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string script1 = "I laid me down and slept; I awaked; for the Lord sustained me.";
        string script2 = "I laid me down and slept; I awaked; for the Lord sustained me. I will not be afraid of ten thousands of people, that have set themselves against me round about.";
        Reference ref1 = new Reference("Psalm", 3, 5);
        Reference ref2 = new Reference("Psalm", 3, 5, 6);
        Scripture scripture1 = new Scripture(ref1, script1);
        Scripture scripture2 = new Scripture(ref2, script2);
        List<Scripture> scriptures = [scripture1, scripture2];
        Console.WriteLine("Welcome to Scripture Memorizer.");
        Console.WriteLine("Choose which verse(s) to memorize:(Enter the number.)");
        Console.WriteLine("1: Psalm 3:5");
        Console.WriteLine("2: Psalm 3:5-6");
        Console.Write(">");
        int choice = int.Parse(Console.ReadLine());
        Scripture memorize = scriptures[choice-1];

        while(true){
            Console.Clear();
            Console.WriteLine(memorize.GetDisplayText());
            Console.WriteLine();

            if(memorize.IsCompletelyHidden()){
                break;
            }

            Console.WriteLine("Press enter to continue to type 'quit' to finish:");
            string end = Console.ReadLine();
            if(end == "quit"){
                break;
            } else{
                memorize.HideRandomWords(3);
            }

        }

    }
}