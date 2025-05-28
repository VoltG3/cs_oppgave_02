namespace cs_oppgave_02;

public class Check
{
    public static bool Validation(
        string targetHour, 
        string targetMinute, 
        string targetMonth)
    {
        bool isValid;
        
        // ###############
        //  Is it number?
        // ###############
        if (!int.TryParse(targetHour, out int hourValue))
        {
            Messanger.Error(Messanger.ErrorType.IsNum, targetHour);
            return false;
        }
        
        if (!int.TryParse(targetMinute, out int minuteValue))
        {
            Messanger.Error(Messanger.ErrorType.IsNum, targetMinute);
            return false;
        }

        if (!int.TryParse(targetMonth, out int monthValue))
        {
            Messanger.Error(Messanger.ErrorType.IsNum, targetMonth);
            return false;
        }
        
        // ##################
        //  Is var in range?
        // ##################
        if (hourValue > 24 || hourValue < 0)
        {
            Messanger.Error(Messanger.ErrorType.Hour, targetHour);
            isValid = false;
        }
        
        if (minuteValue > 59 || minuteValue < 0)
        {
            Messanger.Error(Messanger.ErrorType.Minute, targetMinute);
            isValid = false;
        }
        
        if (monthValue > 12 || monthValue < 1)
        {
            Messanger.Error(Messanger.ErrorType.Month, targetMonth);
            isValid = false;
        }
        
        else
        {
            Console.Write($"{ TextFormat.Border(8) }" +
                          $"{ TextColor.Color.CY_B }");
            Console.Write($" HH { targetHour }");
            Console.Write($" mm { targetMinute }");
            Console.Write($" MM { targetMonth } " +
                          $"{ TextColor.Color.RS }" +
                          $"\n");
            isValid = true;
        }
        
      /*  
        if (IsNumber(targetHour) && IsHour(targetHour) && 
            IsNumber(targetMinute) && IsMinute(targetMinute) && 
            IsNumber(targetMonth) && IsMonth(targetMonth))
        {
            Console.Write($"{ TextFormat.Border(8) }" +
                          $"{ TextColor.Color.CY_B }");
            Console.Write($" HH { targetHour }");
            Console.Write($" mm { targetMinute }");
            Console.Write($" MM { targetMonth } " +
                          $"{ TextColor.Color.RS }" +
                          $"\n");
            isValid = true;
        }
        else
        {
            isValid = false;
        }
       */ 
        return isValid;
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