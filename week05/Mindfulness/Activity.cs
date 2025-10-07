public class Activity
{

    protected int _duration;
    private int _initialDuration;

    public Activity()
    {

    }
    public Activity(int duration, int initialDuration)
    {
        _initialDuration = initialDuration;
        _duration = duration;
    }
    public void DisplayStartingMessage(string name, string description)
    {
        Console.WriteLine($"You've chosen to do {name}!");
        Console.WriteLine(description);        
        Console.Write("How long would you like for this session to be, in seconds? ");
        _duration = int.Parse(Console.ReadLine());
        _initialDuration = _duration;
        Console.WriteLine("Prepare to begin");
        ShowCountDown(4);

    }
    public void DisplayEndingMessage(string name)
    {
        Console.WriteLine("Good job on completing this activity!");
        ShowSpinner(3);
        Console.WriteLine($"You spent {_initialDuration} seconds doing {name}.");
        ShowSpinner(4);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationFrames = new List<string>() { "|", "/", "-", "\\" };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationFrames[i];
            Console.Write(s);
            Thread.Sleep(250);
            seconds--;
            Console.Write("\b \b");

            i++;

            if (i >= animationFrames.Count())
            {
                i = 0;
            }
        }

    }
    public void ShowCountDown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            seconds--;
            Console.Write("\b \b");         
        }

    }
}