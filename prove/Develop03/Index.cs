using System;

public class Index
{
    private static Reference reference = new Reference();

    public int _index = Randomize();
    static int Randomize()
        {
            var random = new Random();

            return random.Next(reference.GetListLength());
        }
}