
KeyEvent evnt = new KeyEvent();
evnt.KeyDown += (sender, e) =>
{
    switch (e.ch)
    {
        case 'C':
            {
                MyColor(true);
                break;
            }
        case 'B':
            {
                MyColor(false);
                break;
            }
        case 'S':
            {
                try
                {
                    Console.Write("Введите длину:");
                    int width = int.Parse(Console.ReadLine()!) / 8;
                    Console.Write("Введите ширину:");
                    int height = int.Parse(Console.ReadLine()!) / 8;
                    Console.WindowWidth = width;
                    Console.WindowHeight = height;
                    Console.WriteLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Окно на столько не растянется!");
                }
                break;
            }
        case 'T':
            {
                Console.Write("Введите новый заголовок:");
                string s = Console.ReadLine()!;
                Console.Title = s;
                Console.WriteLine();
                break;
            }
        case 'R':
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
                break;
            }
        case 'E':
            {
                Console.Beep();
                break;
            }
        default:
            {
                Console.WriteLine("Такая команда не найдена!");
                break;
            }
    }
};

ConsoleTitle();
char ch;
do
{
    Console.Write("Введите команду:");
    ConsoleKeyInfo key = Console.ReadKey();
    Console.WriteLine();
    ch = key.KeyChar;
    evnt.OnKeyDown(key.KeyChar);
}
while (ch != 'E');

void ConsoleTitle()
{
    CC(ConsoleColor.Green);
    Console.WriteLine("Программа настройки консоли");
    CC(ConsoleColor.Yellow);
    Console.WriteLine("Управляюшие команды:");
    Command("C", "Поменять цвет текста");
    Command("B", "Поменять цвет фона");
    Command("S", "Поменять размер окна");
    Command("T", "Поменять заголовок");
    Command("R", "Сбросить изменения");
    Command("E", "Выход");
    Console.WriteLine();
}
void CC(ConsoleColor color)
{
    Console.ForegroundColor= color;
}
void Command(string s1,string s2)
{
    CC(ConsoleColor.Red);
    Console.Write(s1);
    CC(ConsoleColor.White);
    Console.WriteLine(" - "+s2+"\n");
}
void MyColor(bool F_or_B)
{
    link1:
    Console.Write("Введите цвет:");
    string color=Console.ReadLine()!;
    switch(color)
    {
        case "Black":
            {
                if (F_or_B)
                    Console.ForegroundColor = ConsoleColor.Black;
                else
                    Console.BackgroundColor=ConsoleColor.Black;
                break;
            }
        case "Yellow":
            {
                if (F_or_B)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                    Console.BackgroundColor = ConsoleColor.Yellow;
                break;
            }
        case "Green":
            {
                if (F_or_B)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.BackgroundColor = ConsoleColor.Green;
                break;
            }
        case "Red":
            {
                if (F_or_B)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.BackgroundColor = ConsoleColor.Red;
                break;
            }
        case "Blue":
            {
                if (F_or_B)
                    Console.ForegroundColor = ConsoleColor.Blue;
                else
                    Console.BackgroundColor = ConsoleColor.Blue;
                break;
            }
        case "Gray":
            {
                if (F_or_B)
                    Console.ForegroundColor = ConsoleColor.Gray;
                else
                    Console.BackgroundColor = ConsoleColor.Gray;
                break;
            }
        case "White":
            {
                if (F_or_B)
                    Console.ForegroundColor = ConsoleColor.White;
                else
                    Console.BackgroundColor = ConsoleColor.White;
                break;
            }
        default:
            {
                Console.WriteLine("Такого цвета нет!");
                goto link1;
            }
    }
    Console.WriteLine("Цвет изменился!");
}
class MyEventArgs:EventArgs 
{
    public char ch;
}
class KeyEvent
{
    public event EventHandler<MyEventArgs> KeyDown;
    public void OnKeyDown(char ch)
    {
        MyEventArgs c=new MyEventArgs();
        if(KeyDown != null)
        {
            c.ch = ch;
            KeyDown(this, c);
        }
    }
}
