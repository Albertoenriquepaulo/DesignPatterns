using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemos.Strategy
{
    public class Context
    {
        private IStrategy _strategy;


        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Run()
        {
            _strategy.Run();
        }
        
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
    }
}
