using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*--- THIS IS WHERE USERS LIST OF NUMBERS WILL BE STORED ---*/
            List<int> allNumbers = new List<int>();

            /*--- VARIABLES ---*/
            int number;
            char userInput;
            char secondUserInput;
            int sum = 0;


            /*--- THIS DO WHILE LOOP WILL ASK USER TO ENTER NUMBERS UNTILL THEY ENTER n TO EXIT OUT OF THIS LOOP ---*/
            do
            {
                Console.WriteLine("Enter y if you would like to enter a number to the list. If not, enter n");
                userInput = Convert.ToChar(Console.ReadLine().ToLower());


                if (userInput == 'y')
                {
                    Console.WriteLine("Please enter a number...");
                    number = Convert.ToInt32(Console.ReadLine());

                    //ADDING NUMBERS THE USER ENTERS INTO THE LIST NAMED allnumbers
                    allNumbers.Add(number);

                }

            } while (userInput != 'n');



            /*--- ONCE THEY HAVE ENTERED THEIR NUMBERS THEY GET A CHOICE TO AVERAGE THE NUMBERS, DISPLAY LIST, SORT LIST OR EXIT ---*/
            do
            {
                Console.WriteLine("If you would like to get average of this list of numbers, enter a. If you would like to display the list, enter d. If you would like to sort the list, enter s. Or quit the program, enter x.");
                secondUserInput = Convert.ToChar(Console.ReadLine().ToLower());

                switch (secondUserInput)
                {
                    //AVERAGE NUMBERS IN LIST
                    case ('a'):

                        sum = allNumbers.Sum();
                        Console.WriteLine("The average of these numbers is: " + sum/allNumbers.Count);
                        break;
                    //DISPLAY NUMBERS IN LIST
                    case ('d'):

                        Console.WriteLine("Your list of numbers are: ");
                        foreach (int n in allNumbers)
                        {
                            Console.WriteLine(n);
                        }
                        break;
                    //SORT NUMBERS IN LIST
                    case ('s'):

                        allNumbers.Sort(); 
                        break;
                

                }
            } while (secondUserInput != 'x');


        }
    }
}

//C# assessment - averages



//Write a console application that prompts the user to enter as many integers as they want to, then offers them the choice of getting the average of the list, 
//displaying the list, sorting the list or exiting the program.



//The screen output might look like this:

//Would you like to add a number to the list? (y/n):

//Y

//Please enter a number, followed by return:

//23

//Would you like to add a number to the list? (y/n):

//Y

//Please enter a number, followed by return:

//2

//Would you like to add a number to the list? (y/n):

//N

//Type ‘A’ to get the average of the list, ‘S’ to sort it, or ‘X’ to exit:

//A

//The average is: 12.5

//Type ‘A’ to get the average of the list, 'D' to display the list, ‘S’ to sort it, or ‘X’ to exit:

//X



//You should plan your program in advance.
//You should also be able to explain what you did to test it.
//If you finish the program, feel free to add extra options, such as sum, median or mode(look these up if you need explanations).

//We are looking for:
//How well the code works
//Use of appropriate data structures
//Logical code that is easy to read
//Meaningful variable names
//Comments
//Clear and easy-to-use user interface
//Neat and attractive presentation

