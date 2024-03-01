using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Bai2Context
    {
        private IBai2Strategy strategy;

        public void SetStrategy(IBai2Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void Resolve(List<int> listInt)
        {
            strategy.Resolve(listInt);
        }
    }
}
