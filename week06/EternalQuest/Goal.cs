public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"Name: {_shortName}, Description: {_description}";
    }
    public abstract string GetStringRepresentation();
    public int GetPoints()
    {
        return _points;
    }
    
}