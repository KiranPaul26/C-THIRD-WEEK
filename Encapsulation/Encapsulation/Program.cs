using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 0;

            //add some meals data
            Meal steak = new Meal("steak", 20.00M, 5.00M);

            Meal fajitas = new Meal("fajitas", 12.00M, 2.00M);

            Meal pumpkinRisotto = new Meal("pumpkinRisotto", 10.00M, 1.00M);

            Order order1 = new Order();
            order1.takeOrder(steak);
            Meal.cookMeal(steak);
            Accounts.calculate(steak);
            //Console.WriteLine("This meal " + steak + " has been cooked.");
            

            Order order2 = new Order();
            order2.takeOrder(pumpkinRisotto);
            Meal.cookMeal(pumpkinRisotto);
            Accounts.calculate(pumpkinRisotto);
            //Console.WriteLine("This meal " + pumpkinRisotto + " has been cooked.");

            balance = Accounts.reportBalance();


            Console.WriteLine("Tonight in the restaurant, we made £{0:N2}.", balance);

        }
    }

    public class Meal
    {
        public string name;
        public decimal price;
        public decimal cost;

        public Meal(string name, decimal price, decimal cost)
        {
            this.name = name;
            this.price = price;
            this.cost = cost;
        }

        public static void cookMeal(Meal meal)
        {
            Console.WriteLine("The meal {0} has been cooked.", meal.name);
            
        }
    }


    //THIS IS THE RIGHT WAY OF WRITING THE CODE WITH THIS CLASS
    public class Accounts
    {
        private static decimal _balance = 0;

        public static void calculate(Meal meal)
        {
            _balance = _balance + meal.price;
            _balance = _balance - meal.cost;
            Console.WriteLine("The price of the meal is " + meal.price + ". The cost of the meal is " + meal.cost);

        }

        public static decimal reportBalance()
        {
            return _balance;
        }
    }


    public class Order
    {
        public void takeOrder(Meal meal)
        {
            Console.WriteLine("The meal {0} has been ordered.", meal.name);
        }
    }

}