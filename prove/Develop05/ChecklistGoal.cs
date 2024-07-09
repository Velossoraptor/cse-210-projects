public class ChecklistGoal : Goal {
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(String name, String description, String points, int target, int bonus) : base(name, description, points){
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if(IsCompleted()){
            return _bonus;
        }else{
            return int.Parse(_points);
        }
    }

    public override bool IsCompleted()
    {
        if(_target == _amountCompleted){
            return true;
        }else{
            return false;
        }
    }

    public override string GetDetailsString()
    {
        if(IsCompleted()){
            return $"[X] {_shortName}: ({_description}) -- Completed {_amountCompleted}/{_target} times";
        }else{
            return $"[ ] {_shortName}: ({_description}) -- Completed {_amountCompleted}/{_target} times";
        }
        
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_target},{_amountCompleted},{_bonus}";
    }


}