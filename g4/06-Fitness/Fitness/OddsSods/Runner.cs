using System;
using System.Collections.Generic;
using System.Text;

namespace OddsSods
{
    public abstract class Runner
    {
        public abstract void Run();
    }

    public interface IRunner
    {
        void Run();
    }

}
