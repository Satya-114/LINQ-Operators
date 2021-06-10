using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_SelectMany
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>() { "Pranaya", "Kumar" };
            IEnumerable<char> methodSyntax = nameList.SelectMany(x => x);
            foreach (char c in methodSyntax)
            {
                Console.Write(c + " ");
            }
            Console.ReadKey();
        }
    }
}
