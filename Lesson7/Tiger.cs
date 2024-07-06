using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class Tiger : Animal
    {
        public override void Eat(double massa)
        {
            Console.WriteLine("Съел мяса");
            EatMassa += massa;
        }
    }
}
