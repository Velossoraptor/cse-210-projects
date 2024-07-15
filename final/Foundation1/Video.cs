using System.Reflection;
using System.Transactions;

public class Video {
    public String _title;
    public String _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public Video(String title, String author, int length){
        _title = title;
        _author = author;
        _length = length;
    }

    public int GetNumComments(){
        return _comments.Count;
    }
}