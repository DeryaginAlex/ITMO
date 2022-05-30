using System;

namespace ITMO.CSharp.Lab07.ReverseString {
    public class Test {
        public static void Main() {
            string mes;
            Console.WriteLine("Enter string to reverse:");
            mes = Console.ReadLine();
            Utils.Reverse(ref mes);
            Console.WriteLine(mes);
        }
    }
}
