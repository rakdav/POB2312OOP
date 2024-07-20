using Lesson14;
using System.Threading.Channels;

//Console.Write("Введите первое число:");
//int x;
//int.TryParse(Console.ReadLine(), out x);
//Console.Write("Введите первое число:");
//int y;
//int.TryParse(Console.ReadLine(), out y);

////IntOperation op = new IntOperation(Calculator.Sum);
//IntOperation op = Calculator.Sum;
//Console.WriteLine($"{x}+{y}={op(x,y)}");
//op+=Calculator.Sub;
//Console.WriteLine($"{x}-{y}={op(x, y)}");
//op += Calculator.Mult;
//Console.WriteLine($"{x}*{y}={op(x, y)}");
//op += Calculator.Div;
//Console.WriteLine($"{x}/{y}={op(x, y)}");
//foreach (IntOperation del in op.GetInvocationList())
//{
//    Console.WriteLine(del(x, y));
//}

//UserInfo[] userInfo = 
//{
//    new UserInfo("Иван","Иванов",900),
//    new UserInfo("Алексей","Ерохин",120000),
//    new UserInfo("Петр","Петров",8000),
//    new UserInfo("Семен","Семенов",1900)
//};
//ArraySort.Sort(userInfo,UserInfo.UserSalary);
//foreach (var item in userInfo)
//{
//    Console.WriteLine(item);
//}
//ArraySort.Sort(userInfo, UserInfo.UserSalaryDesc);
//foreach (var item in userInfo)
//{
//    Console.WriteLine(item);
//}


//void DoOparition(int x,int y,Action<int,int> op)=>op(x,y);
//void Add(int x,int y)=>Console.WriteLine($"{x}+{y}={x+y}");
//void Sub(int x, int y) => Console.WriteLine($"{x}-{y}={x - y}");
//DoOparition(x, y, Add);
//DoOparition(x, y, Sub);

//Predicate<int> IsPositive = x => x > 0;
//Console.WriteLine(IsPositive(10));
//Console.WriteLine(IsPositive(-16));
//1
Random random = new Random();
int[] mas = new int[10];
for (int i = 0;i<mas.Length;i++) mas[i]=random.Next(10,100);
foreach (int i in mas) Console.Write(i+" ");
Console.WriteLine();
//2
List<DateTime> tList = new List<DateTime>()
{
    DateTime.Parse("2024-07-28"),
    DateTime.Parse("2024-07-20"),
    DateTime.Parse("2024-07-19"),
    DateTime.Parse("2024-07-27"),
};
CheckPredicatesDate(tList, x => x > DateTime.Now);
void CheckPredicates(int[] x, Predicate<int> filter)
{
	for (int i = 0; i < mas.Length; i++)
	{
		if (filter(x[i])) Console.Write(x[i]+" ");
    }
    Console.WriteLine();
}

void CheckPredicatesDate(List<DateTime> x, Predicate<DateTime> filter)
{
    for (int i = 0; i < x.Count; i++)
    {
        if (filter(x[i])) Console.Write(x[i] + " ");
    }
    Console.WriteLine();
}
CheckPredicates(mas, x => x % 2 == 0);



