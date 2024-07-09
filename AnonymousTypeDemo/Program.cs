using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new { 
                Id = 1, 
                FirstName = "John", 
                LastName = "Smith", 
                Address = new { Id = 101, City = "pune", Country = "India" }
            };
            Console.WriteLine(student.Id);
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);
            Console.WriteLine(student.Address.City + " " + student.Address.Country);
        }
    }
}
