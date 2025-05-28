namespace cs_oppgave_02;

public class Check
{
    public static bool IsMonth(string targetMonth)
    {
        bool isMonth;
        if (int.Parse(targetMonth) > 12 || int.Parse(targetMonth) < 1)
        {
            Console.WriteLine($"" +
                              $"{ TextFormat.Border(4) }" +
                              $"{ TextColor.Color.RD_B }" +
                              $"Invalid input - month out of range :: { targetMonth }" +
                              $"{ TextColor.Color.RS }" +
                              $"");
            isMonth = false;
        }
        else
        {
            isMonth = true;
        }
        
        return isMonth;
    }
    
    public static bool IsMinute(string targetMinute)
    {
        bool isMinute;
        if (int.Parse(targetMinute) > 59 || int.Parse(targetMinute) < 0)
        {
            Console.WriteLine($"" +
                              $"{ TextFormat.Border(4) }" +
                              $"{ TextColor.Color.RD_B }" +
                              $"Invalid input - minutes out of range :: { targetMinute }" +
                              $"{ TextColor.Color.RS }" +
                              $"");
            isMinute = false;
        }
        else
        {
            isMinute = true;
        }
        return isMinute;
    }
    
    public static bool IsHour(string targetHour)
    {
        bool isHour;
        if (int.Parse(targetHour) > 24 || int.Parse(targetHour) < 0)
        {
            Console.WriteLine($"" +
                              $"{ TextFormat.Border(4) }" +
                              $"{ TextColor.Color.RD_B }" +
                              $"Invalid input - hours out of range :: { targetHour }" +
                              $"{ TextColor.Color.RS }" +
                              $"");
            isHour = false;
        }
        else
        {
            isHour = true;
        }
            
        return isHour;
    }
    
    public static bool IsNumber(string targetNum)
    {
        bool isNumber;
        if (int.TryParse(targetNum, out int number))
        {
            isNumber = true;
        }
        else
        {
            Console.WriteLine($"" +
                              $"{ TextFormat.Border(4) }" +
                              $"{ TextColor.Color.RD_B }" +
                              $"Invalid input - not a number :: { targetNum }" +
                              $"{ TextColor.Color.RS }" +
                              $"");
            isNumber = false;
        }
        return isNumber;
    }
}