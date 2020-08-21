using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world new branch in terminal!");
            WriteFactorialAsync(6);
            WriteFactorialAsync(2);
            WriteFactorialAsync(9);
            Console.ReadKey();
        }

        static async void WriteFactorialAsync(int num)
        {
            var res = await Task.Run(() =>
            {
                var r = 1;
                for (var i = 1; i <= num; i++)
                    r *= i;
                return r;
            });
            Console.WriteLine($"{num}! = {res}");
        }
    }
}
