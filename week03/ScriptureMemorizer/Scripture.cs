using System.Runtime.InteropServices;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] scriptWord = text.Split(" ");
        for (int i = 0; i < scriptWord.Length; i++)
        {
            Word word = new Word(scriptWord[i]);
            _words.Add(word);
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < 3)
        {
            if (IsCompleteHidden())
            {
                break;
            }

            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }


    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string scriptureText = "";

        for (int i = 0; i < _words.Count; i++)
        {
            scriptureText += _words[i].GetDisplayText() + " ";
        }

        return referenceText + " " + scriptureText.Trim();
    }

    public bool IsCompleteHidden()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}