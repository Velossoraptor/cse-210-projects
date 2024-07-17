public class Outdoor : Event {
    private String _weather;

    public Outdoor(String title, String description, String date, String time, Address address, String weather) : base(title, description, date, time, address){
        _weather = weather;
    }

    public void FullDetails(){
        StandardDetails();
        Console.WriteLine($"Type: Outdoor");
        Console.WriteLine($"Weather: {_weather}");
    }
    public void ShortDescription(){
        Console.WriteLine($"Type: Outdoor");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
}