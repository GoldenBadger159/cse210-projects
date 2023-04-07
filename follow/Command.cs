using System;

namespace Test1
{
    class Command
    {
        public virtual void Execute()
        {
            throw new Exception("method not implemented in the baseline");
        }
    }
}