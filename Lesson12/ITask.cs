using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    enum Priority
    {
        Low,
        Medium,
        High
    }
    internal interface ITask
    {
        string Name { get; set; }
        DateTime DueDate { get; set; }
        Priority Priority { get; set; }
        void Display();
    }

}
