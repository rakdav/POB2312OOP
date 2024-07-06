using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal abstract class Animal
    {
        public double EatMassa { get; set; }
        public abstract void Eat(double massa);
    }
}
