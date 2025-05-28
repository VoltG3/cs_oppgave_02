namespace cs_oppgave_02;

public class Repository
{
    public static string DayTime(int targetHour)
    {
        Dictionary<string, string> dayTime = new()
        {
            {"A","Good Afternoon"},
            {"E","Good Evening"},
            {"M","Good Morning"},
            {"N","Good Night"},
            {"U", "Unknown DayTime"}
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