using Lesson16.Console;
UserRegistration userRegistration = new UserRegistration();
do
{
    Console.Clear();
    Console.WriteLine("Список пользователей:");
    userRegistration.Print();
    Console.WriteLine("Меню: 1 - Зарегистрироваться\n");
    Console.WriteLine("Выбрите пункт меню:");
    int n;
    int.TryParse(Console.ReadLine(), out n);
    if(n == 1)
    {
        Console.Write("Введите ник пользователя:");
        string nike=Console.ReadLine()!;
        Console.Write("Введите имя пользователя:");
        string name = Console.ReadLine()!;
        Console.Write("Введите фамилию пользователя:");
        string lastName = Console.ReadLine()!;
        Console.Write("Введите адрес электронной почты:");
        string mail = Console.ReadLine()!;
        Console.Write("Введите пароль пользователя:");
        string password = Console.ReadLine()!;
        Console.Write("Введите дату регистрации:");
        DateTime dateRegister = DateTime.Parse(Console.ReadLine()!);
        Console.Write("Введите дату рождения:");
        DateTime dateBirth = DateTime.Parse(Console.ReadLine()!);
        User user = new User(nike,name,lastName,mail,password,dateRegister,dateBirth);
        userRegistration.RegisterUser(user);
    }
}while(true);
