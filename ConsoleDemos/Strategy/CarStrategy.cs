using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemos.Strategy
{
    public class CarStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Car running");
        }
    }
}
