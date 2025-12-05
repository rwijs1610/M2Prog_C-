namespace _03_constructors;
class QuizVraagAntwoord
{
    internal QuizVraag vraag;
    internal bool goed;
    internal QuizVraagAntwoord(QuizVraag vraag)
    {
        vraag = vraag;
        goed = false;
    }
}   