using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Bai2BacktrackingStrategy : IBai2Strategy
    {
        private int[] numbers;
        private int[] signs;
        private int[] minSigns;
        private int sum;
        private int minSum = Int32.MaxValue;
        private const string MY_EX_MES = "FindedMinSumEqualZero";

        public void Resolve(List<int> listNumber)
        {
            if (listNumber.Count > 0)
            {
                numbers = listNumber.ToArray();
                signs = new int[numbers.Length - 1];
                sum = numbers[0];
                try
                {
                    Try(0);
                    ShowResult();
                }
                catch (Exception e)
                {
                    if (e.Message == MY_EX_MES)
                        ShowResult();
                }

            }
            else Console.WriteLine("List empty!");
        }

        private void Try(int k)
        {
            for (int sign = -1; sign <= 1; sign = sign + 2) // sign -1 tương ứng -, sign 1 tương ứng +
            {
                signs[k] = sign;
                sum = sum + sign * numbers[k + 1];
                if (k == numbers.Length - 2) UpdateBest();
                else Try(k + 1);
                //signs[k] = 0;
                sum = sum - sign * numbers[k + 1];
            }
        }

        void UpdateBest()
        {
            //foreach (var s in signs)
            //{
            //    Console.Write(s + " ");
            //}
            //Console.Write(" => " + f);
            //Console.WriteLine();
            if (sum >= 0 && sum < minSum)
            {
                minSum = sum;
                minSigns = new int[signs.Length];
                Array.Copy(signs, minSigns, signs.Length);
                if (minSum == 0) throw new Exception(MY_EX_MES); // nếu gặp trường hợp có giá trị bằng 0 thì kết thúc. Không cần tìm nữa
            }
        }

        void ShowResult()
        {
            Console.Write(numbers[0]);
            for (int i = 0; i < minSigns.Length; i++)
            {
                if (minSigns[i] > 0) Console.Write(" + ");
                else Console.Write(" - ");

                if (numbers[i + 1] > 0)
                {
                    Console.Write(numbers[i + 1]);
                }
                else
                {
                    Console.Write($"({numbers[i + 1]})");
                }
            }
            Console.WriteLine(" = " + minSum);
        }

    }
}
