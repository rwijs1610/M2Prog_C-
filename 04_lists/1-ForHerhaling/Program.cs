using System.Reflection;
using System.Runtime.Serialization.Formatters;

namespace _04_lists;

class Program
{
    double[] prijzen = new double[] { 0.99, 5.60, 10.11, 2.50 };
    string[] artiekelen = new string[] { "snoepje", "luxe broodjes", "lunch menu", "koekjes" };
    Formulier[] formulieren = new Formulier[2];

    internal class Formulier
    {
        internal int Sterren { get; set; }
        internal string Feedback { get; set; }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Program program = new Program();
        program.Run();    
    }
    internal void Run()
    {   
        p.formulieren[0] = new Formulier()
        {
            Feedback = "prijzen maar lekker",
            Sterren = 5
        };
        p.formulieren[1] = new Formulier()
        {
            Feedback = "eten viel tegen",
            Sterren = 2
        };
        for (int i = 0; i < p.prijzen.Length; i++)
        {
            Console.WriteLine(p.artiekelen[i]);
            Console.WriteLine(p.prijzen[i]);
        }
        foreach (Formulier formulier in p.formulieren)
        {
            Console.WriteLine($"{formulier.Feedback}");
            Console.WriteLine($"{formulier.Sterren}");
        }
    }
}   