using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    internal class Event:ITask,IComparable<Event>
    {
        public string? Location { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }

        public int CompareTo(Event? other)
        {
            if (this.DueDate > other.DueDate) return 1;
            else if (this.DueDate < other.DueDate) return -1;
            else return 0;
        }
        public void Display()
        {
            Console.WriteLine(Location+" "+Name+" "+DueDate+" "+Priority);
        }
    }
}
