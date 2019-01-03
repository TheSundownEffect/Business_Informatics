using System;

// Quelle: https://pressbit.wordpress.com/2014/02/03/modulo-vs-remainder-in-c/
namespace ModuloVersionen
{
    class Program
    {
        static int restSymmetrisch(int divident, int divisor)
        {
            // Klausurlösung
            int restwert = Math.Abs(divident);
            divisor = Math.Abs(divisor);
            while (restwert >= divisor)
                restwert -= divisor;
            if (divident < 0)
                return -restwert;
            else return restwert;
        }

        static int moduloSymmetrisch(int divident, int divisor)
        {
            return divident % divisor;
        }
        
        static int restMathematisch(int divident, int divisor)
        {

            // return divident - (divident / divisor) * divisor;

            return (divident % divisor) + divisor;
        }
        static int moduloMathematisch(int dividend, int divisor)
        {
            int rest = dividend % divisor;
            return rest < 0 ? rest + divisor : rest;
        }
        static void Main(string[] args)
        {
            int a = 29, b = 8;
            Console.WriteLine("sym.  Rest ({0}, {1})\t= {2}", a, b, restSymmetrisch(a, b));
            Console.WriteLine("sym.  MOD ({0}, {1})\t= {2}", a, b, moduloSymmetrisch(a, b));
            Console.WriteLine("math. Rest ({0}, {1})\t= {2}", a, b, restMathematisch(a, b));
            Console.WriteLine("math. MOD ({0}, {1})\t= {2}", a, b, moduloMathematisch(a, b));

            a = -a;
            Console.WriteLine("\nsym.  Rest ({0}, {1})\t= {2}", a, b, restSymmetrisch(a, b));
            Console.WriteLine("sym.  MOD ({0}, {1})\t= {2}", a, b, moduloSymmetrisch(a, b));
            // hier versagt die angegebene mathematische Version!
            Console.WriteLine("math. Rest ({0}, {1})\t= {2}", a, b, restMathematisch(a, b));
            Console.WriteLine("math. MOD ({0}, {1})\t= {2}", a, b, moduloMathematisch(a, b));

            a = -a; b = -b;
            Console.WriteLine("\nsym.  Rest ({0}, {1})\t= {2}", a, b, restSymmetrisch(a, b));
            Console.WriteLine("sym.  MOD ({0}, {1})\t= {2}", a, b, moduloSymmetrisch(a, b));
            // hier versagt die angegebene mathematische Version!
            Console.WriteLine("math. Rest ({0}, {1})\t= {2}", a, b, restMathematisch(a, b));
            Console.WriteLine("math. MOD ({0}, {1})\t= {2}", a, b, moduloMathematisch(a, b));

            a = -a;
            Console.WriteLine("\nsym.  Rest ({0}, {1})\t= {2}", a, b, restSymmetrisch(a, b));
            Console.WriteLine("sym.  MOD ({0}, {1})\t= {2}", a, b, moduloSymmetrisch(a, b));
            // hier versagt die angegebene mathematische Version!
            Console.WriteLine("math. Rest ({0}, {1})\t= {2}", a, b, restMathematisch(a, b));
            Console.WriteLine("math. MOD ({0}, {1})\t= {2}", a, b, moduloMathematisch(a, b));
            Console.ReadLine();
        }
    }
}
