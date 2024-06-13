using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Sklad
    {
        private int number;
        private string? fio;
        private double maxVolume;
        private double current;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Fio
        {
            get { return fio; }
            set { fio = value; }
        }
        public double MaxVolume
        {
            get { return maxVolume;}
            set { if (value > 0) maxVolume = value;
                else throw new Exception("Введите правильный объем");
            }
        }
        public double Current
        {
            get { return current; }
            set
            {
                if (value > maxVolume - current)
                {
                    current = maxVolume;
                    Console.WriteLine("Склад перегружен!!!");
                }
                else if (current + value < 0)
                {
                    Console.WriteLine("Недостаток на складе!!!");
                }
                else current += value;
            }
        }
        public void Add(double valume)
        {
            Current = valume;
        }
        public void Sub(double valume)
        {
            Current = -valume;
        }
        public void Print()
        {
            Console.WriteLine($"Можно завести {maxVolume-current:F2}. В наличии {current:F2}.");
        }
    }
}
