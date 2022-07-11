using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSharp.Forms.AddingToDatabase {
    internal static class Query {
        public static string Select = @"SELECT * FROM Products";
        public static string Insetr = @"INSERT Products VALUES('iPhone 7', 'Apple', 5, 52000)";
    }
}
