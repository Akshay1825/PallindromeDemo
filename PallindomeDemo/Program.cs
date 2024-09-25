using PallindomeDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PallindomeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pallindrome pallindrome = new Pallindrome();

            Console.WriteLine("Enter a number :");
            int number = int.Parse(Console.ReadLine());

            string answer = pallindrome.IsPallindrome(number)
                            ? $"{number} is a Palindrome number."
                            : $"{number} is not a Palindrome number.";

            Console.WriteLine(answer);
        }
    }
}
