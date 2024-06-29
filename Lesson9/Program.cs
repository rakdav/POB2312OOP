using Lesson9;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

string myEmail = "resr@mail.ru";
Console.WriteLine(myEmail.IsValidEMailAddress());
Console.WriteLine(myEmail.WordCount('r'));

string main = "Java";
string second = "C#";
Console.WriteLine(main+" "+second);
(main, second) = (second, main);
Console.WriteLine(main + " " + second);

Random random = new Random();
int[] mas = new int[random.Next(5,10)];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(10, 100);
    Console.Write(mas[i]+" ");
}
Console.WriteLine();
for (int i = 0; i < mas.Length-1; i++)
{
    for(int j = i + 1; j < mas.Length; j++)
    {
        if (mas[i] > mas[j])
        {
            (mas[i], mas[j]) = (mas[j], mas[i]);
        }
    }
}
for (int i = 0; i < mas.Length; i++)
{
    Console.Write(mas[i] + " ");
}
var tuple = GetValues();
Console.WriteLine(tuple.Item1);
Console.WriteLine(tuple.Item2);
var masTuple = getMasParametrs(mas);
Console.WriteLine(masTuple.Item1);
Console.WriteLine(masTuple.Item2);
Console.WriteLine(masTuple.Item3);
Console.WriteLine(masTuple.Item4);
(int,int) GetValues()
{
    var result = (3, 9);
    return result;
}
(int,int,int,double) getMasParametrs(int[] mas)
{
    var results = (sum: 0, max: int.MinValue,
        min: int.MaxValue, avg: 0.0);
    for(int i = 0; i < mas.Length; i++)
    {
        results.sum += mas[i];
    }
    results.min = mas.Min();
    results.max = mas.Max();
    results.avg = mas.Average();
    return results;
}