using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class GenaralClass<T>
    {
        private T[] mas;
        public GenaralClass(T[] mas)
        {
            this.mas = mas;
        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < mas.Length)
                    return mas[index]; 
                else
                    throw new ArgumentOutOfRangeException(); 
            }
            set
            {
                if (index >= 0 && index < mas.Length)
                    mas[index] = value;
            }
        }
    }
}
