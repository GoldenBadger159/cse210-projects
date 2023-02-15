using System;
using System.Linq;


public class Scripture
{
    private static Index i = new Index();
    private static Reference r = new Reference();
    private static Text t = new Text();

    private string _reference = r.RandReference(i._index);

    private string _text = t.Randtext(i._index);

    private List<string> _words = new List<string>();

    private List<string> SplitText()
    {
        _words = _text.Split(" ").ToList();
        return _words;
    }

    private int GetWordsLength()
    {
        int length = _words.Count();
        return length;
    }

    private int GetRandomIndex()
    {
        Random random = new Random();
        return random.Next(GetWordsLength());
    }

    public string HideWords()
    {
        SplitText();
        Random random = new Random();
        var count = random.Next(4, 8);

        for (int i = 0; i < count; i++)
        {
            bool isAlpha = false;
            int index = 0;
            string word = "";
            int tries = 100;

            do {
                index = GetRandomIndex();
                word = _words[index];
                isAlpha = word.All(c => Char.IsLetter(c) || c == ',' || c == ':' || c == ' ' || c == ';');
                tries -= 1;
            } while (isAlpha != true && tries > 0);

            char[] chars = word.ToCharArray();
            int amount = chars.Length;

            List<string> letters = new List<string>();
            for (int a = 0; a < amount; a++)
            {
                letters.Add("_");
            }

            string newWord = String.Join("", letters);

            _words[index] = newWord;
        }

        _text = String.Join(" ", _words);
        return _text;
    }

    public void Display()
    {
        Console.WriteLine($"{_reference}: {_text}");
    }

}