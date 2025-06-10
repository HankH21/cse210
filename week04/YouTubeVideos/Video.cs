public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comment;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comment = new List<Comment>();
    }

    public void GetCommentNumber()
    {
        int count = _comment.Count();
        Console.WriteLine($"Number of comments: {count}");
    }

    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return _comment;
    }

    public void GetVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
    }
}