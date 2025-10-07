using System.Net;
using System.Security.Cryptography;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _responses = new List<string>();
    private string _userResponse;

    public ListingActivity()
    {

    }
    public ListingActivity(List<string> prompts, string userResponse, List<string> responses)
    {
        _prompts = prompts;
        _responses = responses;
        _userResponse = userResponse;
    }
    public void Run()
    {
        DisplayStartingMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Console.WriteLine("When I say go, start listing answers to this prompt: ");
        GetRandomPrompt();
        ShowCountDown(5);
        Console.WriteLine("Go!");
        Task.Run(() =>
        {
            while (_duration > 0)
            {
                Thread.Sleep(1000);
                _duration--;
            }
        });
        GetListFromUser();
        Console.WriteLine("Time's up!");
        Thread.Sleep(1000);
        Console.WriteLine("You put in " + _responses.Count() + " answers.");

        DisplayEndingMessage("Listing Activity");
    }
    public void GetRandomPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random random = new Random();

        int randomPrompt = random.Next(0, 4);
        Console.WriteLine($"Your prompt is: {_prompts[randomPrompt]}");
    }
    public List<string> GetListFromUser()
    {
        while (_duration > 0)
        {
            Console.WriteLine("");
            _userResponse = Console.ReadLine();
            _responses.Add(_userResponse);            
        }

        return _responses;
    }
}