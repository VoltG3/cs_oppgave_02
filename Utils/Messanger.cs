namespace cs_oppgave_02;

public class Messanger
{
    public enum ErrorType
    {
        IsNum,
        Day,
        Month,
        Year,
        Hour,
        Minute,
    }
    
    public static void Error(ErrorType errorType, string falseValue)
    {
        string message = errorType switch
        {
            ErrorType.IsNum => $"Invalid var - not a number :: { falseValue }",
            ErrorType.Day => $"Invalid var - day out of range :: { falseValue }",
            ErrorType.Month => $"Invalid var - month out of range :: { falseValue }",
            ErrorType.Year => $"Invalid var - year out of range :: { falseValue }",
            ErrorType.Hour => $"Invalid var - hours out of range :: { falseValue }",
            ErrorType.Minute => $"Invalid var - minutes out of range :: { falseValue }",
            _ => "Unknown error"
        };
        
        Console.WriteLine($"" +
                          $"{ TextFormat.Border(4) }" +
                          $"{ TextColor.Color.RD_B }" +
                          $"{ message }" +
                          $"{ TextColor.Color.RS }" +
                          $"");
    }
}