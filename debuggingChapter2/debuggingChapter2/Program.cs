using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debuggingChapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string firstString, secondString;
            int first, second, product;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}! Enter an integer", name);
            first = Console.ReadLine();
            Console.WriteLine("Enter another integer");
            second = Convert.ReadLine();
            product = first * second;
            Console.WriteLine("Thank you {1}. The product of {2} and {3} is {4}",
           name, first, second, product);
        }

