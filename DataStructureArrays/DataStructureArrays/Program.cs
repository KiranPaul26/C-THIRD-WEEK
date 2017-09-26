using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------------- STANDARD ARRAY EXERCISE ----------------------------------------*/

            int i;
            int[] array = new int[5];

            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter a value: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("The New Array Is: ");

            for (i = 0; i < array.Length; i++)
            {

                Console.WriteLine(array[i]);
            }

            int sum = 0;
            for (i = 0; i < array.Length; i++)
            {
                sum += array[i];

            }
            //Console.WriteLine("The sum of items in the array is: " + sum);
            Console.WriteLine("The average of items in array is: " + sum / array.Length);

            /*------------------------------------- EXTENSION ARRAY EXERCISE ----------------------------------------*/

            //COME BACK TO THIS 
            //Random rand = new Random();

            //int[,] arr = new int[5, 5];

            //for(int x = 0; x < 5; x++)
            //{
            //    for(int y = 0; y < 5; y++)
            //    {
            //        arr[x,y] = rand.Next(1, 11);
            //        Console.WriteLine(arr[x, y]);

            //    }


            //}

        }
    }
}
