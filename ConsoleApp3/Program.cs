// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Runtime.InteropServices.ComTypes;
using ConsoleApp3;

internal class Program
{
    public static void Main(string[] args)
    {
        Person p1 = new Person("Łukasz Drzewiecki");
        p1.Weight = 97;
        p1.Age = 16;

        Person p2 = new Person("Dawid Bessman");
        p2.Weight = 76;
        p2.Age = 16;
        if (p2.Age == p1.Age)
        {
            Console.WriteLine("waza tyle samo");
        }

        p2.AmIHeavier(p1);
        int ageDiff = p2.Age - p1.Age;
        var message = ageDiff switch
        {
            0 => "Sa rowno starzy",
            int a when a < 15 => "Sa rowno starzy",
            int a => "Sa rowno starzy",
            _ => "Sa rowno starzy"
        };
        
        Console.WriteLine(message);

        int diff =  p2.Age - p1.Age;

            if (p2.Age < p1.Age)
        {
            Console.WriteLine( p2.Name + " jest lzejszy");
        }
        if (p1.Age < p2.Age)
        {
            Console.WriteLine( p1.Name + " jest lzejszy");
        }
        
        double roznicaWagi = p1.Weight - p2.Weight;
        Console.WriteLine("roznca wagi " + roznicaWagi + "kg");

        if (p2.Age == p1.Age)
        {
            Console.WriteLine("Są w tym samym wieku");
        }

        p2.AmIHeavier(p1);
        if (p2.Age < p1.Age)
        {
            Console.WriteLine( p2.Name + " jest młodszy");
        }
        if (p1.Age < p2.Age)
        {
            Console.WriteLine( p1.Name + " jest młodszy");
        }
        int rozwicaWieku = p1.Age - p2.Age;
        Console.WriteLine("roznica wieku po między Dawidem a Łukaszem wynosi " + rozwicaWieku);
        
        
        List<Person> persons = new List<Person>();
        bool isPersonPresent = persons.Contains(person);
        Console.WriteLine(isPersonPresent.ToString());
        
        bool isPersonPresent = persons.Contains(person);
        Console.WriteLine(isPersonPresent.ToString()););
        person.weight = "300kg";
        person.age = 60;
        person.name = "Łukasz Drzewiecki";
    }
}










