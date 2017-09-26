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

            if(codingLanguages.ContainsKey())

        }
    }
}
