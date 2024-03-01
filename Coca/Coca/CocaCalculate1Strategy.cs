using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coca
{
    public class CocaCalculate1Strategy : ICocaCalculateStrategy
    {
        public int Calculate(int input)
        {
            if (input % 2 == 0)
                return (input * 3 - 2) / 2;
            else
                return (input * 3 - 1) / 2;
        }
    }
}
