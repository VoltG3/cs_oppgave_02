namespace cs_oppgave_02;

class UserInput
{
    public static void NumberInput()
    {
        //string input = Console.ReadLine();
        string defInput = "1234567890";

        if (int.TryParse(defInput, out int number))
        {
            Console.WriteLine($"Your number is {number}");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}