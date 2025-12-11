using System.Security.Cryptography;

namespace RijSchool;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    internal void Run()
    {
        Auto auto1 = new Auto()
        {
            automaat = true,
            kenteken = "NL40B1",
            kilometerStand = 32633,
            merk = "Volkswagen"
        };

        Auto auto2 = new Auto()
        {
            automaat = false,
            kenteken = "AUX863",
            kilometerStand = 65739,
            merk = "Volvo"
        };

        RijLeraar rijLeraar = new RijLeraar()
        {
            leeftijd = 60,
            naam = "Gerda",
            zzp = true
        };

        LesPakket lesPakket1 = new LesPakket()
        {
            urenGekocht = 70,
            urenVerbruikt = 60,
            examenPogingen = 1,
            automaat = true
        };

        LesPakket lesPakket2 = new LesPakket()
        {
            urenGekocht = 60,
            urenVerbruikt = 50,
            examenPogingen = 1,
            automaat = false 
        };

        TheorieTest theorieTest1 = new TheorieTest()
        {
            aantalFouten = 6,
            gehaald = false,
            afnameDatum = new DateTime(2025, 11, 26)
        };

        TheorieTest theorieTest2 = new TheorieTest()
        {
            aantalFouten = 4,
            gehaald = true,
            afnameDatum = new DateTime(2025, 12, 10)
        };

        RijTest rijTest1 = new RijTest()
        {
            gehaald = true,
            afnameDatum = new DateTime(2025, 11, 30)
        };

        RijTest rijTest2 = new RijTest()
        {
            gehaald = true,
            afnameDatum = new DateTime(2025, 12, 20)
        };

        Student student1 = new Student()
        {
            naam = "Rens Wijs",
            leeftijd = 16,  
            lesPakket = lesPakket1,
            leraar = rijLeraar,
            theorieTest = theorieTest1,
            rijTest = rijTest1,
        };

        Student student2 = new Student()
        {
            naam = "Deon Telman",
            leeftijd = 17,  
            lesPakket = lesPakket2,
            leraar = rijLeraar,
            theorieTest = theorieTest2,
            rijTest = rijTest2,
        };

        Dag dag1 = new Dag()
        {
            datum = new DateTime(2025, 12, 5),
            lesUren = new LesUur[]
            {
                new LesUur() {tijd = 60, student = student1, rijLeraar = rijLeraar, auto = auto1},
                new LesUur() {tijd = 60, student = student2, rijLeraar = rijLeraar, auto = auto2}
            }
        };
    }
}