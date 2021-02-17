using System;

namespace ArrPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Nums = { 1, 2, 3 };
            int x = 0;
            int i = 0;
            bool leastOne = false;

            while (i < Nums.Length)
            { 
                x = i;
                while (x < Nums.Length)
                {
                    if (Nums[i] == Nums[x] && x != i)
                    {
                        Console.Write("(" + i + "," + x + ") ");
                        leastOne = true;
                    }
                x++;
                }
            i++;
            }

            if (leastOne == false)
            {
                Console.WriteLine("0");
            }
        }
    }
}
