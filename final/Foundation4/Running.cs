using System.ComponentModel.DataAnnotations;

public class Running : Activity {
    private double _distance;

    public Running(String date, double length, String type, double distance) :base(date, length, type){
        _distance = distance;
    }
    public override string GetDistance()
    {
        return $"Distance {_distance} km";
    }

    public override String GetSpeed()
    {
        double speed = (_distance/_length)*60;
        return $"Speed: {speed} km/h";
    }

    public override string GetPace()
    {
        double pace = _length/_distance;
        return $"Pace: {pace} min/km";
    }
}