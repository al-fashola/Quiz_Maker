namespace Quiz_Maker;

class Program
{
    static void Main(string[] args)
    {
        UI.DisplayWelcomeMessage();
        int GameModeSelection = UI.ValidateGameModeSelection();
        
        Console.WriteLine($"\nGame mode selected {GameModeSelection}");

        Logic.CreateQuizMode();


    }
}