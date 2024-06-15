using Lesson5;
using Lesson5.Piramids;

Person person = new Person();
person.Move();
person.Eat();
person.Read();
People people = new People(610);
people.Id = 67;

Heops heops = new Heops();
public record People
{
    public People(int id) => Id = id;
    public int Id { get; set; }
}



