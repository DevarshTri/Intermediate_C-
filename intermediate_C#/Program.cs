using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intermediate_C_
{
    public delegate int my_delegate(int num); 
    public class Program
    {
        //public static void MyMethod(int a)
        //{
        //    a += 10;
        //    Console.WriteLine(a);
        //}
        static void Main(string[] args)
        {
            my_delegate md = delegate (int num)
            {
                num += 10;
                return num;
            };
            Console.WriteLine(md.Invoke(52));
            Console.ReadLine();
        }
    }
}
