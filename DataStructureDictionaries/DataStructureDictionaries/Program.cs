using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> codingLanguages = new Dictionary<string, string>();

            codingLanguages.Add("C#", "The best programming language in the world");
            codingLanguages.Add("Java", "Named after its inventor's favourite coffee");
            codingLanguages.Add("Scratch", "Cool for kids");

            Console.WriteLine("Enter K to find a Key. Enter V to find Value.... ");


            //CHECKING IF A KEY OR VALUE IS IN THE DICTIONARY
            if (codingLanguages.ContainsKey("C#"))
            {
                string value = codingLanguages["C#"];
                Console.WriteLine(value);
            }
            else if (codingLanguages.ContainsKey("Java"))
            {
                string value = codingLanguages["Java"];
                Console.WriteLine(value);
            }
            else if (codingLanguages.ContainsKey("Scratch"))
            {
                string value = codingLanguages["Scratch"];
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("This Key doesn't exist.");
            }

            //USING A KEY TO GET A VALUE
            //TryGetValue


            //COUNT THE LISTS



            //LIST ALL ENTRIES



            //EXIT


        }
    }
}
