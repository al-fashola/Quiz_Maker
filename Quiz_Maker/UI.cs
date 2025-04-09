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
}