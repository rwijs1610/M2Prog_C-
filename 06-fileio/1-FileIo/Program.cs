namespace _1_FileIo;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    void Run()
    {
        Console.WriteLine(Environment.CurrentDirectory);

    string[] lines = System.IO.File.ReadAllLines("quiz.txt");

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

    string[] linesNieuws = System.IO.File.ReadAllLines("nieuws.txt");

        foreach (string line in linesNieuws)
        {
            Console.WriteLine(line);
        }
    }
}
