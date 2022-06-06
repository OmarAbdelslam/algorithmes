using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Class1
    {
        public static int Number1
        {
            get;
            set;
        }
        public static int Number2
        {
            get;
            set;
        }

        public static int Sum()
        {
            int sum = Number1 + Number2;
            return sum;
        }
        public static int Negative(int a, int s )
        {
            int negative = a - s;

                return negative;
            
        }
        public static double _K()
        {
            double _k = Number1 / Number2;
            return _k;

        }
        public static double _D()
        {
            double d = Number1 * Number2;
            return d;
        }

    }
}

