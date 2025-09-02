using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSlight
{
    internal class Program
    {
        static void Main(string[] args) {

           Console.WriteLine("Write: 1000-7 ");
            string zxc = Console.ReadLine();
            int b = 7;
            int a = 1000;
            if (zxc == "1000-7" || zxc == "1000 -7" || zxc == "1000 - 7" || zxc == "1000- 7")
            {
                while (a  > b)
                {
                    Console.WriteLine(a-b);
                    a -= b;
                }

            }
            Console.ReadKey();  
       } 
    }
}

 

