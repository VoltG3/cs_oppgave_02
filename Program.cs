namespace cs_oppgave_02;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Manuals
        // ----------------------------
        //UserInput.NumberInput();
        //TextFormat.StringFormat();
        //TextFormat.DateFormat();
        //TextFormat.NumberFormat();
        //Collections.TextString();
        //Collections.IEnumerable();
        //Collections.NamesDictionary();
        //Collections.NumberList();
        //Collections.NumberArray();

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Clear();
        TextFormat.Space(1);

        Console.WriteLine($"{ TextFormat.Border() } System Date");
        Console.WriteLine($"{ TextFormat.Border() } Random Data");
        Console.WriteLine($"{ TextFormat.Border() } User Date");
        TextFormat.Space(1);
        
        // System Date
        
        DateTime tmp01 = DateTime.Now;
        string t = tmp01.ToString("dd-MM-yyyy HH:mm:ss");
        Console.WriteLine($"System Date {t}");
        
        //int hours = tmp01.Hour; 
        //int minutes = tmp01.Minute;
        string formattedHour = tmp01.ToString("HH");
        string formattedMinute = tmp01.ToString("mm");
        
        Console.WriteLine($"H {formattedHour} M {formattedMinute}");
        TextFormat.Space(1);
        
        Console.WriteLine($"{ TextFormat.Border() } Custom HH:mm");
        //Console.Write($"{ TextFormat.Border() } Input HH -> ");
        //string customHour = Console.ReadLine();
        string customHour = "23";
        
        //Console.Write($"{ TextFormat.Border() } Input mm -> ");
        //string customMinute = Console.ReadLine();
        string customMinute = "61";

        if (Check.IsNumber(customHour) && Check.IsHour(customHour))
        {
            Console.WriteLine($"true Hours {customHour}");
        }
        
        //Console.WriteLine($"date{tmp01:T}");
        //Console.WriteLine($"Length { tmp01.ToString().Length }");
    }
}