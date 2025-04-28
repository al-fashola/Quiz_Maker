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
                //Create question and add to questions dictionary
                UI.DisplayQuestionMessage();
                string QuestionInput = Console.ReadLine();
                Dictionary<int, string> question = Logic.CreateQuestion(indexCounter, QuestionInput);

                //Create answers and add to answers dictionary
                UI.DisplayAnswersMessage();
                Dictionary<int, List<string>> answers = Logic.CreateAnswers(indexCounter);
                
                //initialize list of possible answers
                List<string> answersList = new List<string>();
                answersList = answers[indexCounter];
                
                //Create correct answers and add to correct answers dictionary
                List<string> correctAnswersList = new List<string>();
                Dictionary<int, List<string>> correctAnswers = new Dictionary<int, List<string>>();
                
                while (correctAnswersList.Count < Constants.MINIMUM_CORRECT_ANSWERS_COUNT)
                {
                    UI.DisplayCorrectAnswersMessage();
                    string correctAnswer = Logic.CreateCorrectAnswers(indexCounter, answersList);
                    
                    if (answersList.Contains(correctAnswer))
                        correctAnswersList.Add(correctAnswer);
                    else
                    {
                        UI.DisplayAnswersErrorMessage(answersList);
                    }
                        //bool and string
                        
                }
                correctAnswers.Add(indexCounter, correctAnswersList);

                char continueGame = 'N';
                
                while (continueGame != 'N' || continueGame != 'Y')
                {
                    UI.DisplayNextQuestionMessage();
                    continueGame = Console.ReadKey().KeyChar;
                    continueGame = char.ToUpper(continueGame);

                    if (continueGame != 'N' || continueGame != 'Y')
                        UI.DisplayNextQuestionErrorMessage();
                }
                
                if(continueGame=='Y' || continueGame == 'y')
                    nextQuestion = true;
                else
                {
                    nextQuestion = false;
                }
                
                indexCounter++; 
            }
        }


        //Logic.CreateQuizMode();


    }
}