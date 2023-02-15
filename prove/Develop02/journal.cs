
using System;
using System.IO;
public class Journal
{
    public List<int> _qualities = new List<int>();
    public string _entry = "";

    public void WriteJournal()
    {
        string fileName = "journal.txt";

        using (StreamWriter outputFile = File.AppendText(fileName))
        {
            outputFile.WriteLine(_entry);
        }
    }

    public void ReadJournal()
    {
        string fileName = "journal.txt";
        Console.WriteLine(System.IO.File.ReadAllText(fileName));
    }

    public void CalcAveQual()
    {
        int qualTotal = 0;
        int qualAmount = 0;

        foreach (int value in _qualities)
        {
            qualTotal += value;
            qualAmount += 1;
        }

        int qualAve = qualTotal / qualAmount;

        Console.WriteLine($"The average quality of your days has been {qualAve}");
    }
}