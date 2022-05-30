using System;

namespace ITMO.CSharp.Lab01.Greetings {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter your name, please:");
            string myName = Console.ReadLine(); 
            Console.WriteLine("Nice to meet you, {0}!", myName); 
        }
    }
}
