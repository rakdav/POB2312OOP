using System.Runtime.CompilerServices;

//ClassParent parent = new ClassParent(5, 9);
//Console.WriteLine(parent.getX);
//Child child = new Child(6);
//Console.WriteLine(child.getX);

Student vasia = new Student("Иванов", "Василий","21ПОБ12",4.5);
Console.WriteLine(vasia.getScholarship());
Aspirant borya = new Aspirant("Петров", "Борис","", 5, "Геофизика");
Console.WriteLine(borya.getScholarship());

Student[] group = new Student[5];
group[0] = vasia;
group[1] = borya;
group[2] = new Student("Федоров", "Илья","22ПОБ27", 4.9);
Student sam = new Aspirant("Сидоров","Сам","",3.8,"Биология");//восходящее преобразование
group[3] = sam;
Student maks = new Student("Планк", "Макс","",5);
group[4] = maks;
Console.WriteLine(group[4].getScholarship());
////нисходящее
//Aspirant? maksAspirant = (Aspirant)maks;
//maksAspirant!.ScientistWork = "Химия";

//Console.WriteLine(maksAspirant!.getScholarship());




class ClassParent
{
    private int x;
    protected int y;
    public int getX { get { return x; } }
    public ClassParent(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public ClassParent(int y)
    {
        this.y = y;
    }
}
class Child : ClassParent
{
    public Child(int y):base(y){}

    public void Method()
    {
        // int c = base.x;
        Console.WriteLine(base.y);
        double d = y;
        Console.WriteLine(d);
    }
}

class Student
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    protected string? Group { get;}
    private double averageMark;
    public double AverageMark
    {
        get { return averageMark; }
        set { if (value >= 2 && value <= 5) averageMark = value;
            else value = 0;
        }
    }
    public Student(string? firstName, string? lastName, string? group, double averageMark)
    {
        FirstName = firstName;
        LastName = lastName;
        Group = group;
        AverageMark = averageMark;
    }

    public virtual decimal getScholarship()
    {
        if (AverageMark == 5) return 5000;
        return 3000;
    }

    //public decimal getScholarship()
    //{
    //    if (AverageMark == 5) return 5000;
    //    return 3000;
    //}
}

class Aspirant : Student
{
    public string ScientistWork { get; set; }
    public Aspirant(string? firstName, string? lastName, string? group, double averageMark,string scientistWork) : base(firstName, lastName, group, averageMark)
    {
        ScientistWork = scientistWork;
    }

    public override decimal getScholarship()
    {
        if (AverageMark == 5) return 25000;
        return 15000;
    }

//    public new decimal getScholarship()
//    {
//        if (AverageMark == 5) return 25000;
//        return 15000;
//    }
}


