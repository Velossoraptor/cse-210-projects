public class Cycling : Activity {
    private int _speed;

    public Cycling(String date, double length, String type, int speed) : base(date, length, type){
        _speed = speed;
    }
    public override string GetDistance()
    {
        double dist = _speed*(_length/60);
        return $"Distance {dist} km";
    }

    public override String GetSpeed()
    {
        return $"Speed: {_speed} km/h";
    }

    public override string GetPace()
    {
        double pace =  60/_speed;
        return $"Pace: {pace} min/km";
    }
}