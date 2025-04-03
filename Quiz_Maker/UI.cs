namespace Quiz_Maker;

public class UI
{
    public static int DisplayWelcomeMessage()
    {
        int value = 0;
        Console.WriteLine("Welcome to Quiz Maker, Today you will have 2 choices to select");
        Console.WriteLine("1. Create a new Quiz");
        Console.WriteLine("2. Play Quiz");

        while (value == 0 || value>Constants.GAME_MODE_OPTIONS)
        {
            string entry = Console.ReadKey().KeyChar.ToString();
            //Console.Clear();
            value = ValidateIntEntry(entry);
            
            if (value == 0 || value>Constants.GAME_MODE_OPTIONS)
                Console.WriteLine("\nPlease enter a valid game option");
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
            Console.WriteLine("Please enter a valid Integer entry only");
            finalVal = 0;
        }

        return (finalVal);
    }
}