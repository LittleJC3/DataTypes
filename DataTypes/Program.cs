using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            typeConversion();
        }



  //**************************************************************************************************
        private static void typeConversion()
        {
            String gamma = "42";
            int epsilon = Int32.Parse(gamma);    // Need to parse
            Console.WriteLine(epsilon);
            gamma = "abc";
            epsilon = Int32.Parse(gamma); // Wont work because gamma contains things that cannot be an int
        }
        private static void infinityStuff()
        {
            float f = float.MaxValue;
            f = f / 0;
            Console.WriteLine(f);
            f = f + 1;
            Console.WriteLine(f);
        }
        private static void floatStuff()
        {
            // When is .1 not equal to .1 ? They represent .1 in different ways so its false
            float a = (float).1;
            double b = .1;
            Console.WriteLine(a == b);
            Console.WriteLine(b - a); // The difference between float .1 and double .1

            // Use an Epsilon
            // When is .1 not equal to .1 ? 
            float aa = (float).1;
            double bb = .1;
            Console.WriteLine(aa - bb);
            Console.WriteLine(Math.Abs(aa - bb) < (float).000001); // If the difference is less than that number, its 'equal'


        }
        private static void underflow()
        {
            // Demonstrates underflow
            int x = Int32.MinValue;
            Console.WriteLine(x);
            x--;
            Console.WriteLine(x);
            //x = Int32.MinValue - 1;  // Build error
            //Console.WriteLine(x);

        }
        private static void explicityType()
        {
            // Explicit type stuff
            sbyte beta = 0;
            //beta = 65535;
            unchecked { beta = (sbyte)65535; }
            Console.WriteLine("65535 converted to sbyte = " + beta);

        }
        private static void implicitType()
        {
            // Implicit type conversion
            sbyte beta = 0;
            //beta = 65535;

        }
        private static void overflow()
        {
            // Overflow example
            int alpha;
            alpha = System.Int32.MaxValue;
            alpha++;
            Console.WriteLine("int 32 max + 1 = " + alpha);

        }
        private static void loopTiming()

        {
            // Timing a loop
            Stopwatch stopWatch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < Int32.MaxValue; i++) { }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);

            stopWatch = System.Diagnostics.Stopwatch.StartNew();
            for (long i = 0; i < Int32.MaxValue; i++) { }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
            // for (float i = 0; i < Int32.MaxValue; i++) { }
        }
    }
}
