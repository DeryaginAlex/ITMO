namespace Utils {
	using System;

	public class Test {
		public static void Main() {
			//As before…
			int x; // Input value 1
			int y; // Input value 2

			// Get input numbers
			Console.Write("Enter first number: ");
			x = int.Parse(Console.ReadLine());
			Console.Write("Enter second number: ");
			y = int.Parse(Console.ReadLine());
			// Test the Swap method
			Console.WriteLine("Before swap: " + x + "," + y);
			Utils.Swap(ref x, ref y);
			Console.WriteLine("After swap: " + x + "," + y);
			Console.ReadKey();
		}
	}
}
