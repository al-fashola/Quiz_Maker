namespace Quiz_Maker;

class Program
{
    static void Main(string[] args)
    {
        int GameModeSelection; 
        GameModeSelection = UI.DisplayWelcomeMessage();
        
        Console.WriteLine($"\nGame mode selected {GameModeSelection}");
        
    }
}