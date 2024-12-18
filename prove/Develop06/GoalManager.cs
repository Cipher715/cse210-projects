public class GoalManager{
    private List<Goal> _goals;
    private int _score;

    public GoalManager(){
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start(){
        string choice = "0";
        while(true){
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if(choice == "1"){
                CreateGoal();
            } else if(choice == "2"){
                ListGoalDetails();
            } else if(choice == "3"){
                SaveGoals();
            } else if(choice == "4"){
                LoadGoals();
            } else if(choice == "5"){
                RecordEvent();
            } else if(choice == "6"){
                break;
            }
        }

    }

    public void DisplayPlayerInfo(){
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames(){
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach(Goal goal in _goals){
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
    }
    public void ListGoalDetails(){
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach(Goal goal in _goals){
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }
    public void CreateGoal(){
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();
        Console.Write("What is the name of your goal? : ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? : ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? : ");
        int point = int.Parse(Console.ReadLine());
        if(choice == "3"){
            Console.Write("Howm many times does this goal need to be accomplished for a bonus? : ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? : ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, point, target, bonus));
        }else if(choice == "2"){
            _goals.Add(new EternalGoal(name, description, point));
        }else if(choice == "1"){
            _goals.Add(new SimpleGoal(name, description, point));
        }
    }
    public void RecordEvent(){
        ListGoalNames();
        Console.Write("Which goal did you accomplish? : ");
        int choice = int.Parse(Console.ReadLine());
        choice --;
        int point = _goals[choice].RecordEvent();
        _score += point;
        Console.WriteLine($"Congratulations! You have earned {point} points!");
        Console.WriteLine($"You now have {_score} points.");

    }
    public void SaveGoals(){
        Console.WriteLine("What is the file name?");
        Console.Write(">");
        string file = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(file)){
            outputFile.WriteLine($"{_score}");
            foreach(Goal goal in _goals){
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }
    public void LoadGoals(){
        Console.WriteLine("What is the file name?");
        Console.Write(">");
        string file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach(string line in lines){
            string[] parts = line.Split(":");
            if(parts[0] == "SimpleGoal"){
                string[] elements = parts[1].Split(",");
                SimpleGoal goal = new SimpleGoal(elements[0], elements[1], int.Parse(elements[2]));
                if(elements[3] == "True"){
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }else if(parts[0] == "EternalGoal"){
                string[] elements = parts[1].Split(",");
                EternalGoal goal = new EternalGoal(elements[0], elements[1], int.Parse(elements[2]));
                _goals.Add(goal);

            }else if(parts[0] == "ChecklistGoal"){
                string[] elements = parts[1].Split(",");
                ChecklistGoal goal = new ChecklistGoal(elements[0], elements[1], int.Parse(elements[2]), int.Parse(elements[4]), int.Parse(elements[3]));
                int accomplished = int.Parse(elements[5]);
                if(accomplished > 0){
                    for(int i = 0; i < accomplished; i++){
                        goal.RecordEvent();
                    }
                }
                _goals.Add(goal);
            }else {
                _score = int.Parse(parts[0]);
            }
        }
    }
}