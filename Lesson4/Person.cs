using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Person
    {
        private int age;
        private static int retirementAge = 65;
        public static int RetirementAge
        {
            get { return retirementAge; }
            set { if (value > 1 && value < 100) retirementAge = value; }
        }
        public Person(int age)
        {
            this.age = age;
        }
        public void CheckAge()
        {
            if (age >= retirementAge)
                Console.WriteLine("Уже на пенсии");
            else
                Console.WriteLine($"До пенсии {retirementAge-age}");
        }
    }
}
