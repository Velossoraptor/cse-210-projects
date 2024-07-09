public abstract class Goal {
    protected String _shortName;
    protected String _description;
    protected String _points;

    public Goal(String name, String description, String points){
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsCompleted();

    public virtual String GetDetailsString(){
        if(IsCompleted()){
            return $"[X] {_shortName}: ({_description})";
        }else{
            return $"[ ] {_shortName}: ({_description})";
        }
        
    }

    public String GetName(){
        return _shortName;
    }

    public abstract String GetStringRepresentation();
}