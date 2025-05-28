namespace cs_oppgave_02;

public class Repository
{
    private static readonly Dictionary<string, string> Seasons = new()
    {
        { "wr", "The cold winds of winter blow through the age of" },
        { "sg", "The blossoms of spring awaken the spirit of" },
        { "sr", "The golden sun of summer shines over the enduring age of" },
        { "an", "The falling leaves of autumn whisper through the legacy of" },
        { "u", "Unknown season" }
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
    
    private static readonly Dictionary<string, string> Chronophase = new()
    {
        {"a", "Good Afternoon!"},
        {"e", "Good Evening!"},
        {"m", "Good Morning!"},
        {"n", "Good Night!"},
        {"u", "Unknown day time"}
    };
    
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

    private static readonly Dictionary<string, string> Period = new()
    {
        {"ca", "Classical Antiquity"},
        {"m", "Middle Ages"},
        {"va", "Viking Age"},
        {"r", "Renaissance"},
        {"em", "Early Modern Period"},
        {"ma", "Modern Era"},
        {"de", "Digital Era"}
    };

    public static string GetPeriod(int year)
    {
        string periodCode = year switch
        {
            >= 0000 and <= 499 => "ca",
            >= 500 and <= 792 => "m",
            >= 793 and <= 1099 => "va",
            >= 1067 and <= 1699 => "r",
            >= 1700 and <= 1899 => "em",
            >= 1900 and <= 1999 => "ma",
            >= 2000 and <= 2025 => "de",
            _ => "Unknown period"
        };
        
        return Period[periodCode];
    }

    private static readonly Dictionary<string, string> Action = new()
    {
        { "aca", "Explore Greek philosophy, Roman legions, and the rise of empires" },
        { "am", "Navigate feudal kingdoms, crusader paths, and church power" },
        { "ava", "Set sail on Norse raids, trade routes, and cultural encounters" },
        { "ar", "Discover artistic rebirth, scientific revolutions, and humanism" },
        { "aem", "Engage in industrial growth, global empires, and Enlightenment" },
        { "ama", "Witness world wars, technological booms, and the rise of nations" },
        { "ade", "Enter cyberspace, AI evolution, and the data-driven world" }
    };
    
    public static string GetAction(int year)
    {
        string actionCode = year switch
        {
            >= 0000 and <= 499 => "aca",
            >= 500 and <= 792 => "am",
            >= 793 and <= 1099 => "ava",
            >= 1067 and <= 1699 => "ar",
            >= 1700 and <= 1899 => "aem",
            >= 1900 and <= 1999 => "ama",
            >= 2000 and <= 2025 => "ade",
            _ => "Unknown period"
        };
        
        return Action[actionCode];
    }
}