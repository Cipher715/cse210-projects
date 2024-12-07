public class ReflectingActivity : Activity{
    private List<string> _prompts;
    private List<string> _questions;
    private List<int> _selected;

    public ReflectingActivity(){
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 50;
        _prompts = new List<string>{
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>{
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        _selected = new List<int>();
    }   

    public void Run(){
        DisplayStartingMessage();
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string enter = "default";
        while(enter != ""){
            enter = Console.ReadLine();
        }
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt(){
        Random rnd = new Random();
        int index = rnd.Next(0, _prompts.Count);
        return $" --- {_prompts[index]} ---";
    }

    public string GetRandomQuestion(){
        while(true){
            Random rnd = new Random();
            int index = rnd.Next(0, _questions.Count);
            if(!_selected.Contains(index)){
                _selected.Add(index);
                return _questions[index];
            }
            if(_selected.Count == _questions.Count){
                _selected.Clear();
            }
        }
    }

    public void DisplayPrompt(){
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions(){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while(DateTime.Now < endTime){
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(8);
            Console.WriteLine();
        }
    }


}