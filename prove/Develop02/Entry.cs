public class Entry {
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _username;

    public void Display(){
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine($" - {_username}");
        Console.WriteLine();
    }
}