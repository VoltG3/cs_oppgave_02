namespace cs_oppgave_02;

public class Repository
{
    private static readonly Dictionary<string, string> Seasons = new()
    {
        { "wr", $"{ TextColor.Color.GR_B }The cold winds of { TextColor.Color.YL_B }winter { TextColor.Color.GR_B }blow through the age of" },
        { "sg", $"{ TextColor.Color.GR_B }The blossoms of { TextColor.Color.YL_B }spring { TextColor.Color.GR_B }awaken the spirit of" },
        { "sr", $"{ TextColor.Color.GR_B }The golden sun of { TextColor.Color.YL_B }summer { TextColor.Color.GR_B }shines over the enduring age of" },
        { "an", $"{ TextColor.Color.GR_B }The falling leaves of { TextColor.Color.YL_B }autumn { TextColor.Color.GR_B }whisper through the legacy of" },
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
        {"ca", $"{ TextColor.Color.YL_B }Classical Antiquity{ TextColor.Color.RS }"},
        {"m", $"{ TextColor.Color.YL_B }Middle Ages{ TextColor.Color.RS }"},
        {"va", $"{ TextColor.Color.YL_B }Viking Age{ TextColor.Color.RS }"},
        {"r", $"{ TextColor.Color.YL_B }Renaissance{ TextColor.Color.RS }"},
        {"em", $"{ TextColor.Color.YL_B }Early Modern Period{ TextColor.Color.RS }"},
        {"ma", $"{ TextColor.Color.YL_B }Modern Era{ TextColor.Color.RS }"},
        {"de", $"{ TextColor.Color.YL_B }Digital Era{ TextColor.Color.RS }"}
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
        { "aca", $"{ TextColor.Color.PR_B }Explore Greek philosophy, Roman legions, and the rise of empires{ TextColor.Color.RS }" },
        { "am", $"{ TextColor.Color.PR_B }Navigate feudal kingdoms, crusader paths, and church power{ TextColor.Color.RS }" },
        { "ava", $"{ TextColor.Color.PR_B }Set sail on Norse raids, trade routes, and cultural encounters{ TextColor.Color.RS }" },
        { "ar", $"{ TextColor.Color.PR_B }Discover artistic rebirth, scientific revolutions, and humanism{ TextColor.Color.RS }" },
        { "aem", $"{ TextColor.Color.PR_B }Engage in industrial growth, global empires, and Enlightenment{ TextColor.Color.RS }" },
        { "ama", $"{ TextColor.Color.PR_B }Witness world wars, technological booms, and the rise of nations{ TextColor.Color.RS }" },
        { "ade", $"{ TextColor.Color.PR_B }Enter cyberspace, AI evolution, and the data-driven world{ TextColor.Color.RS }" }
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
    
    private static readonly Dictionary<string, (int Month, int Day)> SolarEvents = new()
    {
        { $"{ TextColor.Color.BL_B }Spring Equinox{ TextColor.Color.RS }", (3, 20) },
        { $"{ TextColor.Color.BL_B }Summer Solstice{ TextColor.Color.RS }", (6, 21) },
        { $"{ TextColor.Color.BL_B }Autumn Equinox{ TextColor.Color.RS }", (9, 23) },
        { $"{ TextColor.Color.BL_B }Winter Solstice{ TextColor.Color.RS }", (12, 21) }
    };
    
    public static string GetNextSolarEvent(int currentDay, int currentMonth, int currentYear)
    {
        DateTime now = new DateTime(currentYear, currentMonth, currentDay);

        var sortedEvents = SolarEvents
            .Select(e => new
            {
                Name = e.Key,
                Date = new DateTime(currentYear, e.Value.Month, e.Value.Day)
            })
            .OrderBy(e => e.Date)
            .ToList();

        foreach (var ev in sortedEvents)
        {
            if (ev.Date >= now)
                return ev.Name;
        }
        
        var nextYearEvent = SolarEvents
            .Select(e => new
            {
                Name = e.Key,
                Date = new DateTime(currentYear + 1, e.Value.Month, e.Value.Day)
            })
            .OrderBy(e => e.Date)
            .First();

        return nextYearEvent.Name;
    }
}