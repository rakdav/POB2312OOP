using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Train
    {
        private string? dest;
        private int number;
        private DateTime timeDep;
        public string? Dest
        {
            get { return dest; }
            set { dest = value;}
        }
        public int Number
        {
            get { return number; }
            set { number = value;}
        }
        public DateTime TimeDep
        {
            get { return timeDep; }
            set { timeDep = value;}
        }
        public void Print()
        {
            Console.WriteLine($"Назначение:{dest} Номер:{number} Время отправления:{timeDep}");
        }
    }
}
