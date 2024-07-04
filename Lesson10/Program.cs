//1.Управление задачами:
//Создайте консольное приложение для управления списком задач.
//Используйте List для хранения задач. Пользователь должен иметь
//возможность добавлять, удалять и просматривать задачи.

//using Lesson10;

//List<OurTask> taskList = new List<OurTask>();
//while (true)
//{
//    Console.Clear();
//    Console.WriteLine("Меню:\n" +
//        "1 - Добавить задачу\n" +
//        "2 - Удалить задачу\n" +
//        "Список задач:");
//    int count = 0;
//    taskList.ForEach(task => Console.WriteLine(++count + "." + task.TaskName + " " + task.Priority));
//    Console.Write("Выберите пункт меню:");
//    int n;
//    int.TryParse(Console.ReadLine(), out n);
//    switch (n)
//    {
//        case 1: 
//            {
//                Console.Write("Введите название задачи:");
//                string name = Console.ReadLine()!;
//                Console.Write("Введите приоритет задачи:");
//                int p;
//                int.TryParse(Console.ReadLine(),out p);
//                taskList.Add(new OurTask { TaskName = name, Priority = p });
//            }
//            break;
//        case 2: 
//            {
//                Console.Write("Введите номер задачи:");
//                int taskNumber;
//                int.TryParse(Console.ReadLine(), out taskNumber);
//                taskList.RemoveAt(taskNumber-1);
//             //   Console.WriteLine("Задача " + taskList[taskNumber-1].TaskName+" удалена");
//            } 
//            break;
//    }
//}

//LinkedList
//var list = new List<string> {"Tom", "Jerry", "Kan" };
//LinkedList<string> employes = new LinkedList<string>(list);
//Console.WriteLine(employes.Count);
//Console.WriteLine(employes.First!.Value);
//Console.WriteLine(employes.Last!.Value);
//employes.AddFirst("Sam");
//employes.AddLast("John");
//foreach (var item in employes)
//{
//    Console.Write(item+" ");
//}
//Console.WriteLine();
//var current = employes.First;
//while (current != null)
//{
//    Console.Write(current.Value+" ");
//    current = current.Next;
//}
//Console.WriteLine();
//current = employes.Last;
//while (current != null)
//{
//    Console.Write(current.Value + " ");
//    current = current.Previous;
//}
//Console.WriteLine();
//if (employes.First != null) employes.AddBefore(employes.First, "Bob");
//foreach (var item in employes)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();
//employes.RemoveFirst();
//employes.RemoveLast();

//2.Учет посещений:
//using System.Collections.Generic;

//Dictionary<string, int> visits = new Dictionary<string, int>();
//while (true)
//{
//    Console.Write("Введите имя клиента:");
//    string name = Console.ReadLine()!;
//    if (!visits.ContainsKey(name)&&name.ToLower()!= "выход")
//    {
//        visits.Add(name, 1);
//    }
//    else
//    {
//        if (name.ToLower() != "выход")
//        {
//            int value;
//            visits.TryGetValue(name, out value);
//            value++;
//            visits[name] = value;
//        }
//    }
//    if (name.ToLower() == "выход") 
//    {
//        foreach (KeyValuePair<string,int> kvp in visits)
//            Console.WriteLine(kvp.Key+" "+kvp.Value);
//        break;
//    };
//}

//3.Проверка на уникальность:
//Напишите функцию, которая принимает массив и возвращает true, если
//все элементы в массиве уникальны, и false в противном случае.
//Используйте HashSet для решения этой задачи.

//bool IsUniqueArray(int[] mas)
//{
//    HashSet<int> set = new HashSet<int>();
//    for (int i = 0; i < mas.Length; i++) set.Add(mas[i]);
//    if (mas.Length == set.Count) return true;
//    return false;
//}
//Random random = new Random();
//int[] mas = new int[10];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(1, 1000);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//if (IsUniqueArray(mas)) Console.WriteLine("Уникальный");
//else Console.WriteLine("Не уникальный");

//4.Сортировка чисел:
//Создайте приложение для сортировки списка чисел. Реализуйте
//сортировку с использованием List, а затем сравните производительность с
//SortedSet.
//Random random = new Random();
//List<int> list = new List<int>();
//for (int i = 0; i < random.Next(10,21); i++)
//{
//    int n = random.Next(10, 100);
//    list.Add(n);
//    Console.Write(n+" ");
//}
//Console.WriteLine();
////list.Sort();
//list.ForEach(a => Console.Write(a + " "));
//Console.WriteLine();
//SortedSet<int> set = new SortedSet<int>(list);
//foreach (int i in set) Console.Write(i+" ");
//Console.WriteLine();

//5.Подсчет слов:
//Console.Write("Введите текст:");
//string text = Console.ReadLine()!;
//string[] mas = text.Split(' ', ',');
//Dictionary<string, int> visits = new Dictionary<string, int>();
//foreach (string item in mas)
//{
//    if (!visits.ContainsKey(item))
//    {
//        visits.Add(item, 1);
//    }
//    else
//    {
//        int value;
//        visits.TryGetValue(item, out value);
//        visits[item] =++value;
//    }
//}
//foreach (KeyValuePair<string, int> kvp in visits)
//           Console.WriteLine(kvp.Key+" "+kvp.Value);

//6.Учет инвентаря
//Dictionary<string, int> visits = new Dictionary<string, int>();
//HashSet<string> diff = new HashSet<string>();
//while (true)
//{
//    Console.Write("Введите название инвентаря:");
//    string name = Console.ReadLine()!;
//    if (!visits.ContainsKey(name) && name.ToLower() != "выход")
//    {
//        visits.Add(name, 1);
//        diff.Add(name);
//    }
//    else
//    {
//        if (name.ToLower() != "выход")
//        {
//            int value;
//            visits.TryGetValue(name, out value);
//            value++;
//            visits[name] = value;
//        }
//    }
//    if (name.ToLower() == "выход")
//    {
//        foreach (KeyValuePair<string, int> kvp in visits)
//            Console.WriteLine(kvp.Key + " " + kvp.Value);
//        foreach (string i in diff) Console.Write(i+" ");
//        Console.WriteLine();
//        break;
//    };
//}

using System.ComponentModel;
using System.IO;

Dictionary<string, int> errors = new Dictionary<string, int>();
using (StreamReader reader = new StreamReader("Log.txt"))
{
    string? line;
    while ((line = await reader.ReadLineAsync()) != null)
    {
        string[] mas = line.Split("Ошибка:");
        if (!errors.ContainsKey(mas[1]))
        {
            errors.Add(mas[1], 1);
        }
        else
        {
            int value;
            errors.TryGetValue(mas[1], out value);
            errors[mas[1]] = ++value;
        }
    }
    foreach (KeyValuePair<string, int> kvp in errors)
            Console.WriteLine(kvp.Key + " " + kvp.Value);
}

//8. Календарь событий:
