using System.Globalization;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }


    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))

        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._rateToday},{entry._promptText},{entry._entryText}");
            }
        }

    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)

        {
            string[] parts = line.Split(",");
            if (parts.Length == 4)
            {
                Entry loadFile = new Entry();
                loadFile._date = parts[0];
                loadFile._rateToday = parts[1];
                loadFile._promptText = parts[2];
                loadFile._entryText = parts[3];
                _entries.Add(loadFile);

            } 

        }

    }



}