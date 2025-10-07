public class ReflectingActivity : Activity
{
    public List<string> _prompts = new List<string>();
    public List<string> _questions = new List<string>();

    public ReflectingActivity()
    {

    }
    public void Run()
    {
        DisplayStartingMessage("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        DisplayPrompt();
        ShowSpinner(8);
        Console.WriteLine();
        Console.WriteLine("Try to reflect on that while answering these questions.");
        
        while (_duration > 0)
        {
            Console.WriteLine();
            DisplayQuestion();
            ShowSpinner(10);
            _duration -= 10;
        }
        Console.WriteLine();
        DisplayEndingMessage("Reflecting Activity");
    }
    public string GetRandomPrompt()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        Random random = new Random();
        int randomPrompt = random.Next(0, 3);
        
        return _prompts[randomPrompt];
    }
    public string GetRandomQuestion()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        Random random = new Random();
        int randomQuestion = random.Next(0, 8);

        return _questions[randomQuestion];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Your prompt is: " + GetRandomPrompt());
    }
    public void DisplayQuestion()
    {
        Console.WriteLine("Your question is: " + GetRandomQuestion());
    }
}