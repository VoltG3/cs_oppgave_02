namespace cs_oppgave_02;

public class Validation
{
    public static bool Values(
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
            ErrorMessages.Error(ErrorMessages.ErrorType.IsNum, targetDay);
            return false;
        }
    
        if (!int.TryParse(targetMonth, out int monthValue))
        {
            ErrorMessages.Error(ErrorMessages.ErrorType.IsNum, targetMonth);
            return false;
        }

        if (!int.TryParse(targetYear, out int yearValue))
        {
            ErrorMessages.Error(ErrorMessages.ErrorType.IsNum, targetYear);
            return false;
        }
        
        if (!int.TryParse(targetHour, out int hourValue))
        {
            ErrorMessages.Error(ErrorMessages.ErrorType.IsNum, targetHour);
            return false;
        }
        
        if (!int.TryParse(targetMinute, out int minuteValue))
        {
            ErrorMessages.Error(ErrorMessages.ErrorType.IsNum, targetMinute);
            return false;
        }
        
        // ##################
        //  Is var in range?
        // ##################

        if (dayValue > 31 || dayValue < 1)
        {
            ErrorMessages.Error(ErrorMessages.ErrorType.Day, targetDay);
            isValid = false;    
        }
        
        if (monthValue > 12 || monthValue < 1)
        {
            ErrorMessages.Error(ErrorMessages.ErrorType.Month, targetMonth);
            isValid = false;
        }

        if (yearValue > 2025 || yearValue < 0)
        {
            ErrorMessages.Error(ErrorMessages.ErrorType.Year, targetYear);
            isValid = false;   
        }
        
        if (hourValue > 24 || hourValue < 0)
        {
            ErrorMessages.Error(ErrorMessages.ErrorType.Hour, targetHour);
            isValid = false;
        }
        
        if (minuteValue > 59 || minuteValue < 0)
        {
            ErrorMessages.Error(ErrorMessages.ErrorType.Minute, targetMinute);
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