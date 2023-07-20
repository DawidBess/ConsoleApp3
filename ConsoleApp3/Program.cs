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
        p1.Age = 176;

        Person p2 = new Person("Dawid Bessman");
        p2.Weight = 75;
        p2.Age = 16;
        
        if (p2.Age == p1.Age)
        {
            Console.WriteLine("waza tyle samo");
        }
        else if (p2.Age < p1.Age)
        {
            Console.WriteLine( p2.Name + " jest lzejszy");
        }
        else if (p2.Age > p1.Age)
        {
            Console.WriteLine( p1.Name + " jest lzejszy");
        }
        
        double roznicaWagi = p1.Weight - p2.Weight;
        Console.WriteLine("roznca wagi " + roznicaWagi + "kg");

        if (p2.Age == p1.Age)
        {
            Console.WriteLine("Są w tym samym wieku");
        }
        else if (p2.Age < p1.Age)
        {
            Console.WriteLine( p2.Name + " jest młodszy");
        }
        else if (p1.Age < p2.Age)
        {
            Console.WriteLine( p1.Name + " jest młodszy");
        }
        int rozwicaWieku = p1.Age - p2.Age;
        Console.WriteLine("roznica wieku po między Dawidem a Łukaszem wynosi " + rozwicaWieku);
    }
}
