using Lesson11;
using System.ComponentModel.Design;

void Swap<T>(ref T a,ref T b)
{
    (a, b) = (b, a);
}

void ReverseMas<T>(T[] mas)
{
    for (int i = 0; i < mas.Length - 1; i++)
        (mas[i], mas[i+1]) = (mas[i + 1], mas[i]);
}

void SendMessage<T>(T mes) where T:Message
{
    Console.WriteLine($"Отправляется сообщение: {mes.Text}");
}

SendMessage(new Message("Hello"));
SendMessage(new EmailMessage("Hello"));
SendMessage(new SmsMessage("Hello"));

Messanger<Message> telegram = new Messanger<Message>();
telegram.SendMessage(new Message("Hello from telgram"));

Messanger<EmailMessage> outlook = new Messanger<EmailMessage>();
outlook.SendMessage(new EmailMessage("Hello from telgram"));

//Person<int,string> p1 = new Person<int,string>(789656,"qwerty", "Tom");
//Person<int,string>.code = 1;
//Person<string,int> p2 = new Person<string,int>("ASH 67890",234, "Bob");
//Person<int, string>.code++;
//Person<string,int>.code = "meta";
//Console.WriteLine(Person<int, string>.code);
//int id = p1.Id;
//string strId = p2.Id;

//int a = 10, b = 20;
//Console.WriteLine(a+" "+b);
//Swap<int>(ref a,ref b);
//Console.WriteLine(a + " " + b);

//double c = 10.8, d = 20.4;
//Console.WriteLine(c + " " + d);
//Swap<double>(ref c, ref d);
//Console.WriteLine(c + " " + d);
//Random rnd = new Random();
//int[] masInt = new int[rnd.Next(10, 20)];
//double[] masDouble = new double[rnd.Next(10, 20)];
//string[] masString = new string[rnd.Next(10, 20)];
//for(int i = 0; i < masInt.Length; i++)
//{
//    masInt[i] = rnd.Next(10, 100);
//    Console.Write(masInt[i]+" ");
//}
//Console.WriteLine();
//ReverseMas<int>(masInt);
//for (int i = 0; i < masInt.Length; i++)
//{
//    Console.Write(masInt[i] + " ");
//}
//Console.WriteLine();

//for (int i = 0; i < masDouble.Length; i++)
//{
//    masDouble[i] = rnd.NextDouble()*10;
//    Console.Write(masDouble[i].ToString("F2") + " ");
//}
//Console.WriteLine();
//ReverseMas<double>(masDouble);
//for (int i = 0; i < masDouble.Length; i++)
//{
//    Console.Write(masDouble[i].ToString("F2") + " ");
//}
//Console.WriteLine();

//for (int i = 0; i < masString.Length; i++)
//{
//    masString[i] = ((char)rnd.Next(1024,2000)).ToString();
//    Console.Write(masString[i] + " ");
//}
//Console.WriteLine();
//ReverseMas<string>(masString);
//for (int i = 0; i < masString.Length; i++)
//{
//    Console.Write(masString[i] + " ");
//}
//Console.WriteLine();

//Third<int> cl1 = new Third<int>(45);
//Console.WriteLine(cl1.MyVar);

//Third<double> cl2 = new Third<double>(98.6);
//Console.WriteLine(cl2.MyVar);

Teacher<string, string, string> teacher = new Teacher<string, string, string>
{
    Address = "qqqqq",
    Age = 40,
    EyesColor = "Green",
    Gender = "Male",
    Height = 90,
    Id = 1,
    Name = "Василий",
    Phone = "+790067884534",
    Position = "Учитель",
    Rassa = "Европа",
    Rost = 190,
    Salary = 45000,
    Stage = 10,
    Subject = "Физика",
    WorkStart = new DateTime(2000, 12, 3)
};

Teacher<Gender, string, string> teacher2 = new Teacher<Gender, string, string>
{
    Address = "qqqqq",
    Age = 40,
    EyesColor = "Green",
    Gender = Gender.Male,
    Height = 90,
    Id = 1,
    Name = "Василий",
    Phone = "+790067884534",
    Position = "Учитель",
    Rassa = "Европа",
    Rost = 190,
    Salary = 45000,
    Stage = 10,
    Subject = "Физика",
    WorkStart = new DateTime(2000, 12, 3)
};
enum Gender { Male, Female }