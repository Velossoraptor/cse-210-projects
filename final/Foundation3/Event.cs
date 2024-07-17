using System.ComponentModel.Design;

public class Event {
    protected String _title;
    protected String _description;
    protected String _date;
    protected String _time;
    protected Address _address;

    public Event(String title, String description, String date, String time, Address address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void StandardDetails(){
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
    }
}