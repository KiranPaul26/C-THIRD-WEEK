using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectsFields
{
    class Program
    {
        static void Main(string[] args)
        {
            Car.numberCars = 0;

            Car myCar1 = new Car();
            myCar1.make = "Audi";
            myCar1.colour = "White";
            myCar1.price = 30000;

              Car.numberCars++;

            Car myCar2 = new Car();
            myCar2.make = "BMW";
            myCar2.colour = "Black";
            myCar2.price = 20000;

              Car.numberCars++;

            Car myCar3 = new Car();
            myCar3.make = "Range Rover";
            myCar3.colour = "Grey";
            myCar3.price = 50000;

              Car.numberCars++;

            Console.WriteLine("We have " + Car.numberCars + " cars in stock." + "\n" + "These are:");
            Console.WriteLine();
            Console.WriteLine(myCar1.make + "\n" + myCar1.colour + "\n" + "£" + myCar1.price);
            Console.WriteLine();
            Console.WriteLine(myCar2.make + "\n" + myCar2.colour + "\n" + "£" + myCar2.price);
            Console.WriteLine();
            Console.WriteLine(myCar3.make + "\n" + myCar3.colour + "\n" + "£" + myCar3.price);



        }
    }

    class Car
    {
        public string make;
        public string colour;
        public int price;

        public static int numberCars;
    }

    
}
