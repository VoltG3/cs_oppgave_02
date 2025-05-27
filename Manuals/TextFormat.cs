namespace cs_oppgave_02;


class TextFormat
{
    public static void StringFormat()
    {
        // first
        int tmp01 = 2025;
        string tmp02 = "Hello World!";
        string txt = string.Format("Hello World! {0}", tmp01);
        Console.WriteLine(txt);
        
        // second
        txt = "a";
        Console.WriteLine(txt.PadLeft(10, '-'));
        Console.WriteLine(txt.PadRight(10, '-'));
        
        txt = "ABCDFG";
        Console.WriteLine(txt.PadLeft(10, '-'));
        Console.WriteLine(txt.PadRight(10, '-'));
        
        // third
        string[] temporary = {"first", "second", "third"};
        foreach (var item in temporary)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(string.Join(", ", temporary));
        
        // forth
        string world1 = "           hello vorld1";
        Console.WriteLine(world1.Trim().ToUpper());
        
        string world2 = world1.Trim().ToLower();
        if (world2.Contains("vorld"))
        {
            string newWorld2 = world2.Replace("vorld", "world");
            Console.WriteLine(newWorld2);
        }
        
        // fifth
        string someText = "### someText";
        string del = someText.Substring(4, 8);
        Console.WriteLine(del);
        
    }
    public static void DateFormat()
    {
        DateTime tmp01 = DateTime.Now;
        DateTime tmp02 = DateTime.Now.AddDays(1);
        
        Console.WriteLine($"today {tmp01:d}");      // To Date
        Console.WriteLine($"tomorrow {tmp02:d}");   // To Date

        Console.WriteLine($"Short Dato : {tmp01:d}");
        Console.WriteLine($"Long  Dato : {tmp01:D}");
        Console.WriteLine($"Full  Dato : {tmp01:f}");
        Console.WriteLine($"Short Time : {tmp01:t}");
        Console.WriteLine($"Long  Time : {tmp01:T}");
        Console.WriteLine($"Custom     : {tmp01:dd-MM-yyyy HH:mm:ss}");
    }
    
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