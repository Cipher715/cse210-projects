using System.Security.Cryptography.X509Certificates;

public class Scripture{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text){
        _reference = Reference;
        _words = new List<Word>();
        string[] newString = text.Split(' ');
        foreach(string word in newString){
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide){
        Random rnd = new Random();
        for(int i = 0; i < numberToHide; i++){
            if(IsCompletelyHidden()){
                break;
            }
            int index = rnd.Next(_words.Count);
            while(_words[index].IsHidden()){
                index = rnd.Next(_words.Count);
            }
            _words[index].Hide();
        }
    }

    public string GetDisplayText(){
        List<string> scripture = new List<string>();
        foreach(Word word in _words){
            scripture.Add(word.GetDisplayText());
        }
        return _reference.GetDisplayText() + " " + string.Join(" ", scripture);
    }

    public bool IsCompletelyHidden(){
        foreach(Word word in _words){
            if(!word.IsHidden()){
                return false; 
            }
        }
        return true;
    }
}