using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_prac
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(true && false);
            

            Console.ReadLine();
        }
        static void sort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }

            }
        }
        static void d(int[] array)
        {
            Dictionary<int, int> elementsc = new Dictionary<int, int>();

            foreach (int element in array)
            {
                if (elementsc.ContainsKey(element))
                {
                    elementsc[element]++;
                }
                else
                {
                    elementsc[element] = 1;
                }
            }
            foreach(var item in elementsc)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine(item.Key);
                }
            }

        }
    }
}
