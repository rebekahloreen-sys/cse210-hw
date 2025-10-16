public class BikingExercise : Exercise
{
    private float _speed;
     public BikingExercise(int timeLength, float speed) : base(timeLength)
    {
        _speed = speed;
    }
    public override string ExerciseType()
    {
        return "Biking";
    }

    public override float CalculateDistance()
    {
        return (_speed / _timeLength) * 60f;
    }
    public override float CalculateSpeed()
    {
        return _speed;
    }
    public override float CalculatePace()
    {
        return _timeLength / CalculateDistance();
    }
}