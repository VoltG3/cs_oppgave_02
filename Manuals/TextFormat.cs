namespace cs_oppgave_02;


class TextFormat
{
    public static void NumberFormat()
    {
        double tmp01 = 3.14159;
        double tmp02 = 0.12;
        double tmp03 = 9999999.99;
        
        Console.WriteLine($"pi {tmp01:F2}");       // To Fixed 2 decimal places 
        Console.WriteLine($"pi {tmp02:P2}");       // To Percentage 2 decimal places
        Console.WriteLine($"pi {tmp03:C}");        // To Currency       
    }
}