using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
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

    List<double> reviews = new List<double>() { 9.99, 4.68, 342.97, 12.2 };
    List<Pickup> pickups = new List<Pickup>();
    internal class Pickup
    {
        internal int x, y;
    }

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
        // reviews.Remove(342.97);
        // reviews.RemoveAt(0);
        // for (int i = 0; i < reviews.Count; i++)
        // {
        //     Console.WriteLine(reviews[i]);
        // }
        for (int i = 0; i < 10; i++)
        {
            Pickup pickup = new Pickup()
            {
                x = i,
                y = 0
            };
            pickups.Add(pickup);
        }
        // foreach (Pickup pickup in pickups)
        // {
        //     if(pickup.x == 4)
        //     {
        //         pickups.Remove(pickup);
        //     }
        // }
        for (int i = pickups.Count - 1; i >= 0; i--)
        {
            if (i == 4)
            {
                pickups.RemoveAt(i);
            }
        }
        for (int i = 0; i < pickups.Count; i++)
        {
            Console.WriteLine($"Pickup at {pickups[i].x} is still there");
            if (i == 4)
            {
                Console.WriteLine($"Pickup at {i} was removed");
            }   
        }

    }
}
