using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class TwoVar
    {
        private int x;
        private int y;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public TwoVar(int x, int y)
        {
            X = x;
            Y = y;
        }

        public TwoVar()
        {
            X = 10;
            Y = 10;
        }
        ~TwoVar()
        {
            Console.WriteLine("Уничтожен");
        }
    }
}
