using Lesson2;

Console.Write("Введите марку автомобиля:");
string marka = Console.ReadLine()!;
Console.Write("Введите объем топливного бака:");
double voluem = double.Parse(Console.ReadLine()!);
Console.Write("Введите расход бензина на 100 км:");
double expend =double.Parse(Console.ReadLine()!);
Console.Write("Введите текущее количество топлива в баке:");
double current = double.Parse(Console.ReadLine()!);
Auto auto = new Auto(current,marka,voluem,expend);
Console.Write("Введите объем заправки:");
double addFill = double.Parse(Console.ReadLine()!);
auto.Fide(addFill);
Console.WriteLine($"Количество в баке:{auto.Current:F2}");

Console.Write("Введите количество километров:");
double km = double.Parse(Console.ReadLine()!);
Console.WriteLine($"Расход на {km} равен:{auto.Way(km):F2} литров");
Console.WriteLine($"Еще можно {auto.Remains():F2} км проехать");
