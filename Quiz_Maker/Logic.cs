namespace Quiz_Maker;

public class Logic
{
    public static bool ValidateGameEntry(int entry)
    {
        return (entry == 0 || entry>Constants.GAME_MODE_OPTIONS);
    }
}