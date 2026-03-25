public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        int numberOfComments = _comments.Count;
        return numberOfComments;
    }

    public string GetDisplayText()
    {
        return "Title: " + _title + " | Author: " + _author + " | Length: " + _length + " seconds" + " | Comments: " + NumberOfComments();
    }
    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.GetDisplayText()}");
        }
    }
}