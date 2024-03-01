using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coca
{
    public class CocaCalculate2Strategy : ICocaCalculateStrategy
    {
        public int Calculate(int input)
        {
            var drinkedCount = 0;
            var remainingCount = input;

            while(remainingCount >= 3)
            {
                // 1 vòng lặp tương ứng 1 lần uống 3 chai
                drinkedCount += 3;
                remainingCount -= 2;
            }

            drinkedCount += remainingCount;
            return drinkedCount;
        }
    }
}
