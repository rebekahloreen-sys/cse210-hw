public class RunningExercise : Exercise
{
    private float _distance;
    public RunningExercise(int timeLength, float distance) : base(timeLength)
    {
        _distance = distance;
    }
    public override string ExerciseType()
    {
        return "Running";
    }
    public override float CalculateDistance()
    {
        return _distance;
    }
    public override float CalculateSpeed()
    {
        return (_distance / _timeLength) * 60f;
    }
    public override float CalculatePace()
    {
        return _timeLength / _distance;
    }
}