using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueInput = Console.ReadLine();
        int grade = int.Parse(valueInput);
        int modulo = grade % 10;
        string letter;
        string sign = "";

        if(grade >= 90){
            letter = "A";
        }
        else if(grade >=80){
            letter = "B";
        }
         else if(grade >=70){
            letter = "C";
        }
         else if(grade >=60){
            letter = "D";
        }
         else{
            letter = "F";
        }

        if(modulo >= 7) {
            sign = "+";
        }
        else if(modulo < 3) {
            sign = "-";
        }
        
        if(grade > 96 || grade < 60 ){
            sign = "";
        }

        Console.WriteLine($"Your grade is '{letter}{sign}'");

        

        if(grade >= 70){
            Console.WriteLine("You have passed the class.");
        }
        else{
            Console.WriteLine("You have failed the class.");
        }
    }
}