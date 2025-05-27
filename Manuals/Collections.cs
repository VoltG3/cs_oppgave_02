namespace cs_oppgave_02;

class Collections
{
    public static void ienumerable()
    {
        List<int> numbersList0 = [];
        List<int> numbersList1 = [ 8, 4, 2];
        List<int> numbersList2 = [ 1, 10 ];
        List<int> numbersList3 = [ 9, 3];

        var finalList = numbersList0 
            .Concat(numbersList1)
            .Concat(numbersList2)
            .Concat(numbersList3)
            .OrderBy(num => num)
            .ToList(); // ?
        
        var actualFinalList = finalList.ToList();
        
        foreach (var item in actualFinalList)
        {
            Console.WriteLine($"sortedNumberList[{item}] " + $"{ item }");
        }
    }
    
    public static void namesDictionary()
    { 
        
        //var namesDictionary = new Dictionary<string, string>();
        Dictionary<string, string> namesDictionary = new()
        {
            {"hdd","hard disk driver"}
        };
        namesDictionary.Add("ssd", "solid state disk driver");
        
        Console.WriteLine($"namesDictionary.length " + $"{ namesDictionary.Count }");
        foreach (var item in namesDictionary)
        {
            Console.WriteLine($"namesDictionary[{item.Key}] " + $"{ item.Value }");
        }
    }
    
    public static void NumberList()
    {
        List<int> numberList = [];
        numberList.Add(00);
        numberList.Add(11);
        numberList.Add(22);
        
        Console.WriteLine($"numberList.length " + $"{ numberList.Count }");
        for (int i = 0; i < numberList.Count; i++)
        {
            Console.WriteLine($"numberList[{i}] " + $"{ numberList[i] }");
        }
    }
    
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

