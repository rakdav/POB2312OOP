using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    public delegate int IntOperation(int i,int j); 
    internal class Calculator
    {
        public static int Sum(int x, int y) => x + y;
        public static int Sub(int x, int y) => x - y;
        public static int Mult(int x, int y) => x * y;
        public static int Div(int x, int y)
        {
            if (y != 0) return x / y;
            else return 0;
        }
    }
}
