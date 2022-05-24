using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings {
    internal class Greeter {
        static void Main(string[] args) {
            string myName;
            Console.Write("Please enter your name: ");
            myName = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName);
            Console.ReadKey();
        }
    }
}
