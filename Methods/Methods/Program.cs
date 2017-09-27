using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Car.totalNumberCars = 0;

            Car myCar1 = new Car();
            myCar1.make = "Audi";
            myCar1.colour = "White";
            myCar1.price = 30000;
            myCar1.sold = true;

              Car.totalNumberCars++;

            Car myCar2 = new Car();
            myCar2.make = "BMW";
            myCar2.colour = "Black";
            myCar2.price = 20000;
            myCar2.sold = false;

              Car.totalNumberCars++;

            Car myCar3 = new Car();
            myCar3.make = "Range Rover";
            myCar3.colour = "Grey";
            myCar3.price = 50000;
            myCar3.sold = false;

              Car.totalNumberCars++;

            Console.WriteLine("We have " + Car.totalNumberCars + " cars in stock." + "\n" + "Make" + "\n" + "Colour" + "\n" + "Price");
            /*--- WITHOUT METHOD THIS IS HOW TO DISPLAY THE CARS ---*/
            //Console.WriteLine("These are:");
            //Console.WriteLine();
            //Console.WriteLine(myCar1.make + "\n" + myCar1.colour + "\n" + "£" + myCar1.price);
            //Console.WriteLine();
            //Console.WriteLine(myCar2.make + "\n" + myCar2.colour + "\n" + "£" + myCar2.price);
            //Console.WriteLine();
            //Console.WriteLine(myCar3.make + "\n" + myCar3.colour + "\n" + "£" + myCar3.price);
            //Console.WriteLine();

            /*--- CALLING THE NON-STATIC ADD DETAILS METHOD ---*/
            Car newCar = new Car();
            newCar.AddDetailsOfACar("Aston Martin", "Blue", 45000);


            /*--- CALLING THE NON-STATIC DISPLAY METHOD ---*/
            myCar1.DisplayCar();
            myCar2.DisplayCar();
            myCar3.DisplayCar();
            Console.WriteLine();

            /*--- CALLING THE NON-STATIC SELL METHOD ---*/
            myCar1.SellCar(50);
            


        }

    }

    class Car
    {
        public string make;
        public string colour;
        public int price;

        public bool sold;

        public static int totalNumberCars;

        /*--- NON-STATIC METHOD  ---*/
        public void AddDetailsOfACar(string make, string colour, int price)
        {
            this.make = make;
            this.colour = colour;
            this.price = price;
            //Console.WriteLine(make + colour + "£" + price);
        }


        /*--- NON-STATIC METHOD  ---*/
        public void DisplayCar()
        {
            Console.WriteLine("\n" + make + "\n" + colour + "\n" + "£" + price);

        }

        /*--- NON-STATIC METHOD ---*/
        public void SellCar(int price)
        {
            if(sold == true)
            {
                Console.WriteLine(sold + ". This car has been SOLD!");
            } else if(sold == false)
            {
                Console.WriteLine(sold + ". This car has not been Sold.");
            }
            
        }


    }
}
