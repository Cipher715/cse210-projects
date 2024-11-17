public class Journal {
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry){
        _entries.Add(newEntry);
    }
    public void DisplayAll(){
        foreach(Entry e in _entries){
            e.Display();
        }
    }
    public void SaveToFile(string file) {
        Console.WriteLine("Saving to file...");
        using (StreamWriter outputFile = new StreamWriter(file)){
            foreach(Entry e in _entries){
                outputFile.WriteLine($"{e._date}|{e._promptText}|{e._entryText}|{e._username}");
            }
        }
    }
    public void LoadFromFile(string file) {
        Console.WriteLine("Loading journal from file...");
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach(string line in lines){
            string[] parts = line.Split("|");
            Entry e = new Entry();
            e._date = parts[0];
            e._promptText = parts[1];
            e._entryText = parts[2];
            e._username = parts[3];
            _entries.Add(e);
        }
    }

}