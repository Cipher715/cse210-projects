public class Comment{
    private string _username;
    private string _body;

    public Comment(string username, string body) {
        _username = username;
        _body = body;
    }

    public string GetDisplayText(){
        return $"{_username} : {_body}";
    }
}