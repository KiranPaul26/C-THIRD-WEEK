using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            try
            {
                numbers[6] = 2;
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }



            
        }
    }
}
