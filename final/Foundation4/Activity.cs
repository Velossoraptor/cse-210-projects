public class Activity {
    protected String _date;
    protected double _length;

    protected String _type;

    public Activity(String date, double length, String type){
        _date = date;
        _length = length;
        _type = type;
    }

    public virtual String GetDistance(){
        return "";
    }

    public virtual String GetSpeed(){
        return "";
    }

    public virtual String GetPace(){
        return "";
    }

    public void GetSummary(){
        Console.WriteLine($"{_date} {_type} ({_length} min): {GetDistance()}, {GetSpeed()}, {GetPace()}");
    }
}