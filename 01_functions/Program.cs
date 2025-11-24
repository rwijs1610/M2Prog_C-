namespace _01_functions;

class Program
{
    string[] vragen = new string[]
    {
        "Hoe lang zou jij overleven in een zombie apocalypse?",
        "Why do round pizzas come in square boxes?",
        "Has someone caught you dancing in front of the mirror?",
        "Have you ever tried talking to a animal?", 
        "What would you call a male ladybug?",
        "Which species would be the rudest if all animals could talk?",

    };
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Program program = new Program(); //een program // void // new het maakt een nieuw object van het type Program // hij returned void 
        program.Run(); 


    }
    internal void Run()
    {
        Console.WriteLine("Dit is nu de start van mijn programma");
        // Vraag1();
        // Vraag2();
        // Vraag3();
        // Vraag4();
        // Vraag5();
        // Vraag6();
        // Console.WriteLine(Vraag7());
        // string vraag0 = GetRandomVraag();
        AskRandomQuestion();
        AskRandomQuestion();
        AskRandomQuestion();
        AskRandomQuestion();

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
    internal string Vraag7()
    {
        Console.WriteLine("Hoe lang zou jij overleven in een zombie apocalypse?");
        string antwoord = Console.ReadLine();
        return antwoord;
    }
    internal string GetVraag(int vraagIndex)
    {
        return vragen[vraagIndex];
    }
    internal string GetRandomVraag()
    {
        Random random = new Random();
        int randomIndex = random.Next(vragen.Length);
        return GetVraag(randomIndex);
    }
    internal string AskRandomQuestion()
    {
        string vraag8 = GetRandomVraag();
        Console.WriteLine(vraag8);
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
        return antwoord;
    }
}
