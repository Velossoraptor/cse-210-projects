public class Lecture : Event {
    private String _speaker;
    private int _capacity;

    public Lecture(String title, String description, String date, String time, Address address, String speaker, int capacity) : base(title, description, date, time, address){
        _speaker = speaker;
        _capacity = capacity;
    }

    public void FullDetails(){
        StandardDetails();
        Console.WriteLine($"Type: Lecture");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity {_capacity}");
    }
    public void ShortDescription(){
        Console.WriteLine($"Type: Lecture");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
}