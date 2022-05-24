using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divider {
    internal class DivideIt {
        static void Main(string[] args) {
            try {
                Console.Write("Please enter the first integer: ");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);
                Console.Write("Please enter the second integer: ");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);
                int k = i / j;
                Console.Write("The result of dividing {0} by {1} is {2} ", i, j, k);
                Console.ReadKey();
            } catch(Exception e) {
                Console.Write("An exception was thrown: {0}", e);
            }
            Console.ReadKey();
        }
    }
}
