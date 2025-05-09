﻿namespace Quiz_Maker;

class Program
{
    static void Main(string[] args)
    {
        UI.DisplayWelcomeMessage();
        int gameModeSelection = UI.ValidateGameModeSelection();
        
        Console.WriteLine($"\nGame mode selected {gameModeSelection}");
        int indexCounter = 0;
        bool nextQuestion = true;

        if (gameModeSelection == Constants.CREATE_QUIZ_MODE)
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

                    //This needs fixing and the logic above for try catch like solution
                    if (continueGame != 'N' || continueGame != 'Y')
                        UI.DisplayNextQuestionErrorMessage();
                }
                // look into issue further here
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