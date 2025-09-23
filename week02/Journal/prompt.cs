public class Prompt
{
    public List<string> _prompts = new List<string>()
    {
        "What was something that happened unexpectedly today? ",
        "What was your strongest emotion today? Why? ",
        "What was your favorite thing you ate today? ",
        "What were you most anxious about today? ",
        "What could you have done differently today? "
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(0, _prompts.Count);
        return _prompts[index];
    }
}

