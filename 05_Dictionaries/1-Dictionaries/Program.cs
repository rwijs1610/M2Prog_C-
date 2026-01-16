using System;

namespace _01_Dictionaries;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Program program = new Program();
        program.Run();
    }
    internal void Run()
    {
        Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();

        personeelOpNummer.Add(382942, "Jim");
        personeelOpNummer.Add(789432, "tim");

        string jim = personeelOpNummer[382942];
        string tim = personeelOpNummer[789432];

        Console.WriteLine(jim);
        Console.WriteLine(tim);

        foreach (KeyValuePair<int, string> item in personeelOpNummer)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        foreach (int key in personeelOpNummer.Keys)
        {
            Console.WriteLine(key);
        }
        foreach (string value in personeelOpNummer.Values)
        {
            Console.WriteLine(value);
        }

        Room start = new Room(0, 0, new string[] {
            "xxxxx",
            "x   x",
            "x   x",
            "x   x",
            "xxxxx"
        });
        Room room2 = new Room(0, 1, new string[] {
            "xxxxx",
            "x   x",
            "x   x",
            "x   x",
            "xxxxx"
        });
        Room room3 = new Room(1, 1, new string[] {
            "xxxxx",
            "x   x",
            "x   x",
            "x   x",
            "xxxxx"
        });
        
        Room room4 = new Room(1, 0, new string[] {
            "xxxxx",
            "x   x",
            "x   x",
            "x   x",
            "xxxxx"
        });
        rooms.Add(start.GetRoomLocationKey(), start);
        ShowRoom(0, 0);
        rooms.Add(room2.GetRoomLocationKey(), room2);
        ShowRoom(0, 1);
        rooms.Add(room3.GetRoomLocationKey(), room3);
        ShowRoom(1, 1);
        rooms.Add(room4.GetRoomLocationKey(), room4);
        ShowRoom(1, 0);
        ShowRoom(2, 0);


    }

    private void ShowRoom(int x, int y)
    {
        bool hasRoom = rooms.ContainsKey($"{x},{y}");

        if (!hasRoom)
        {
            Console.WriteLine($"There is no room at {x},{y}");
            return;
        }
        Room room = rooms[$"{x},{y}"];

        Console.WriteLine($"You are in room at {x},{y}");
        foreach (string r in room.level)
        {
            Console.WriteLine(r);
        }
    }
    Dictionary<string, Room> rooms = new Dictionary<string, Room>();
}
