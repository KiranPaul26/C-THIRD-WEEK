using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*----------------------------------------- STANDARD EXERCISE -----------------------------------------------*/
            //char userInput;

            //List<string> bookTitles = new List<string>() { "Charlie and the Chocolate Factory", "James and the Jiant Peach", "The Hunger Games", "The BFG" };

            //Console.WriteLine("If you would like to add a book, enter a below. If not, enter x to quit.");
            //userInput = Convert.ToChar(Console.ReadLine());

            //do
            //{
            //    if(userInput == 'a')
            //    {
            //        Console.WriteLine("Enter the title of the book you would like to add...");
            //        string userBookTitle = Console.ReadLine();
            //        bookTitles.Add(userBookTitle);

            //        Console.WriteLine("If you would like to add another book enter a below or x to quit...");
            //        userInput = Convert.ToChar(Console.ReadLine());
            //    }

            //} while (userInput != 'x');

            //foreach (string item in bookTitles)
            //{
            //    Console.WriteLine(item);
            //}

            /*----------------------------------------- STANDARD EXERCISE -----------------------------------------------*/

            List<string> bookTitles = new List<string>() { "Charlie and the Chocolate Factory", "James and the Jiant Peach", "Me Before You", "The BFG" };
            char userInput;

            Console.WriteLine("The list of Book Titles we already have are:");
            Console.WriteLine();
            foreach (string item in bookTitles)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("If you would like to Add a book enter a. If you would like to Delete a book enter d. If you would like to List the books enter l. If you would like to Sort the books enter s.");
            userInput = Convert.ToChar(Console.ReadLine());

            switch(userInput)
            {
                case('a'):
                    Console.WriteLine("Enter a Book Title below...");
                    string userBookTitle = Console.ReadLine();
                    bookTitles.Add(userBookTitle);
                    break;
            }

        }
    }
}
