namespace cs_oppgave_02;

public class Repository
{
    public static string Season(int targetSeason)
    {
        Dictionary<string, string> season = new()
        {
            {"WW", "Winter"},
            {"SP", "Spring"},
            {"SU", "Summer"},
            {"AU", "Autumn"},
            {"UN", "Unknown season"}
        };
        
        string seasonString = "";

        if (targetSeason == 12 || targetSeason == 1 || targetSeason == 2)
        {
            seasonString = "WW";
        }
        else if (targetSeason >= 3 && targetSeason <= 5)
        {
            seasonString = "SP";
        }
        else if (targetSeason >= 6 && targetSeason <= 8)
        {
            seasonString = "SU";
        }
        else if (targetSeason >= 9 && targetSeason <= 10)
        {
            seasonString = "AU";
        }
        else
        {
            seasonString = "UN";
        }
        
        return season[seasonString];
    }
    
    public static string DayTime(int targetHour)
    {
        Dictionary<string, string> dayTime = new()
        {
            {"A","Good Afternoon!"},
            {"E","Good Evening!"},
            {"M","Good Morning!"},
            {"N","Good Night!"},
            {"U", "Unknown day time"}
        };
     
        string dayTimeString = "";
        
        if (targetHour >= 12 && targetHour <= 17)
        {
            dayTimeString="A";
        } 
        else if (targetHour >= 17 && targetHour <= 23)
        {
            dayTimeString="E";
        }
        else if (targetHour >= 7 && targetHour <= 11)
        {
            dayTimeString="M";
        }
        else if (targetHour >= 23 && targetHour <= 6)
        {
            dayTimeString="N";
        }
        else
        {
            dayTimeString="U";
        }

        return dayTime[dayTimeString];
    }
}