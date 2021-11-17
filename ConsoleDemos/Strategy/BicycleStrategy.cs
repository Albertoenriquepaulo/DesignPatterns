using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemos.Strategy
{
    internal class BicycleStrategy : IStrategy
    {
        void IStrategy.Run()
        {
            Console.WriteLine("Bicycle Running");
        }
    }
}
