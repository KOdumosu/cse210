
public class Video
{
    public string _title;
    public string _author;
    public int _lengthSeconds;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
    }

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }

    public int GetLengthSeconds()
    {
        return _lengthSeconds;
    }
    public void SetLengthSeconds(int lengthSeconds)
    {
        _lengthSeconds = lengthSeconds;
    }

    public void AddComment(string commenter, string text)
    {
        _comments.Add(new Comment(commenter, text));
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }
}
