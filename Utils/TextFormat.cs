namespace  cs_oppgave_02;

public class TextFormat
{
    public static string HorizontalLine(int count)
    {
        string line = "";
        for (int i = 0; i < count; i++)
        {
            line += "-";
        }
        return line;
    }
    
    public static string Border(int count)
    {
        var line = "";
        for (int i = 0; i < count; i++)
        {
            line += $"{ (char)160 }";
        }
        return line;
    }
    
    public static void Space(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write("\n");
        }
    }
}