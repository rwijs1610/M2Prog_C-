namespace _01_functions;

class Program
{
    string[] vragen = new string[]
    {
        "What 1997 N64 video game, features James Bond and is named after the 1995 film?",
        "What arcade game was called Puckman in Japan?",
        "In July 2023, video game company EA announced that players will be able to explore Wakanda in an upcoming open-world video game based on the adventures of what Marvel superhero?",
        "Which spooky 2001 GameCube game starring Mario’s brother got a reboot for Nintendo Switch in 2019?", 
        "Regarded as one of the greatest video games of all time, what 1981 arcade game features the titular amphibian trying to cross a road without getting squashed by cars, and a river without getting eaten by predators?",
        "What is thought to be the first video game, created in 1958 and becoming popular in the 1970s?",

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
