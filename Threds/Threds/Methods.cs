using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threds
{
    internal class Methods
    {
        public static void Print1()
        {
            int a=0;
            for (int i = 0; i < 1000; i++)
            {
                 a++;
                Console.WriteLine(a);
                Thread.Sleep(100);
            }
        }
        public static void Print2()
        {
            while (true)
            {
                Console.WriteLine("Xnjns nen pf,sk");
                Thread.Sleep(1000);
            }
            
        }
        public static void Print3()
        {
            while (true)
            {
                Console.WriteLine("~_~");
                Thread.Sleep(800);
            }
            
        }
        public static void Print4()
        {
            while (true)
            {
                Console.WriteLine("зачем ты тут?");
                Thread.Sleep(10);
            }
            
        }
    }

}
