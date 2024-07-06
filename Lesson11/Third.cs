using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class Third<T>
    {
        private T myVar;
        public T MyVar
        {
            get { return myVar; }
            set { myVar = value; }
        }
        public Third(T myVar)
        {
            MyVar = myVar;
        }
    }
}
