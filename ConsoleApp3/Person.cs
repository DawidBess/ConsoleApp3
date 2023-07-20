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
    
}