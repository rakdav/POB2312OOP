using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Solution
    {
        List<Train> trains;
        public Solution()
        {
            trains = new List<Train>();
        }
        public void Add(Train train)
        {
            trains.Add(train);
        }
        public void Print()
        {
            for(int i = 0; i < trains.Count - 1; i++)
            {
                for(int j = i + 1; j < trains.Count; j++)
                {
                    if (trains[i].Number > trains[j].Number)
                    {
                        Train temp = trains[i];
                        trains[i] = trains[j];
                        trains[j] = temp;
                    }
                }
            }
            foreach(Train t in trains) t.Print();
        }
        public Train Find(int n)
        {
            for(int i = 0; i < trains.Count; i++)
            {
                if (trains[i].Number == n) return trains[i];
            }
            return null!;
        }
        public void PrintByDest()
        {
            for (int i = 0; i < trains.Count - 1; i++)
            {
                for (int j = i + 1; j < trains.Count; j++)
                {
                    if (trains[i].Dest!.CompareTo(trains[j].Dest)>0)
                    {
                        Train temp = trains[i];
                        trains[i] = trains[j];
                        trains[j] = temp;
                    }
                    else if(trains[i].Dest!.CompareTo(trains[j].Dest)==0)
                    {
                        if (trains[i].TimeDep > trains[j].TimeDep)
                        {
                            Train temp = trains[i];
                            trains[i] = trains[j];
                            trains[j] = temp;
                        }
                    }
                }
            }
            foreach (Train t in trains) t.Print();
        }
    }
}
