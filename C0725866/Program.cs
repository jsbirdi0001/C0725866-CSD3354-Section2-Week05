using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            MethodA();
            Console.ReadLine();
        }
        static void MethodA()
        {
            
            while (Peanut())
            {
                Console.WriteLine("The value of i is {0}",i);
                if (i > 10)
                {
                    return;
                }
            }
        }
        static bool Peanut()
        {
            i++;
            return true;
        }

    }
}
