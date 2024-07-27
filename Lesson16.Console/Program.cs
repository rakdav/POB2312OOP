using Lesson16.Console;
UserRegistration userRegistration = new UserRegistration();
do
{
    Console.Clear();
    Console.WriteLine("Список пользователей:");
    Console.WriteLine(userRegistration.Print());
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
        User user = new User { UserName = nike,
            FirstName = name, SecondName = lastName, Email =mail,
            Password=password, BirthDate=dateBirth,RegistrationDate=dateRegister
        };
        if(userRegistration.RegisterUser(user)) Console.WriteLine("Пользователь успешно зарегистрирован!");
        else Console.WriteLine("Пользователь с таким именем или паролем существует!");
    }
}while(true);
