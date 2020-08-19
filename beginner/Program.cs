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
            var zoo = new List<Animal>();
            zoo.Add(animal);

            Console.WriteLine("Hello world terminal!");
            Console.ReadKey();
        }
    }
}
