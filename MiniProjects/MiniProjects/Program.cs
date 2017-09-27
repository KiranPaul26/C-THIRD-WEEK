using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjects
{
    class Program
    {
        static void Main(string[] args)
        {

            /*------------------------------- QUICKSORT --------------------------------*/


            /*------------------------------- BUBBLE SORT --------------------------------*/


            /*------------------------------- A HOUSE PRICE CALCULATOR --------------------------------*/


            /*------------------------------- A 'GUESS THE WORD' GAME --------------------------------*/








            /*------------------------------- LIST OF BOOKS AND AUTHORS = ALLOWS ADDING, DELETING AND SORTING BOOKS --------------------------------*/

            List<string> bookTitles = new List<string>() { "The Hunger Games", "The BFG", "Me Before You" };

            Console.WriteLine("Here is your book collection.");

            foreach(string item in bookTitles)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("To add a book, enter a. To delete a book enter d. To sort all books enter s.");
            Console.WriteLine("To exit, press x.");
            char userInput = Convert.ToChar(Console.ReadLine());

            do
            {
                switch (userInput)
                {
                    case ('a'):
                        Console.WriteLine("Type the name of the book you would like to add:");
                        string addBook = Console.ReadLine();
                        bookTitles.Add(addBook);
                        break;
                    case ('d'):
                        Console.WriteLine("Type the name of the book you would like to delete:");
                        string deleteBook = Console.ReadLine();
                        bookTitles.Remove(deleteBook);
                        break;
                    case ('s'):
                        bookTitles.Sort();
                        break;
                }
                Console.WriteLine("To add a book, enter a. To delete a book enter d. To sort all books enter s.");
                userInput = Convert.ToChar(Console.ReadLine());
            }
            while (userInput != 'x');















            /*------------------------------- CALCULATOR = ACCEPTS 2 VALUES AND SIGN, THEN GIVES RESULT --------------------------------*/

            //char sign;
            //int result = 0;

            //Console.WriteLine("This program is going to take your two numbers and either +, -, * or / the two numbers together");
            //Console.WriteLine("Enter a number below..");
            //int userInput1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter another number below..");
            //int userInput2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a sign  below");
            //sign = Convert.ToChar(Console.ReadLine());

            //if (sign == '+')
            //{
            //    result = Add(userInput1, userInput2);
            //}
            //else if (sign == '-')
            //{
            //    result = Subtract(userInput1, userInput2);
            //}
            //else if (sign == '*')
            //{
            //    result = Multiply(userInput1, userInput2);
            //}
            //else if (sign == '/')
            //{
            //    result = Divide(userInput1, userInput2);
            //}
            //else
            //{
            //    Console.WriteLine("ERROR = Enter a valid sign. The arithmetic below is incorrect.");
            //}

            //Console.WriteLine(userInput1 + " " + sign + " " + userInput2 + " " + "=" + " " + result);

        }

        //static int Add(int firstNum, int secondNum)
        //{

        //    int answer = firstNum + secondNum;
        //    return answer;
        //}
        //static int Subtract(int firstNum, int secondNum)
        //{

        //    int answer = firstNum - secondNum;
        //    return answer;
        //}
        //static int Multiply(int firstNum, int secondNum)
        //{

        //    int answer = firstNum * secondNum;
        //    return answer;
        //}
        //static int Divide(int firstNum, int secondNum)
        //{

        //    int answer = firstNum / secondNum;
        //    return answer;
        //}



    }
}
