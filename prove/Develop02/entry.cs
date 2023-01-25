using System.Collections.Generic;


public class Entry 
{
    public string _entry = "";
    public int _quality = 0;

    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }
}