using System;

namespace ITMO.CSharp.Lab05.FileDetails {
    internal class FileDetails {
        static void Main(string[] args) {
            Console.Write("Length: " + args.Length + "\n");
            Console.Write("args: ");
            foreach(string arg in args) {
                Console.Write(arg + " ");
            }
            Console.ReadKey();
        }
    }
}
