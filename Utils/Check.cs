namespace cs_oppgave_02;

public class Check
{
    public static bool Validation(
        string targetDay,
        string targetMonth, 
        string targetYear,
        string targetHour, 
        string targetMinute)
    {
        bool isValid;
        
        // ###############
        //  Is it number?
        // ###############
        if (!int.TryParse(targetDay, out int dayValue))
        {
            Messanger.Error(Messanger.ErrorType.IsNum, targetDay);
            return false;
        }
    
        if (!int.TryParse(targetMonth, out int monthValue))
        {
            Messanger.Error(Messanger.ErrorType.IsNum, targetMonth);
            return false;
        }

        if (!int.TryParse(targetYear, out int yearValue))
        {
            Messanger.Error(Messanger.ErrorType.IsNum, targetYear);
            return false;
        }
        
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
        
        // ##################
        //  Is var in range?
        // ##################

        if (dayValue > 31 || dayValue < 1)
        {
            Messanger.Error(Messanger.ErrorType.Day, targetDay);
            isValid = false;    
        }
        
        if (monthValue > 12 || monthValue < 1)
        {
            Messanger.Error(Messanger.ErrorType.Month, targetMonth);
            isValid = false;
        }

        if (yearValue > 2025 || yearValue < 0)
        {
            Messanger.Error(Messanger.ErrorType.Year, targetYear);
            isValid = false;   
        }
        
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
        
        else
        {
            // For Debbuging purpose
            
            /*
            Console.Write($"{ TextFormat.Border(8) }" +
                          $"{ TextColor.Color.CY_B }");
            Console.Write($" dd { targetDay }");
            Console.Write($" MM { targetMonth }");
            Console.Write($" yy { targetYear }");
            Console.Write($" HH { targetHour }");
            Console.Write($" mm { targetMinute }" +
                          $"{ TextColor.Color.RS }");
            */
            
            isValid = true;
        }
        
        return isValid;
    }
}