using System.Diagnostics.SymbolStore;

void PrintUpper(string? text)
{
    Console.WriteLine(text!.ToUpper());
}
void IsNull(int? obj)
{
    if (obj == null) Console.WriteLine("null");
    else Console.WriteLine(obj);
}
//string? name = null;
//PrintUpper(name);
//!(null-forgiving operator)-позволяет указать, что переменная ссылочного типа не равна null
void PrintNullable(int? n)
{
    if (n.HasValue)
    {
        Console.WriteLine(n.Value);
    }
    else
    {
        Console.WriteLine("null");
    }
}
bool IsPolindrom(int? x)
{
    return x+(int?)7>0;
}
//int? val = null;
//IsNull(val);
//val = 23;
//IsNull(val);
//Nullable<int> val2 = 6;
//PrintNullable(5);
//PrintNullable(null);
//int? x = val + 8;

//if (x is null) Console.WriteLine("null");
//else Console.WriteLine(x);

//if (x is not null) Console.WriteLine(x);
//else Console.WriteLine("null");

////?? null-объединение

////левый_операнд??правый_операнд
//string? text = null;
//text = "Tom";
//string name = text ?? "MyName";
//Console.WriteLine(name);

//int? id = null;
//Console.WriteLine(id ?? 0);
//int? number = null;
//int? x = number;
//Console.WriteLine(number??0);

//void PrintWebSite(Person? person)
//{
//if (person != null)
//{
//    if (person.Company != null)
//    {
//        if (person.Company.WebSite != null)
//        {
//            Console.WriteLine(person.Company.WebSite.ToUpper());
//        }
//    }
//}
//    Console.WriteLine(person?.Company?.WebSite?.ToUpper());
//}
//Company company = new Company { WebSite = "www.microsoft" };
//Person person = new Person { Company = company };
//PrintWebSite(person);
//class Person
//{
//    public Company? Company { get; set; }
//}
//class Company
//{
//    public string? WebSite { get; set; }
//}

Schet schet = new Schet { Number = "123456", Enabled = true, Money = 50000 };
Card card = new Card { Schet = schet, Block = false };
Client client = new Client { Card = card };
Administrator admin = new Administrator();
Order order = new Order { Client = client, Price = 24000 };
order.Sdelka();
Console.WriteLine(client.Card.Schet.Money);
Order order2 = new Order { Client = client, Price = 30000 };
if (order2.Price > client.Card.Schet.Money)
{
    order2.Sdelka();
    admin.BlockCard(card);
}
order2.Sdelka();
Console.WriteLine(client.Card.Schet.Money);
class Schet
{
    public string? Number { get; set; }
    public decimal Money { get; set; }
    public bool Enabled { get; set; }
    public void Sub(decimal money)
    {
        Money -= money;
    }
}
class Card
{
    public Schet? Schet { get; set; }
    public bool Block { get; set; }
}
class Client
{
    public Card? Card { get; set; }
    public void BlockCard(Card card)
    {
        card.Block = true;
    }
    public void EnabledSchet(Schet schet)
    {
        schet.Enabled = false;
    }
}
class Administrator
{
    public void BlockCard(Card card)
    {
        card.Block = true;
    }
 
}
class Order
{
    public Client? Client { get; set; }
    public decimal Price { get; set; }
    public void Sdelka()
    {
        if (Client?.Card?.Schet?.Enabled != false && Client?.Card?.Block != true)
        {
            if(Price<Client?.Card?.Schet?.Money)
                Client?.Card?.Schet?.Sub(Price);
        }
        else
        {
            Console.WriteLine("Карта или счет заблокированы!");
        }
    }

}