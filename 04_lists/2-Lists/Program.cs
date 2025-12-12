using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Reflection.Emit;
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

    List<double> reviews = new List<double>(){9.99, 4.68, 342.97, 12.2};
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Program program = new Program();
        program.Run();
    }

    internal void Run()
    {
        characterList.Add("ALEXIOS");

        // for (int i = 0; i < namen.Length; i++)
        // {
        //     characterList.Add(namen[i]);
        // }
        // for (int i = 0; i < characterList.Count; i++)
        // {
        //     Console.WriteLine(characterList[i]);
        // }
        // foreach (var item in characterList)
        // {
        //     Console.WriteLine(item);
        // }
        reviews.Remove(342.97);
        reviews.RemoveAt(0);
        for (int i = 0; i < reviews.Count; i++)
        {
            Console.WriteLine(reviews[i]);
        }
    }
}
