namespace ConsoleApp3;

public class Person
{
    public Person(string name, int age, double weight)
    {
        this.Name = name;
        this.Age = age;
        this.Weight = weight;
    }

    public double Weight { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }

    public bool AmIHeavier(Person person)
    {
        return false;
    }

    bool AmIOlder(Person person)
    {
        return false;
    }

    public void CompareWeight(Person p2)
    {
        if (this.Weight == p2.Weight)
        {
            Console.WriteLine("waza tyle samo");
        }
        else if (this.Weight < p2.Weight)
        {
            Console.WriteLine(this.Name + " jest lzejszy");
        }
        else if (this.Weight > p2.Weight)
        {
            Console.WriteLine(p2.Name + " jest LŻEJSZY");
        }

    }
    public void ComparAge(Person p2)
    {
        if (this.Age == p2.Age)
        {
            Console.WriteLine("Są w tym samym wieku");
        }
        else if (this.Age < p2.Age)
        {
            Console.WriteLine(this.Name + " jest młodszy");
        }
        else if (this.Age > p2.Age)
        {
            Console.WriteLine(p2.Name + " jest młodszy");
        }

        int rozwicaWieku = p2.Age - this.Age;
        Console.WriteLine("roznica wieku po między Dawidem a Łukaszem wynosi " + rozwicaWieku);
    }
}
