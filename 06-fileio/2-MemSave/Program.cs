namespace _2_MemSave;

class Program
{
    string welkomstTekst = "";
    string saveFile = "welkomState.txt";
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    internal void Run()
    {
        bool bestaatDeFile = File.Exists(saveFile);

        if (bestaatDeFile == true)
        {
            welkomstTekst = File.ReadAllText(saveFile);
        }
        Console.WriteLine(welkomstTekst);

        while (true)
        {
            Console.WriteLine("Enter a text, then press enter");
            welkomstTekst = Console.ReadLine();
            if (welkomstTekst.Length > 0)
            {
                File.WriteAllText(saveFile, welkomstTekst);
            }
        }
    }
}