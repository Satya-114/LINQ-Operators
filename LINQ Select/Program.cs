using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Select1
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Using Query Syntax
            List<Employee> basicQuery = (from emp in Employee.GetEmployees()
                                         select emp).ToList();
            foreach (Employee emp in basicQuery)
            {
                Console.WriteLine($"ID : {emp.ID} Name : {emp.FirstName} {emp.LastName}");
            }
            //Using Method Syntax
            IEnumerable<Employee> basicMethod = Employee.GetEmployees().ToList();
            foreach (Employee emp in basicMethod)
            {
                Console.WriteLine($"ID : {emp.ID} Name : {emp.FirstName} {emp.LastName}");
            }

            Console.ReadKey();
        }
    }
}





        

