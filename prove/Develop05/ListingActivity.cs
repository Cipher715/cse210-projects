public class ListingActivity : Activity {
    private int _count;
    private List<string> _prompts;

    public ListingActivity(){
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 50;
        _count = 0;
        _prompts = new List<string>{
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run(){
        DisplayStartingMessage();
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items!!");
        Console.WriteLine();
        DisplayEndingMessage();

    }

    public void GetRandomPrompt(){
        Random rnd = new Random();
        int index = rnd.Next(0, _prompts.Count);
        Console.WriteLine($" --- {_prompts[index]} ---");
    }

    public List<string> GetListFromUser(){
        List<string> answer = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while(DateTime.Now < endTime){
            Console.Write("> ");
            string ans = Console.ReadLine();
            answer.Add(ans);
            _count++;
        }
        return answer;
    }
    
}