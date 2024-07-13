using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    internal class Week:IEnumerable
    {
        string[] days = {"Monday","Tuesday","Wednesday","Thirthday",
                        "Friday","Satarday","Sunday"};
        public IEnumerator GetEnumerator()
        {
            return new WeekEnumerator(days);
        }
    }
}
