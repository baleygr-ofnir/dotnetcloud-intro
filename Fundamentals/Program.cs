namespace Fundamentals;

internal class Program
{
    /*
    static string[] _messages =
    [
        "In this lesson we will start slowly.",
        "    1. Create variables and print them",
        "    2. Combine variables into sentences.",
        "    3. Make decisions with if-else"
    ];
    static Person _person  = new Person(firstName: "Baleygr", lastName: "Fjoelsviethr", age: 20000, hobby: "the pursuit for domination of every realm");
    */
    
    static void Main(string[] args)
    {
        // foreach (var message in _messages)
        // {
        //     Console.WriteLine(message);
        // }
        //
        // Console.WriteLine($"{_person.FirstName} {_person.LastName} is {_person.Age} years old and enjoys {_person.Hobby} as a pastime");

        /*Console.WriteLine("Enter grade: ");
        char? grade = Console.ReadKey().KeyChar;
        
        if (grade == 'A')
        {
            Console.WriteLine("\nGood job.");
        }
        else if (grade == 'B')
        {
            Console.WriteLine("\nDecent.");
        }
        else
        {
            Console.WriteLine("\nWork harder.");
        }
        
        switch (grade)
        {
           case 'A':
               Console.WriteLine("\nGood job.");
               break;
           case 'B':
               Console.WriteLine("\nDecent.");
               break;
           case 'C':
               Console.WriteLine("\nWork harder.");
               break;
        }*/
        Console.WriteLine("What is your name?");
        string? firstName = Console.ReadLine();
        Console.WriteLine($"Hello {firstName}, nice to meet you!");
        
        Console.WriteLine("What is your age?");
        int age;
        bool isInt = int.TryParse(Console.ReadLine(), out age);
        Console.WriteLine($"You are {age} years old.");
        
        Console.WriteLine("Do you like pizza? (y/n)? ");
        string? likePizza = Console.ReadLine()?.ToUpper();

        if (likePizza == "Y")
        {
            Console.WriteLine("Nice");
        }
        else
        {
            Console.WriteLine("Sad");
        }
    }
}