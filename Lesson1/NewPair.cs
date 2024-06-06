using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class NewPair
    {
        private int a;
        private int b;
        public int A
        {
            get { return a; }
            set { this.a = value; }
        }
        public int B
        {
            get { return b; }
            set { this.b = value; }
        }
        public void Print()
        {
            Console.WriteLine("a="+a+" b="+b);
        }
        public int Sum() => a + b;
        public int Max()
        {
            if (a > b) return a;
            else if (a < b) return b;
            throw new Exception("Равны");
        }
    }
}
