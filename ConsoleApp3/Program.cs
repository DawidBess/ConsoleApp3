// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Runtime.InteropServices.ComTypes;
using ConsoleApp3;

internal class Program
{
    public static void Main(string[] args)
    {
        Person p1 = new Person("Łukasz Drzewiecki", 176, 97);

        Person p2 = new Person("Dawid Bessman", 16, 75);
        
        p1.CompareWeight(p2);
        
        double roznicaWagi = p1.Weight - p2.Weight;
        Console.WriteLine("roznca wagi " + roznicaWagi + "kg");
        
        p2.ComparAge(p1);
    }
}
    
    
