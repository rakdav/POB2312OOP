//Lesson1

//using Lesson9;
//using System.ComponentModel.DataAnnotations;
//using System.Diagnostics.CodeAnalysis;

//string myEmail = "resr@mail.ru";
//Console.WriteLine(myEmail.IsValidEMailAddress());
//Console.WriteLine(myEmail.WordCount('r'));

//string main = "Java";
//string second = "C#";
//Console.WriteLine(main+" "+second);
//(main, second) = (second, main);
//Console.WriteLine(main + " " + second);

//Random random = new Random();
//int[] mas = new int[random.Next(5,10)];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10, 100);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//for (int i = 0; i < mas.Length-1; i++)
//{
//    for(int j = i + 1; j < mas.Length; j++)
//    {
//        if (mas[i] > mas[j])
//        {
//            (mas[i], mas[j]) = (mas[j], mas[i]);
//        }
//    }
//}
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.Write(mas[i] + " ");
//}
//var tuple = GetValues();
//Console.WriteLine(tuple.Item1);
//Console.WriteLine(tuple.Item2);
//var masTuple = getMasParametrs(mas);
//Console.WriteLine(masTuple.Item1);
//Console.WriteLine(masTuple.Item2);
//Console.WriteLine(masTuple.Item3);
//Console.WriteLine(masTuple.Item4);
//(int,int) GetValues()
//{
//    var result = (3, 9);
//    return result;
//}
//(int,int,int,double) getMasParametrs(int[] mas)
//{
//    var results = (sum: 0, max: int.MinValue,
//        min: int.MaxValue, avg: 0.0);
//    for(int i = 0; i < mas.Length; i++)
//    {
//        results.sum += mas[i];
//    }
//    results.min = mas.Min();
//    results.max = mas.Max();
//    results.avg = mas.Average();
//    return results;
//}

//Lesson2 - Делегаты
//Message? mes;
//mes = Hello;
//mes += Welcome;
//mes();
//Console.WriteLine();
//mes -= Hello;
//mes!();

//Console.Write("Введите x:");
//int x;
//int.TryParse(Console.ReadLine(), out x);
//Console.Write("Введите y:");
//int y;
//int.TryParse(Console.ReadLine(), out y);
//Operation op = Add;
//op += Sub;
//op += Mult;
//Console.WriteLine(op(x,y));
//DoOperation(x, y, Add);
//DoOperation(x, y, Sub);
//DoOperation(x, y, Mult);

//void DoOperation(int a, int b, Operation op)
//{
//    Console.WriteLine(op(a,b));
//}
//void Hello() => Console.WriteLine("Hello, world");
//void Welcome() => Console.WriteLine("Welcome, to delegates");
//int Add(int x, int y) => x + y;
//int Sub(int x, int y) => x - y;
//int Mult(int x, int y) => x * y;
//delegate void Message();
//delegate int Operation(int x, int y);

using Lesson9;

Account account = new Account(20000);
account.RegisterHandler(PrintMessage);


void PrintMessage(string message) => Console.WriteLine(message);
void PrintColorMessage(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ResetColor();
}
account.Add(2000);
account.Take(19000);
account.UnregitserRegisterHandler(PrintMessage);
account.RegisterHandler(PrintColorMessage);
account.Take(5000);