public class SwimmingExercise : Exercise
{
    private float _lapNumber;
    public SwimmingExercise(int timeLength, float lapNumber) : base(timeLength)
    {
        _lapNumber = lapNumber;
    }
    public override string ExerciseType()
    {
        return "Swimming";
    }
    public override float CalculateDistance()
    {
        return (float)(_lapNumber * 50 / 1000 * 0.62);
    }
    public override float CalculateSpeed()
    {
        return (CalculateDistance() / _timeLength) * 60f;
    }
    public override float CalculatePace()
    {
        return _timeLength / _lapNumber;
    }
    public override string GetSummary()
    {
        return $"{_date:dd MM yyyy} Swimming({_timeLength} min) - Distance: {_lapNumber} laps and {CalculateDistance():0.00} miles, Speed: {CalculateSpeed(): 0.0} mph, Pace: {CalculatePace(): 0.0} min per lap";
    }
}