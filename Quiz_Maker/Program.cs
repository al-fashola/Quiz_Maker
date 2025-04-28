namespace Quiz_Maker;

class Program
{
    static void Main(string[] args)
    {
        UI.DisplayWelcomeMessage();
        int GameModeSelection = UI.ValidateGameModeSelection();
        
        Console.WriteLine($"\nGame mode selected {GameModeSelection}");
        int indexCounter = 0;
        bool nextQuestion = true;

        if (GameModeSelection == 1)
        {
            while (nextQuestion)
            {
                UI.DisplayQuestionMessage();
                string QuestionInput = Console.ReadLine();
                Dictionary<int, string> question = Logic.CreateQuestion(indexCounter, QuestionInput);

                UI.DisplayAnswersMessage();
                Dictionary<int, List<string>> answers = Logic.CreateAnswers(indexCounter);
                
                List<string> correctAnswersList = new List<string>();

                correctAnswersList = answers[indexCounter];
                
                Dictionary<int, List<string>> correctAnswers = Logic.CreateCorrectAnswers(indexCounter, correctAnswersList);
            }

            
            indexCounter++;

        }


        Logic.CreateQuizMode();


    }
}