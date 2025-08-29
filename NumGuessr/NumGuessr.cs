namespace NumGuessr;

public class NumGuessr
{
    public void Guess()
    {
        int guess;
        var random = new Random();
        var num = random.Next(0,101);
        bool isInt = false;
        do
        {
            Console.WriteLine("Guess a number between 1-100: ");
            do
            {
                bool isInt = int.TryParse(Console.ReadLine(), out guess);
            } while (isInt);
        } while (guess != num);
    }
}