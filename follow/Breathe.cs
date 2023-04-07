using System;

namespace Test1
{
    class Breathe : Command
    {
        public override void Execute()
        {
            Console.WriteLine("this is the breathing command");
        }
    }
}