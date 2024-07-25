MyEvent myEvent = new MyEvent();
UserInfo userInfo = new UserInfo(name : "Alex", famaly : "Erohin", age : 26 );
myEvent.UserEvent += userInfo.UserInfoHandler;
myEvent.OnUserEvent();

delegate void UI();
class MyEvent
{
    UI[] evnt=new UI[5];
    public event UI UserEvent 
    {
        add 
        {
            evnt[1] = value;
        }
        remove 
        {
            evnt[1]= null;
        }
    }
    public void OnUserEvent()
    {
        //UserEvent();
        evnt[1]();
    }
}

class UserInfo
{
    public string? Name { get; set; }
    public string? Family { get; set; }
    public int Age { get; set; }
    public UserInfo(string? name, string? famaly, int age)
    {
        Name = name;
        Family = famaly;
        Age = age;
    }
    public void UserInfoHandler()
    {
        Console.WriteLine("Событие вызвано!");
        Console.WriteLine($"Имя:{Name} Фамилия:{Family} Возраст:{Age}");
    }
}
