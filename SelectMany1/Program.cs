using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_SelectMany2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            List<string> MethodSyntax = Student.GetStudents().SelectMany(std => std.Programming).ToList();
            //Using Query Syntax
            IEnumerable<string> QuerySyntax = from std in Student.GetStudents()
                                              from program in std.Programming
                                              select program;
            //Printing the values
            foreach (string program in MethodSyntax)
            {
                Console.WriteLine(program);
            }
            Console.ReadKey();
        }
    }
}
