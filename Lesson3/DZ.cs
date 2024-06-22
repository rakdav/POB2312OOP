using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class DZ
    {
        private string[] mas;

        public DZ(int n)
        {
            this.mas = new string[n];
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < mas.Length)
                    return mas[index];
                else throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < mas.Length)
                    mas[index] = value;
            }
        }
        public string[] Concat(string[] source)
        {
            string[] res = new string[mas.Length];
            for (int i = 0; i < mas.Length; i++)
            {
                res[i] = mas[i]+source[i];
            }
            return res;
        }
        public string[] Union(string[] source)
        {
            string[] res = new string[mas.Length];
            ///
            return res;
        }
        public void Print() 
        {
            ///
        }
    }
}
