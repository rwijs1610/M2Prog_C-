namespace _03_constructors;

class Program
{
       static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    internal void Run()
    {
        Quiz quiz = new Quiz(10);
        QuizVraag quizVraag = new QuizVraag("wat is 2+2?", "4");
        quiz.VoegVraagToeOpIndex(0, quizVraag);
        quiz.VoegVraagToeOpIndex(1, "is codie kaal?", "ja");
        quiz.VoegVraagToeOpIndex(2, "kan nathan zien?", "nee");
        quiz.VoegVraagToeOpIndex(3, "is de zon wit?", "ja");
        quiz.VoegVraagToeOpIndex(4, "is gras groen?", "ja");
        quiz.VoegVraagToeOpIndex(5, "welke klaar haar heeft kyano?", "rood");
        quiz.VoegVraagToeOpIndex(6, "is Ian nonig?", "nee");
        quiz.VoegVraagToeOpIndex(7, "is water nat?", "ja");
        quiz.VoegVraagToeOpIndex(8, "hoeveel poten heeft een hond?", "4");
        quiz.VoegVraagToeOpIndex(9, "wat is de hoofdstad van Frankrijk?", "Parijs");

        for (int i = 0; i < 10; i++)
        {
            quiz.StelVraag(i);
        }   

        int finalscore = quiz.score();
        Console.WriteLine(finalscore);
    }
}
