namespace  cs_oppgave_02;

public class TextPrinter
{
    public static void Print(string targetDay, string targetMonth, string targetYear, string targetHour, string targetMinute)
    {
        DateTime assemblyDate = new DateTime(
            int.Parse(targetYear), 
            int.Parse(targetMonth), 
            int.Parse(targetDay), 
            int.Parse(targetHour), 
            int.Parse(targetMinute), 
            0);

        string europeanFormat = assemblyDate.ToString("dd.MM.yyyy HH:mm");
            
        Console.WriteLine($"{ TextFormat.Border(3) }" +
                          $"{ (char)160 }{ TextColor.Color.BL_B }{ Repository.GetChronophase(int.Parse(targetHour))}{ TextColor.Color.BL_B }");
            
        Console.WriteLine($"{ TextFormat.Border(4) }{ TextColor.Color.BL_B }{ europeanFormat }{ TextColor.Color.BL_B }");
            
        TextFormat.Space(1);
            
        Console.WriteLine($"{ TextFormat.Border(3) }" +
                          $"{ (char)160 }{ Repository.GetSeason(int.Parse(targetMonth))}" +
                          $"{ (char)160 }{ Repository.GetPeriod(int.Parse(targetYear))}" +
                          $"{ (char)160 }{ TextColor.Color.GR_B }in Europe{ TextColor.Color.YL_B }");
            
        Console.WriteLine($"{ TextFormat.Border(4) }" +
                          $"{ TextColor.Color.YL_B }Topics to explore:{ (char)160 }{ TextColor.Color.RS }" +
                          $"{ Repository.GetAction( int.Parse(targetYear) )}");
        
        Console.WriteLine($"{ TextFormat.Border(11) }" +
                          $"{ TextColor.Color.YL_B }{"Next event:"}{ TextColor.Color.YL_B }" +
                          $"{ (char)160 }{ Repository.GetNextSolarEvent(
                              int.Parse(targetDay), 
                              int.Parse(targetMonth), 
                              int.Parse(targetYear))
                          }");
    }
}