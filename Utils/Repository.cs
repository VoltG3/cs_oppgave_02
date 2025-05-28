namespace cs_oppgave_02;

public class Repository
{
    private static readonly Dictionary<string, string> Seasons = new()
    {
        { "wr", "Winter" },
        { "sg", "Spring" },
        { "sr", "Summer" },
        { "an", "Autumn" },
        { "u", "Unknown season" }
    };
    
    private static readonly Dictionary<string, string> Chronophase = new()
    {
        {"a", "Afternoon!"},
        {"e", "Evening!"},
        {"m", "Morning!"},
        {"n", "Night!"},
        {"u", "Unknown day time"}
    };

    public static string GetSeason(int month)
    {
        string seasonCode = month switch
        {
            12 or 1 or 2 => "wr",
            3 or 4 or 5 => "sg",
            6 or 7 or 8 => "sr",
            9 or 10 or 11 => "an",
            _ => "u"
        };
        
        return Seasons[seasonCode];
    }
    
    public static string GetChronophase(int hour)
    {
        string chronophaseCode = hour switch
        {
            >= 7 and <= 11 => "m",
            >= 12 and <= 17 => "a",
            >= 18 and <= 22 => "e",
            >= 23 or <= 6 => "n"
        };

        return Chronophase[chronophaseCode];
    }
}