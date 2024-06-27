using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intermediate_C_
{
    public delegate void my_delegate(int num); 
    public class Program
    {
        public static void MyMethod(my_delegate del ,int a)
        {
            a += 10;
            del.Invoke(a);
        }
        static void Main(string[] args)
        {
            Program.MyMethod(delegate (int b)
            {
                b += 10;
                Console.WriteLine(b);
            }, 5);
            //my_delegate md = delegate (int num)
            //{
            //    num += 10;
            //    return num;
            //};
            //Console.WriteLine(md.Invoke(52));
            Console.ReadLine();
        }
    }
}
