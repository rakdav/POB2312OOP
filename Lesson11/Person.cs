using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class Person<T,K>
    {
        public static T? code;
        public T Id { get; set; }
        public K Password { get; set; }
        public string Name { get; set; }
        public Person(T id,K password, string name)
        {
            Id = id;
            Name = name;
            Password = password;
        }
    }

    internal class UniversalPerson<T, K> : Person<T, K>
    {
        public UniversalPerson(T id, K password, string name) : base(id, password, name)
        {
        }
    }
}
