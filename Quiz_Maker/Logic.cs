namespace Quiz_Maker;

public class Logic
{
    public static bool ValidateGameEntry(int entry)
    {
        return (entry == 0 || entry>Constants.GAME_MODE_OPTIONS);
    }
    
    public static Dictionary<int, string> CreateQuestion(int questionIndex, string questionInput)
    {
        Dictionary<int, string> question = new Dictionary<int, string>();
        question.Add(questionIndex, questionInput);
        return question;
        
    }

    public static Dictionary<int, List<string>> CreateAnswers(int answerIndex)
    {
        Dictionary<int, List<string>> answers = new Dictionary<int, List<string>>();
        List<string> answersList = new List<string>();
        
        while (answersList.Count <= Constants.MINIMUM_ANSWERS_COUNT)
        {
            string answerInput = Console.ReadLine();
            answersList.Add(answerInput);
        }
        answers.Add(answerIndex, answersList);

        return answers;

    }
    
    
    //Requires cleanup and new logic 
    public static string CreateCorrectAnswers(int answerIndex, List<string> answersList)
    {
        List<string> correctAnswersList = new List<string>();
        string answerInput = Console.ReadLine();
        return answerInput;
        
    }

    /*
    //requires clean up
    public static void CreateQuizMode()
    {
        //one big ++ for loop as the index for dictionaries (questions and answers) 
        bool nextQuestion = true;
        int indexCounter = 0;
        
        Dictionary<int, string> question = new Dictionary<int, string>();
        Dictionary<int, string> questions = new Dictionary<int, string>();
        
        Dictionary<int, List<string>> answer = new Dictionary<int, List<string>>();
        Dictionary<int, List<string>> answers = new Dictionary<int, List<string>>();
        
        Dictionary<int, List<string>> correctAnswer = new Dictionary<int, List<string>>();
        Dictionary<int, List<string>> correctAnswers = new Dictionary<int, List<string>>();

        while (nextQuestion)
        {
            //question =CreateQuestion(indexCounter, questionInput);
            questions.Add(indexCounter, question[indexCounter]);
            
            answer = CreateAnswers(indexCounter);
            answers.Add(indexCounter, answer[indexCounter]);

            correctAnswer = CreateCorrectAnswers(indexCounter, answer[indexCounter]);
            correctAnswers.Add(indexCounter, correctAnswer[indexCounter]);
            
            Console.WriteLine(question);
            Console.WriteLine(answer);
            Console.WriteLine(correctAnswer);
            
            
            Console.WriteLine(questions);
            Console.WriteLine(answers);
            Console.WriteLine(correctAnswers);
            
            indexCounter++;
            //ask if maker would like to create new question with next question

            nextQuestion = false;
        }
        
    }
    */
    
    public static void PlayQuizMode(int gameMode)
    {
        
        
        
    }
    
    
    //Create method that takes game mode selected 
    //Create multiple methods for 1 quiz mode, 2 play mode
}