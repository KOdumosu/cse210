
public class Comment
{
    public string _commenter;
    public string _text;

    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
    }

    public string GetCommenter()
    {
        return _commenter;
    }
    public void SetCommenter(string commenter)
    {
        _commenter = commenter;
    }
    public string GetText()
    {
        return _text;
    }
    public void SetText(string text)
    {
        _text = text;
    }
}
