public class BreathingActivity : Activity
{
    public BreathingActivity()
    {

    }
    public void Run()
    {
        DisplayStartingMessage("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");


        while (_duration >= 5)
        {
            Console.WriteLine("Breathe in... ");
            ShowCountDown(5);
            _duration -= 5;
            Console.WriteLine("Breathe out... ");
            ShowCountDown(5);
            _duration -= 5;

        }
        DisplayEndingMessage("Breathing Activity");
    }
}