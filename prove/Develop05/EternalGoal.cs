public class EternalGoal : Goal {
    public EternalGoal(String name, String description, String points) : base(name, description, points){

    }

    public override int RecordEvent()
    {
        return int.Parse(_points);
    }

    public override bool IsCompleted()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{_shortName},{_description},{_points}";
    }
}