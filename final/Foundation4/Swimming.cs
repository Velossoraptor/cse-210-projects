public class Swimming : Activity {
    private int _numLaps;

    public Swimming(String date, double length, String type, int numLaps) : base(date, length, type){
        _numLaps = numLaps;
    }
    public override string GetDistance()
    {
        double dist = Convert.ToDouble((_numLaps*50)/1000);
        return $"Distance {dist} km";
    }

    public override String GetSpeed()
    {
        double speed = (Convert.ToDouble((_numLaps*50)/1000))/_length*60;
        return $"Speed: {speed} km/h";
    }

    public override string GetPace()
    {
        double pace = _length/(Convert.ToDouble((_numLaps*50)/1000));
        return $"Pace: {pace} min/km";
    }
}