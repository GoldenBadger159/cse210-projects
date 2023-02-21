using System;

public class Reference
{
    private string _reference = "";
    private List<string> _references = new List<string>(){
        "1st Nephi 3:7","Moses 1:39","Matthew 28:19-20","Moses 7:18", "D&C 6:36"
    };

    public string RandReference(int index)
    {
        _reference = _references[index];
        return _reference;
    }

    public int GetListLength()
    {
        return _references.Count();
    }
}