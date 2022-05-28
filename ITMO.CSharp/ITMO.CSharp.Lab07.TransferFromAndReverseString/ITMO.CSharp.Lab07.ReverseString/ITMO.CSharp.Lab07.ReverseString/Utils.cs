using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSharp.Lab07.ReverseString {
    class Utils {
        // Return a string whose characters will be in reverse order

        public static void Reverse(ref string s) {
            string sRev = "";

            for(int k = s.Length - 1 ; k >= 0 ; k--) {
                sRev = sRev + s[k];
            }
            s = sRev;       //Return result to caller
        }


        // Return the greater of two integer values

        public static int Greater(int a, int b) {
            if(a > b)
                return a;
            else
                return b;

            // Alternative version - more terse
            // return (a>b) > (a) : (b);
        }

        // Exchange two integers, passed by reference

        public static void Swap(ref int a, ref int b) {
            int temp = a;
            a = b;
            b = temp;
        }

        // Factorial calculation and return the result as an out parameter

        public static bool Factorial(int n, out int answer) {
            int k;                                          // Loop counter
            int f;                                          // Working value

            bool ok = true;                                 // True if okay, false if not

            if(n < 0)                                      // Check the input value
                ok = false;

            try                                             // Calculate the factorial value
            {
                checked {
                    f = 1;
                    for(k = 2 ; k <= n ; k++) {
                        f = f * k;
                    }
                }
            } catch(Exception)                               // If something goes wrong in the calculation, catch it here.
              {                                               // All exceptions are handled the same way:
                f = 0;                                      // set the result to zero
                ok = false;                                 // and return false.
            }
            answer = f;
            return ok;
        }

        // Another way to solve the factorial problem, this time
        // as a recursive function
        //

        public static bool RecursiveFactorial(int n, out int f) {
            bool ok = true;

            // Trap negative inputs
            if(n < 0) {
                f = 0;
                ok = false;
            }

            if(n <= 1)
                f = 1;
            else {
                try {
                    int pf;
                    checked {
                        ok = RecursiveFactorial(n - 1, out pf);
                        f = n * pf;
                    }
                } catch(Exception) {
                    // Something went wrong. Set error
                    // flag and return zero.
                    f = 0;
                    ok = false;
                }
            }
            return ok;
        }
    }
}
