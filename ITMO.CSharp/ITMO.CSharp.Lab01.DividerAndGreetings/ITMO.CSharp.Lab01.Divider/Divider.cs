using System;

namespace ITMO.CSharp.Lab01.Divider {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter the first number, please:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number, please:");
            int secondNumber = int.Parse(Console.ReadLine());
            try {
                int divided = firstNumber / secondNumber;
                Console.WriteLine("{0} divided by {1} is {2}.", firstNumber, secondNumber, divided);
            } catch(DivideByZeroException e) {
                Console.WriteLine("An exception was thrown: {0}", e);
            }
        }
    }
}
