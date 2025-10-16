public abstract class Exercise
{
    protected DateTime _date;
    protected int _timeLength;


    public Exercise(int timeLength)
    {
        _timeLength = timeLength;
        _date = DateTime.Now;
    }
    public abstract float CalculateSpeed();
    public abstract float CalculateDistance();
    public virtual string ExerciseType()
    {
        return "";
    }
    public abstract float CalculatePace();
    public virtual string GetSummary()
    {
        return $"{_date:dd MM yyyy} {ExerciseType()}({_timeLength} min)- Distance {CalculateDistance():0.0} miles, Speed: {CalculateSpeed():0.0} mph, Pace: {CalculatePace():0.00} mins per mile";
    }
}