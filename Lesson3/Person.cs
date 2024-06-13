using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Person
    {
        public string? name;
        public string Name
        {
            get { return name!; }
            set { name = value; }
        }
    }
}
