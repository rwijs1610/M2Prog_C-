namespace _03_constructors;
class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden; 
    internal Quiz(int aantalVragen)
    {
        vragen = new QuizVraag[aantalVragen];
        ingevuldeAntwoorden = new QuizVraagAntwoord[aantalVragen];
    }

    internal void VoegVraagToeOpIndex(int index, QuizVraag vraag )
    {   
        vragen[index] = vraag;
    }
    internal void VoegVraagToeOpIndex(int index, string vraag,string antwoord)
    {   
        QuizVraag quizVraag = new QuizVraag(vraag,antwoord);
        vragen[index] = quizVraag;
    }
    internal void StelVraag(int index)
    {
        QuizVraag vraag = vragen[index];
        QuizVraagAntwoord antwoord = new QuizVraagAntwoord(vraag);
        ingevuldeAntwoorden[index] = antwoord;
        Console.WriteLine(vraag.vraag); 
    
        string antwoord1 = Console.ReadLine();
        if (antwoord1 == vraag.antwoord)
        {
            antwoord.goed = true;
            Console.WriteLine("Correct!");

        }else 
        {
            antwoord.goed = false;
            Console.WriteLine("Incorrect!");
        }
    }
    internal int score()
    {   
        int score = 0;
        for (int i = 0; i < ingevuldeAntwoorden.Length; i++)
        {
            if (ingevuldeAntwoorden[i].goed)
            {
                score++;
            }
        }
        return score;
    }
}