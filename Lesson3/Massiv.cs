using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Massiv
    {
        private List<int> mas;
        public Massiv(int n)
        {
            this.mas = new List<int>(n);
        }
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < mas.Count)
                    return mas[index];
                else throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < mas.Count)
                    mas[index] = value;
            }
        }
        public void Fill()
        {
            Random random = new Random();
            for (int i = 0; i < mas.Capacity; i++)
            {
                mas.Add(random.Next(0, 100));
            }
        }
        public void Mix()
        {
            Random random = new Random();
            for (int i = 0; i < random.Next(mas.Count); i++)
            {
                int x = random.Next(mas.Count);
                int y = random.Next(mas.Count);
                int temp = mas[x];
                mas[x] = mas[y];
                mas[y] = temp;
            }
        }
        public int Different()
        {
            List<int> temp = new List<int>();
            foreach (int i in mas)
            {
                if (!temp.Contains(i)) temp.Add(i);
            }
            return temp.Count;
        }
        public void Print()
        {
            foreach (int i in mas)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
