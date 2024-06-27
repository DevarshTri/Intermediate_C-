using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace intermediate_C_
{
    public delegate void my_delegate(int num); 
    public class Program
    {
        public static void MyMethod(int a)
        {
            a += 10;
            
        }
        static void Main(string[] args)
        {
            //Program.MyMethod(delegate (int b)
            //{
            //    b += 10;
            //    Console.WriteLine(b);
            //}, 5);

            my_delegate md = (num) =>
            {
                num += 10;
                
                Console.WriteLine(num);
            };
            md.Invoke(52);
            Console.ReadLine();
        }
    }
}
