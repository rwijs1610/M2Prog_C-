namespace _01_functions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Program program = new Program(); //een program // void // new het maakt een nieuw object van het type Program // hij returned void 
        program.Run(); 
    }
    internal void Run()
    {
        Console.WriteLine("Dit is nu de start van mijn programma");
    }
    internal void Vraag1()
    {
        Console.WriteLine("Hoe lang zou jij overleven in een zombie apocalypse?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }
    internal void Vraag2()
    {
        Console.WriteLine("Why do round pizzas come in square boxes?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }
    internal void Vraag3()
    {
        Console.WriteLine("Has someone caught you dancing in front of the mirror?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }
    internal void Vraag4()
    {
        Console.WriteLine("Have you ever tried talking to a animal?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }
    internal void Vraag5()
    {
        Console.WriteLine("What would you call a male ladybug?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }
    internal void Vraag6()
    {
        Console.WriteLine("Which species would be the rudest if all animals could talk?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }
}
