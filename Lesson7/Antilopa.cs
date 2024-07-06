using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class Antilopa : Animal
    {
        public override void Eat(double massa)
        {
            Console.WriteLine("Ем траву");
            EatMassa += massa;
        }
    }
}
