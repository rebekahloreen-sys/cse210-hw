public class Entry
{
    public string _promptText;
    public string _entryText;
    public string _date;
    public void Display()
    {
        Console.Write($"Date: {_date}, Prompt: {_promptText}: {_entryText}");
    }
}
