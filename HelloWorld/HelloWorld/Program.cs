using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            /*-------------------------------------------------------- THIS IS NUMBER GAME ----------------------------------------------------------*/

            //Random rand = new Random();
            //int numToGuess = rand.Next(1, 11);
            //Console.WriteLine(numToGuess);
            //int number;

            //Console.WriteLine("Please enter a number");
            //number = Convert.ToInt32(Console.ReadLine());

            //JUST ONE CHANCE AT GUESSING
            //if (number == numToGuess)
            //{
            //    Console.WriteLine("You guessed RIGHT!");
            //}
            //else if (number < numToGuess)
            //{
            //    Console.WriteLine("Too Low");
            //}
            //else if (number > numToGuess)
            //{
            //    Console.WriteLine("Too High");
            //}

            //AS MANY GUESSES USING THE DO WHILE LOOP
            //do
            //{
            //    Console.WriteLine("Please enter a number");
            //    number = Convert.ToInt32(Console.ReadLine());

            //    if (number == numToGuess)
            //    {
            //        Console.WriteLine("You guessed RIGHT!");

            //    }
            //    else if (number < numToGuess)
            //    {
            //        Console.WriteLine("Too Low");
            //        number = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else if (number > numToGuess)
            //    {
            //        Console.WriteLine("Too High");
            //        number = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //while ((number != numToGuess));

            /*----------------------------------------------------- HELLO WORLD ON CONSOLE ----------------------------------------------------*/

            //Console.WriteLine("Hello, World");
            //Console.ReadLine();

            /*-------------------------------------------------- USING SWITCH CASE ------------------------------------------------------------*/

            //Console.WriteLine("Who is the better singer out of Destiny's Child: Beyonce Knowles, Kelly Rowland or Michelle Williams.");
            //string yourChoice = (Console.ReadLine()).ToLower(); //For this to work the case values have to be in lowercase

            //switch (yourChoice)
            //{
            //    case ("beyonce knowles"):
            //    case ("beyonce"):
            //    case ("knowles"):
            //        Console.WriteLine("Of course she is!");
            //        break;
            //    case ("kelly rowland"):
            //    case ("kelly"):
            //    case ("rowland"):
            //        Console.WriteLine("She is ok.");
            //        break;
            //    case ("michelle williams"):
            //    case ("michelle"):
            //    case ("williams"):
            //        Console.WriteLine("She is definitely the WORST!");
            //        break;
            //    default:
            //        Console.WriteLine("Enter one of the singers please...");
            //        break;
            //}

            /*-------------------------------------------------- USING WHILE AND DO LOOP ------------------------------------------------------------*/

            //Console.WriteLine("There was a plane crash every single person died. Who survived?");
            //string answer = "";
            //answer = (Console.ReadLine()).ToLower();


            //while ((answer != "married couples") && (answer != "couples"))
            //{
            //    Console.WriteLine("Take another guess...");
            //    answer = (Console.ReadLine()).ToLower();

            //}
            //Console.WriteLine("YOU GUESSED RIGHT!");


            //Console.WriteLine("Feed me and I live, yet give me a drink and I die");

            //do {
            //    Console.WriteLine("Take a guess...");
            //    answer = (Console.ReadLine()).ToLower();

            //}
            //while (answer != "fire") ;
            //Console.WriteLine("YOU GUESSED RIGHT!");

            /*-------------------------------------------------- USING FOR AND FOREACH  ------------------------------------------------------------*/

            //string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
            //string mealAnswer = "";

            //for (int i = 0; i < sevenDwarves.Length; i++)
            //{
            //    Console.WriteLine("What would you like for dinner " + sevenDwarves[i] + "?");
            //    mealAnswer = Console.ReadLine();
            //    Console.WriteLine(sevenDwarves[i] + ", your " + mealAnswer + " is ready!");
            //}

            //Console.WriteLine();
            //string drinkAnswer = "";

            //foreach(string i in sevenDwarves)
            //{
            //    Console.WriteLine("What drink would you like " + i + "?");
            //    drinkAnswer = Console.ReadLine();
            //    Console.WriteLine(i + ", your " + drinkAnswer + " is ready!");
            //}

            /*-------------------------------------------------- USING   ------------------------------------------------------------*/


        }
    }
}
