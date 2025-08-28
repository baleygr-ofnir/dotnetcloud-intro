namespace Fundamentals;

internal class Program
{
    static string[] _messages =
    [
        "In this lesson we will start slowly.",
        "    1. Create variables and print them",
        "    2. Combine variables into sentences.",
        "    3. Make decisions with if-else"
    ];
    static Person _person  = new Person(firstName: "Baleygr", lastName: "Fjoelsviethr", age: 20000, hobby: "the pursuit for domination of every realm");
    
    static void Main(string[] args)
    {
        foreach (var message in _messages)
        {
            Console.WriteLine(message);
        }

        Console.WriteLine($"{_person.FirstName} {_person.LastName} is {_person.Age} years old and enjoys {_person.Hobby} as a pastime");
    }
}