using System;
namespace ITMO.CSharp.Lab04.Greater {

    public class Test {
        class Utils {
            public static int Greater(int a, int b) {
                if(a > b)
                    return a;
                else
                    return b;
            }
        }
        public static void Main() {
            int x;
            int y;
            int greater;
            Console.Write("Enter first number: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            y = int.Parse(Console.ReadLine());
            greater = Utils.Greater(x, y);
            Console.Write("The greater value is " + greater);
            Console.ReadKey();
        }
    }
}