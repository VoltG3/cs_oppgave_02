namespace cs_oppgave_02;

class Collections
{
    public static void NumberArray()
    {
        int[] numbersArray = new int[3];
        numbersArray[0] = 00;
        numbersArray[1] = 11;
        numbersArray[2] = 22;
        
        Console.WriteLine($"numberArray.length " + $"{ numbersArray.Length }");
        for (int i = 0; i < numbersArray.Length; i++)
        {
            Console.WriteLine($"numberArray[{i}] " + $"{ numbersArray[i] }");
        }
    }
}

