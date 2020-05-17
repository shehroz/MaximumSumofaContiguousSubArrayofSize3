using System;

namespace SumofThreeConsecutiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 3, 5, 6, 9, 7 };
            int[] res = SumofThreeConsecutiveNumbers(Array,22);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
        public static int[] SumofThreeConsecutiveNumbers(int [] array,int targetSum)
        {
            int sum = 0;
            int NumbersToSum = 3;
            int[] res = new int[NumbersToSum];
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if(i >= NumbersToSum-1)
                {
                    if (sum == targetSum)
                    {
                        int index = 0;
                        for (int j = i; j >=(i-NumbersToSum+1); j--)
                        {
                            res[index++] = array[j];
                        }
                        return res;
                    }
                    else
                    {
                        sum = sum - array[i - NumbersToSum + 1];
                    }
                }
            }
            return res;
        }
    }
}
