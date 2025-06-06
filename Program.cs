﻿namespace cs_oppgave_02;
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
        
        string[] options = { "System Date", "Random Date", "User Input", "PreDefined", "Exit" };
        int selectedIndex = 0;
        bool exitSelected = false;

        while (!exitSelected)
        {
            Console.Clear();
            TextFormat.Space(1);
            Console.WriteLine($"{ TextFormat.Border(4) }{ TextColor.Color.YL_B }Menu{ TextColor.Color.RS }");
            Console.WriteLine($"{ TextFormat.Border(4) }{ TextColor.Color.YL_B }{ TextFormat.HorizontalLine(11) }{ TextColor.Color.RS }");
            for (int i = 0; i < options.Length; i++)
            {
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{ TextFormat.Border(2) }> {options[i]}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"{ TextFormat.Border(2) }  {options[i]}");
                }
            }
            Console.WriteLine($"{ TextFormat.Border(4) }{ TextColor.Color.YL_B }{ TextFormat.HorizontalLine(11) }{ TextColor.Color.RS }");
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.UpArrow)
            {
                selectedIndex = (selectedIndex - 1 + options.Length) % options.Length;
            }
            
            else if (key.Key == ConsoleKey.DownArrow)
            {
                selectedIndex = (selectedIndex + 1) % options.Length;
            }
            
            else if (key.Key == ConsoleKey.Enter)
            {
                //Console.WriteLine($"{options[selectedIndex]}");
                switch (options[selectedIndex])
                {
                    case "System Date":
                        string systemDay = DateTime.Now.Day.ToString();
                        string systemMonth = DateTime.Now.Month.ToString();
                        string systemYear = DateTime.Now.Year.ToString();
                        string systemHour = DateTime.Now.Hour.ToString();
                        string systemMinute = DateTime.Now.Minute.ToString();

                        if (Validation.Values(systemDay, systemMonth, systemYear, systemHour, systemMinute))
                        {
                            TextFormat.Space(1);
                            TextPrinter.Print(systemDay, systemMonth, systemYear, systemHour, systemMinute);
                        }
                        break;

                    case "Random Date":
                        string randomDay = RandomGenerator.RND(1, 31);
                        string randomMonth = RandomGenerator.RND(1, 13);
                        string randomYear = RandomGenerator.RND(0000, 2025);
                        string randomHour = RandomGenerator.RND(0, 25);
                        string randomMinute = RandomGenerator.RND(0, 60);  

                        if (Validation.Values(randomDay, randomMonth, randomYear, randomHour, randomMinute))
                        {
                            TextFormat.Space(1);
                            TextPrinter.Print(randomDay, randomMonth, randomYear, randomHour, randomMinute);
                        }
                        break;

                    case "User Input":
                        TextFormat.Space(1);
                        
                        Console.Write($"{ TextFormat.Border(3) }{ TextColor.Color.BL_B } Input Day -> { TextColor.Color.RS }");
                        Console.Write($"{TextColor.Color.YL_B }");
                            string customDay = Console.ReadLine();
                        Console.Write($"{ TextColor.Color.RS }");
                        
                        Console.Write($"{ TextFormat.Border(3) }{ TextColor.Color.BL_B } Input Month -> { TextColor.Color.RS }");
                        Console.Write($"{TextColor.Color.YL_B }");
                            string customMonth = Console.ReadLine();
                        Console.Write($"{ TextColor.Color.RS }");
                        
                        Console.Write($"{ TextFormat.Border(3) }{ TextColor.Color.BL_B } Input Year -> { TextColor.Color.RS }");
                        Console.Write($"{TextColor.Color.YL_B }");
                            string customYear = Console.ReadLine();
                        Console.Write($"{ TextColor.Color.RS }");
                        
                        Console.Write($"{ TextFormat.Border(3) }{ TextColor.Color.BL_B } Input Hour -> { TextColor.Color.RS }");
                        Console.Write($"{ TextColor.Color.YL_B }");
                            string customHour = Console.ReadLine();
                        Console.Write($"{ TextColor.Color.RS }");
                        
                        Console.Write($"{ TextFormat.Border(3) }{ TextColor.Color.BL_B } Input Minute -> { TextColor.Color.RS }");
                        Console.Write($"{ TextColor.Color.YL_B }");
                            string customMinute = Console.ReadLine();
                        Console.Write($"{ TextColor.Color.RS }");
                        
                        if (Validation.Values(customDay, customMonth, customYear, customHour, customMinute))
                        {
                            TextFormat.Space(1);
                            TextPrinter.Print(customDay, customMonth, customYear, customHour, customMinute);
                        }
                        break;

                    case "PreDefined":
                        string definedDay = "9";
                        string definedMonth = "11";
                        string definedYear = "1923";
                        string definedHour = "17";
                        string definedMinute = "43";

                        if (Validation.Values(definedDay, definedMonth, definedYear, definedHour, definedMinute))
                        {
                            TextFormat.Space(1);
                            TextPrinter.Print(definedDay, definedMonth, definedYear, definedHour, definedMinute);
                        }
                        break;

                    case "Exit":
                        Console.WriteLine("Exit");
                        exitSelected = true;
                        break;
                }

                if (!exitSelected)
                {
                    TextFormat.Space(1);
                    Console.WriteLine($"{ TextFormat.Border(4) }{ TextColor.Color.GR_B }Press any key to return to menu{ TextColor.Color.RS }");
                    Console.ReadKey(true);
                }
            }
        }
        
        Console.Clear();
    }
}