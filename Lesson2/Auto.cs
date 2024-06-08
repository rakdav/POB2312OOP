using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Auto
    {
        private string marka;
        private double volume;
        private double expend;
        private double current;//количество топлива в баке
        public double Current
        {
            get { return current; }
            set { if (value > volume - current)
                {
                    Console.WriteLine("Перелил");
                    current = volume;
                }
                else current += value;
                }
        }
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }    
        public double Volume
        {
            get { return volume; }
            private set { if(value>0) volume = value; }
        }
        public double Expend
        {
            get { return expend; }
            set { if(value>0) expend = value; }
        }
        public void Fide(double fide)
        {
            Current = fide;
        }
        public double Way(double km)
        {
            return km * expend / 100;
        }
        public double Remains()
        {
            return (current / expend) * 100;
        }

        public Auto(double current, string marka, double volume, double expend)
        {
            Marka = marka;
            Volume = volume;
            Expend = expend;
            Current = current;
        }
    }
}
