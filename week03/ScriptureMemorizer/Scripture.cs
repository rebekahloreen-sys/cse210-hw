public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        var notHidden = _words.Where(w => !w.IsHidden()).ToList();

        if (numberToHide > notHidden.Count)
        {
            numberToHide = notHidden.Count;
        }
        for (int i = 0; i < numberToHide; i++)
        {
            int index = rand.Next(notHidden.Count);
            notHidden[index].Hide();
            notHidden.RemoveAt(index);
        }
        
    }
    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        
        return $"{_reference.GetDisplayText()} {text}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}