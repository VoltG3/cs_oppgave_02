namespace cs_oppgave_02;

public class RandomGenerator
{
    public static string RND(int min, int max)
    {
        int randomNumber = Random.Shared.Next(min, max);
        return randomNumber.ToString();
    }
}