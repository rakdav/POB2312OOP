using Lesson4;
using System.Text;
using MyPrint = System.Console;
using Lesson1;
using Npgsql.PostgresTypes;

Point p1 = new Point(7, 9);
Point p2 = new Point(12,10);
Console.WriteLine(Point.count);
Console.WriteLine($"Расстояние между точками:{Point.LengthPoints(p1,p2):F2}");

Person person = new Person(60);
person.CheckAge();
Person.RetirementAge = 70;
person.CheckAge();

MyPrint.WriteLine("fdsfs");