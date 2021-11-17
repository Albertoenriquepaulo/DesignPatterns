using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemos.Strategy
{
    public class MotorcycleStrategy :IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Motorcycle Running");
        }
    }
}
