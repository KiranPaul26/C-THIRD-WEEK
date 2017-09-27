using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.IO;

namespace FileExceptionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(@"c:\Users\Louisem\mydata.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch(FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("and the program continues...");
        }
    }
}
