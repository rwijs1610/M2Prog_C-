namespace _3_ProductenLaden;

using System.Net.Http.Headers;
using System.Text.Json;
class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
        program.RunProducten();
        program.RunAfspraak();
    }

    void Run()
    {
        // string text = System.IO.File.ReadAllText("Product.json");
        // Product product = JsonSerializer.Deserialize<Product>(text);
        // Console.WriteLine(product.Name);
        // Console.WriteLine(product.Description);
        // Console.WriteLine(product.Price);

    }
    void RunProducten()
    {
        string text = System.IO.File.ReadAllText("Producten.json");
        Product[] product = JsonSerializer.Deserialize<Product[]>(text);
        foreach (Product p in product)
        {
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Description);
            Console.WriteLine(p.Price);
        }
    }
    void RunAfspraak(){
        string text = System.IO.File.ReadAllText("Afspraak.json");
        Afspraak[] afspraak = JsonSerializer.Deserialize<Afspraak[]>(text);
        foreach (Afspraak a in afspraak)
        {
            Console.WriteLine(a.tijd);
            Console.WriteLine(a.beschrijving);
            Console.WriteLine(a.dag);
        }
    }
}
