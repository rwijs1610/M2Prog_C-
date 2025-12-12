using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization.Formatters;

namespace _2_Lists;

class Program
{
    string[] namen = new string[]
    {
        "Pac-Man",
        "Samus",
        "Crash Bandicoot",
        "Spyro the Dragon",
        "Donkey Kong",
        "Mario",
        "Luigi",
        "Astro",
        "Solid Snake",
        "Master Chief",
        "Kratos",
        "Sonic the Hedgehog",
        "Link"
    };

    List<string> characterList = new List<string>();
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Program program = new Program();
        program.Run();
    }

    internal void Run()
    {
        characterList.Add("ALEXIOS");

        for (int i = 0; i < namen.Length; i++)
        {
            characterList.Add(namen[i]);
        }
        for (int i = 0; i < characterList.Count; i++)
        {
            Console.WriteLine(characterList[i]);
        }
        foreach (var item in characterList)
        {
            Console.WriteLine(item);
        }
    }
}
