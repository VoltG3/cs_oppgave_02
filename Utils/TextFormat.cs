namespace  cs_oppgave_02;

public class TextFormat
{
    //
    
    public static string Border()
    {
        var padding = $"{ (char)160 }{ (char)160 }{ (char)160 }";
        return padding;
    }
    
    public static void Space(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write("\n");
        }
    }
}