using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variable declarations p.68
            int myInt;
            long myLong = 0;
            double myDouble = 0.0;
            string myStr = "some text";
            #endregion

            #region PRINTING P.63-67
            // errors and warnings
            //Console.WriteLine("myInt: {0}:", myInt);
            // c - currency d - decimal d6- decimal to the 6th place X - hexidecimal

            Console.WriteLine("myLong: {0}", myLong);
            Console.WriteLine("myLong c: {0:c}", myLong);
            Console.WriteLine("myLong d: {0:d}", myLong);
            Console.WriteLine("myLong d6: {0:d6}", myLong);
            Console.WriteLine("myLong: {0:X}", 31);
            Console.WriteLine(); //blank line

            #endregion

            #region casting p88-90

            byte myByte = 255;
            byte myByte2 = (byte)(myByte + 1);
            Console.WriteLine("myByte: {0} + 1 = {1}", myByte, myByte2);
            Console.WriteLine();

            #endregion

            #region strings p.79-88

            string hello = "hello";
            string world = "world";
            string str;

            Console.WriteLine("length of hello: {0}", hello.Length);
            Console.WriteLine("test == {0}", hello == "hello2");
            Console.WriteLine("test == {0}", hello == "hello");
            Console.WriteLine("test == {0}", hello.Equals("Hello"));

            Console.WriteLine("compare {0}", hello.CompareTo(world));
            Console.WriteLine("compare {0}", hello.CompareTo(hello));

            str = hello + " " + world;
            Console.WriteLine(str);

            //verbatim
            // using @ gets around using escapes  - backslashes - syntactic sugar - makes program easier to read 
            
            #endregion
        }
    }
}
