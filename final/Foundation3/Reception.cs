public class Reception : Event {
    private String _rsvpEmail;

    public Reception(String title, String description, String date, String time, Address address, String rsvp) : base(title, description, date, time, address){
        _rsvpEmail = rsvp;
    }

    public void FullDetails(){
        StandardDetails();
        Console.WriteLine($"Type: Reception");
        Console.WriteLine($"RSVP @: {_rsvpEmail}");
    }
    public void ShortDescription(){
        Console.WriteLine($"Type: Reception");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
}