using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {



    Prompt promptGenerator = new Prompt(); 


    string promptText = promptGenerator.GetRandomPrompt();
    Console.WriteLine(promptText);
    }
    public class Journal
    {
    
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"{entry._date} - {entry._promptText}");
            Console.WriteLine(entry._entryText);
            Console.WriteLine();
        }
    }
        public void SaveToFile(string filename)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"Date: {entry._date}, prompt: {entry._promptText}: {entry._entryText}");
                }
            }
        }


    public void LoadFromFile(string filename)
    {

        
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                _entries.Add(entry);
            }            
        }
    

    }


    
}

}