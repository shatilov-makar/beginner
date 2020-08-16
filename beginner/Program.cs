using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var carList = new List<Car>();
            carList.Add(car);


            var animal = new Animal();
            var zoo = new List<Car>();
            zoo.Add(car);

            Console.WriteLine("Hello world new branch!");
            Console.ReadKey();
        }
    }
}
