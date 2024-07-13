using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    internal class MessangerStruct<T> where T : struct
    {
    }
    internal class MessangerClass<T> where T : class
    {
    }
    internal class MessangerNew<T> where T : new()
    {
    }
}
