namespace PersonProfile;

class Program
{
    static void Main(string[] args)
    {
        var person = new Person();
        person.GetProfile();
        person.GetEval();
        Console.WriteLine($"\nThanks for using the program, {person.Name}! See you soon!");
    }
}