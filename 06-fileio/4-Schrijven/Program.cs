namespace _4_Schrijven;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    void Run()
    {
        string[] lines = { "Eerste regel", "Tweede regel", "Derde regel" };
        System.IO.File.WriteAllLines("mijntekst.txt", lines);
        
    }
}
