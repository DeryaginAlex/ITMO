﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSharp.Lab05.SimpleArgs {
    internal class SimpleArgs {
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
