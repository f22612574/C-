using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("請輸入成績: ");
            a = int.Parse(Console.ReadLine());
            if (a >= 60)
                Console.WriteLine("及格");
                
            else
                Console.WriteLine("不及格");
            
        }
    }
}
