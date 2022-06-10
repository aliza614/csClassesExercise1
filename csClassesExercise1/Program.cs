using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csClassesExercise1
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Honda";
            car.Model = "Accord";
            car.Year = 1998;
            Console.WriteLine($"The make is {car.Make}");
            Console.WriteLine($"The model is {car.Model}");
            Console.WriteLine($"The year is {car.Year}");
        }
    }
}
