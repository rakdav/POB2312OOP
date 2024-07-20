using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    internal class ArraySort
    {
        public static void Sort<T>(IList<T> sortArray,Func<T,T,bool> res)
        {
            bool mySort = true;
            do
            {
                mySort = false;
                for (int i = 0; i < sortArray.Count - 1; i++)
                {
                    if (res(sortArray[i + 1], sortArray[i]))
                    {
                        (sortArray[i], sortArray[i + 1]) = (sortArray[i + 1], sortArray[i]);
                        mySort = true;
                    }
                }
            }
            while (mySort);
        }
    }
    internal class UserInfo
    {
        public string Name { get; private set; }
        public string Family { get; private set; }
        public decimal Salary { get; private set; }
        public UserInfo(string name, string family, decimal salary)
        {
            Name = name;
            Family = family;
            Salary = salary;
        }
        public override string ToString()
        {
            return Name+" "+Family+" "+Salary;
        }
        public static bool UserSalary(UserInfo obj1,UserInfo obj2)
        {
            return obj1.Salary < obj2.Salary;
        }
        public static bool UserSalaryDesc(UserInfo obj1, UserInfo obj2)
        {
            return obj1.Salary > obj2.Salary;
        }
    }
}
