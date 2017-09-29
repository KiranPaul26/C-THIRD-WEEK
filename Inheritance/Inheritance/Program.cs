using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesInheritance
{
    class Vehicle
    {
        public string make;
        public string model;
        public int price;
        public Boolean sold;

        public static int totalValueSold = 0;
        public static int totalValueInStock = 0;

        //CONSTRUCTOR
        public Vehicle(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            totalValueInStock += price;
        }

        //NON-STATIC METHOD
        public void DisplayOneVehicle()
        {
            //display details for an individual car
            Console.WriteLine("The details of this vehicle are: ");
            Console.Write("Make and model: {0} {1}, price: £{2:N0}.", make, model, price);  //:N0 formats the number
            if (sold)
            {
                Console.WriteLine("This vehicle has been sold.");
            }
            else
            {
                Console.WriteLine("This vehicle has not yet been sold.");
            }
            Console.WriteLine();
        }

        //record the sale of a vehicle
        public void Sold(int price)
        {
            this.sold = true;
            this.price = price;

            Vehicle.totalValueSold += price;
            Vehicle.totalValueInStock -= price;

        }

        //list all the cars
        public static void DisplayAllVehicles(List<Vehicle> allVehicles)
        {
            foreach (Vehicle item in allVehicles)
            {
                string type = "";

                if (item is Car)
                {
                    type = "car";
                }
                else if (item is Motorcycle)
                {
                    type = "motorbike";
                }
                Console.WriteLine("The details of this {0} are: ", type);
                Console.Write("Make and model: {0} {1}, price: £{2:N0}.", item.make, item.model, item.price);  //:N0 formats the number
                if (item.sold)
                {
                    Console.WriteLine("This {0} has been sold.", type);

                }
                else
                {
                    Console.WriteLine("This {0} is unsold.", type);

                }
            }

            Console.WriteLine();
            Console.WriteLine("The total value of vehicles sold is: £{0:N0}.", totalValueSold);
            Console.WriteLine("The total value of vehicles in stock is: £{0:N0}.", totalValueInStock);

            Console.WriteLine();
        }


    }//end of Vehicle class

    class Car : Vehicle
    {
        public static int numberOfCars;

        public Car(string make, string model, int price) : base(make, model, price)
        {
            numberOfCars++;
        }

        //record the sale of a car
        public void Sold(int price)
        {
            base.Sold(price);
            //adjust the number of cars
            numberOfCars--;
        }
        public static void DisplayAllCars(List<Vehicle> allVehicles)
        {
            foreach (Vehicle v in allVehicles)
            {
                if (v is Car)
                {
                    Console.WriteLine("Make: {0} Model: {1} Price: {2}", v.make, v.model, v.price);
                }

            }
        }


    }//end of Car class

    class Motorcycle : Vehicle
    {
        public static int numberOfBikes;

        public Motorcycle(string make, string model, int price, string type = "motorcycle") : base(make, model, price)
        {
            numberOfBikes++;
        }

        //record the sale of a bike
        public void Sold(int price)
        {
            base.Sold(price);
            //adjust the number of bikes
            numberOfBikes--;
        }

        public static void DisplayAllBikes(List<Vehicle> allVehicles)
        {
            foreach (Vehicle v in allVehicles)
            {
                if (v is Motorcycle)
                {
                    Console.WriteLine("Make: {0} Model: {1} Price: {2}", v.make, v.model, v.price);
                }

            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car.numberOfCars = 0;
            Motorcycle.numberOfBikes = 0;

            List<Vehicle> allVehicles = new List<Vehicle>();

            //add vehicles
            Car car1 = new Car("RollsRoyce", "Silver Cloud", 35000);
            allVehicles.Add(car1);

            Car car2 = new Car("Aston Martin", "DB5", 750000);
            allVehicles.Add(car2);

            Car car3 = new Car("Reliant", "Robin", 550);
            allVehicles.Add(car3);

            Motorcycle bike1 = new Motorcycle("Triumph", "Tiger 800", 10000);
            allVehicles.Add(bike1);

            Motorcycle bike2 = new Motorcycle("Vespa", "Sprint 150", 2500);
            allVehicles.Add(bike2);

            //display cars data
            Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
            Console.WriteLine("Total number of motorbikes in stock is: {0}", Motorcycle.numberOfBikes);
            Console.WriteLine();

            Vehicle.DisplayAllVehicles(allVehicles);

            //record the sale of a car and a bike
            car3.Sold(350);
            bike2.Sold(2000);

            //display cars data
            Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
            Console.WriteLine("Total number of motorbikes in stock is: {0}", Motorcycle.numberOfBikes);
            Console.WriteLine();

            Vehicle.DisplayAllVehicles(allVehicles);
            Console.WriteLine();
            Console.WriteLine("List of all cars:");
            Car.DisplayAllCars(allVehicles);

            //finding an object in the list using a property
            //string userInput = "Vespa";

            //int index = allVehicles.FindIndex(item => item.make == userInput);
            //if (index >= 0)
            //{
            //    // element exists, do what you need
            //    Console.WriteLine("{0} is in the list", userInput);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is not in the list", userInput);
            //}

        }
    }
}


