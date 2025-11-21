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
        Console.WriteLine();
    }
}
