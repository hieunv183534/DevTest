using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coca
{
    public class CocaContext
    {
        private ICocaCalculateStrategy strategy;

        public int CocaInitCount { get; set; }

        public void SetStrategy(ICocaCalculateStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int Calculate()
        {
            return this.strategy.Calculate(this.CocaInitCount);
        }
    }
}
