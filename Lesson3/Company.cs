using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Company
    {
        private Person[]? personal;
        public Person[]? Personal
        {
            get => personal;
            set => personal = value;
        }
        public Person this[int index]
        {
            get
            {
                if (index >= 0 && index < personal!.Length)
                    return personal![index];
                else
                    throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < personal!.Length)
                    personal![index] = value;
            }
        }
    }
}
