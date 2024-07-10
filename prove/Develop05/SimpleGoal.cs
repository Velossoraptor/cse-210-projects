public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(String name, String description, String points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(String name, String description, String points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }


    public override int RecordEvent()
    {
        if (!IsCompleted())
        {
            _isComplete = true;
            return int.Parse(_points);
        }
        else
        {
            return 0;
        }

    }

    public override bool IsCompleted()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{_shortName},{_description},{_points},{_isComplete}";
    }
}