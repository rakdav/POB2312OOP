using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal abstract class People<T,K,M>
    {
        public double Rost { get; set; }
        public double Height { get; set; }
        public T? Gender { get; set; }
        public K? Rassa { get; set; }
        public M? EyesColor { get; set; }
    }
    internal abstract class NewPerson<T,K,M>:People<T,K,M>
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public T? Gender { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
    }
    internal  abstract class Employer<T, K, M> : NewPerson<T, K, M>
    {
        public int Id { get; set; }
        public string? Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime WorkStart { get; set; }
    }
    internal class Teacher<T, K, M> : Employer<T, K, M>
    {
        public string? Subject { get; set; }
        public int Stage { get; set; }
    }
    internal class Student<T, K, M> : Employer<T, K, M>
    {
        public int Kurs { get; set; }
        public string? Speciality { get; set; }
        public double AvgBall { get; set; }
    }
    internal class Manager<T, K, M> : Employer<T, K, M>
    {
        public string? Scope { get; set; }
        public int Count { get; set; }
        public int Stage { get; set; }
    }
    internal class Programmer<T, K, M> : Employer<T, K, M>
    {
        public string? Language { get; set; }
        public List<string> Projects { get; set; } = new();
        public string? Specialization { get; set; }
    }
}
