using System;

/// <summary>
/// This the test harness
/// </summary>

public class Test {
    class Utils {
        //
        // Return the greater of two integer values
        //

        public static int Greater(int a, int b) {
            if(a > b)
                return a;
            else
                return b;
        }
    }
    public static void Main() {
        int x; // Input value 1
        int y; // Input value 2
        int greater; // Result from Greater()

        // Get input numbers
        Console.Write("Enter first number: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        y = int.Parse(Console.ReadLine());

        // Test the Greater( ) method
        greater = Utils.Greater(x, y);
        Console.Write("The greater value is " + greater);
        Console.ReadKey();
    }
}