using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Pair
    {
        private int a;
        private int b;
        public Pair(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int getA() => a;
        public int getB() => b;
        public void Print() => Console.WriteLine("a="+a+" b="+b);
        public void setA(int a) => this.a = a;
        public void setB(int b) => this.b = b;
        public int Sum() => a + b;
        public int Max()
        {
            if (a > b) return a;
            else if (a < b) return b;
            throw new Exception("Равны");
        }
    }
}
