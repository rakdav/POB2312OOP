using Lesson3;

//Person p1 = new Person() { Name = "Иванов И.И." };
//Person p2 = new Person() { Name = "Петров П.П." };
//Person p3 = new Person() { Name = "Сидоров С.И." };
//Person[] persons = new Person[3];
//persons[0] = p1;
//persons[1] = p2;
//persons[2] = p3;
//Company company = new Company { Personal = persons };
//Console.WriteLine(company.Personal[0].Name);//без индексатора
//Console.WriteLine(company[2].Name);//c индексатором

//User user = new User();
//user["name"] = "Иванов И.И.";
//user["email"] = "mail@inbox.ru";
//user["phone"] = "+7(909)679-78-07";

//Console.WriteLine(user["name"]+" "+ user["email"]+" "+ user["phone"]);

//Random random = new Random();
//int[,] mas = new int[3, 4];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//	for (int j = 0; j < mas.GetLength(1); j++)
//	{
//		mas[i, j] = random.Next(10, 100);
//	}
//}
//Matrix matrix = new Matrix(mas);
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//	for (int j = 0; j < mas.GetLength(1); j++)
//	{
//		Console.Write(matrix[i,j]+ " ");
//	}
//	Console.WriteLine();
//}

Massiv massive = new Massiv(10);
massive.Fill();
massive.Print();

massive.Mix();
massive.Print();

Console.WriteLine(massive.Different());




