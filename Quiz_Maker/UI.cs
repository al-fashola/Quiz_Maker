namespace Quiz_Maker;

public class UI
{
    public static void DisplayWelcomeMessage()
    {
        Console.WriteLine($"Welcome to Quiz Maker, Today you will have {Constants.GAME_MODE_OPTIONS} choices to select");
        Console.WriteLine($"{Constants.CREATE_QUIZ_MODE} Create a new Quiz");
        Console.WriteLine($"{Constants.PLAY_QUIZ_MODE} Play Quiz");
    }

    public static int ValidateGameModeSelection()
    {
        int value = 0;
        
        while (Logic.ValidateGameEntry(value))
        {
            Console.WriteLine("Please enter your choice for Quiz Mode: ");
            string entry = Console.ReadKey().KeyChar.ToString();
            //Console.Clear();
            value = ValidateIntEntry(entry);
            
            if (Logic.ValidateGameEntry(value))
                Console.WriteLine("\n Please enter a valid game option");
        }
        
        return value;
    }

    public static int ValidateIntEntry(string entry)
    {
        int val;
        bool success = int.TryParse(entry, out val);
        int finalVal; 

        if (success)
        {
            finalVal = val;
        }
        else
        {
            Console.WriteLine("Please enter a valid Integer only");
            finalVal = 0;
        }

        return (finalVal);
    }

    public static void DisplayQuestionMessage()
    {
        Console.WriteLine("Please enter your Question now");
    }
    
    public static void DisplayAnswersMessage()
    {
        Console.WriteLine($"Please enter your possible Answers now (minimum {Constants.MINIMUM_ANSWERS_COUNT}) ");
    }
    
    public static void DisplayMinimumAnswersMessage()
    {
        Console.WriteLine($"Please enter at least {Constants.MINIMUM_CORRECT_ANSWERS_COUNT} Answers minimum");
    }
    
    public static void DisplayAnswersErrorMessage( List<string> answers)
    {
        Console.WriteLine($"Please enter only answers in the following list: {answers.ToString()} ");
    }
    
    public static void DisplayCorrectAnswersMessage()
    {
        Console.WriteLine($"Please enter your Correct Answers now (Minimum {Constants.MINIMUM_ANSWERS_COUNT}) ");
    }
    

}