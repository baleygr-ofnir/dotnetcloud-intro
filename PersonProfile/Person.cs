namespace PersonProfile;

class Person
{
    public string? Name;
    public int Age;
    public int Birthyear;
    public double Height;
    public int FavNum;
    public bool Student;
    public bool PizzaEnjoyer;
    public char Grade;

    public Person()
    {
        string baseMessage = "What is your";
        string[] messages =
        [
            "first name",
            "last name",
            "age",
            "birthyear", 
            "height in meters",
            "favourite number",
            "grade",
            "Are you a student?",
            "Do you like pizza?"
        ];
        foreach (string message in messages)
        {
            if (message.Contains("student") || message.Contains("pizza"))
            {
                Console.WriteLine($"\n{message} (y/n)");
                if (message.Contains("student"))
                {
                    Student = Console.ReadKey().KeyChar.Equals('y');
                }
                else
                {
                    PizzaEnjoyer = Console.ReadKey().KeyChar.Equals('y');
                    Console.WriteLine(PizzaEnjoyer ? "\nYou love pizza!" : "\nNot a pizza fan, huh?");
                }
            }
            else
            {
                Console.WriteLine($"{baseMessage} {message}?");
                switch (message)
                {
                    case "first name":
                        Name = Console.ReadLine();
                        break;
                    case "last name":
                        Name += $" {Console.ReadLine()}";
                        break;
                    case "age":
                        Age = ValidInt();
                        break;
                    case "birthyear":
                        Birthyear = ValidInt();
                        break;
                    case "height in meters":
                        Height = ValidDouble();
                        break;
                    case "favourite number":
                        FavNum = ValidInt();
                        break;
                    case "grade":
                        Grade = char.ToUpper(ValidGrade());
                        break;
                }
            }
        }
    }

    public void GetProfile()
    {
       Console.WriteLine($@"--- PROFILE CARD ---
Name: {Name}
Age: {Age}
Height: {Height}
Favourite Number: {FavNum}
Student: {Student}
Likes Pizza: {PizzaEnjoyer}
Grade: {Grade}
---------------------");
       // Age check
       Console.WriteLine(Age >= 18 ? "\nYou are an adult." : "\nYou are a minor.");
       // Height check
       Console.WriteLine(Height > 1.80 ? "You are tall!" : "Height is average or below.");

       // Favourite number check
       switch (FavNum)
       {
           case 7:
               Console.WriteLine("Lucky 7!");
               break;
           case 10:
               Console.WriteLine("Perfect 10!");
               break;
           case 42:
               Console.WriteLine("The Answer to the Ultimate Question of Life, the Universe, and Everything!");
               break;
           default:
               Console.WriteLine("Cool number!");
               break;
       }
       // Grade check
       switch (Grade)
       {
           case 'A':
               Console.WriteLine("Excellent work!");
               break;
           case 'B':
               Console.WriteLine("Good job.");
               break;
           case 'C':
               Console.WriteLine("You passed.");
               break;
           case 'D':
               Console.WriteLine("Needs improvement.");
               break;
           case 'F':
               Console.WriteLine("Failed, try again.");
               break;
       }
    }

    private char ValidGrade()
    {
        char inputGrade;
        char[] grades = ['A','B','C','D','F'];
        do
        {
            inputGrade = char.ToUpper(Console.ReadKey().KeyChar);
            if (!grades.Contains(inputGrade)) Console.WriteLine("\nEnter a valid grade. [A, B, C, D, F]");
        } while (!grades.Contains(inputGrade));
        return inputGrade;
        
    }
    private double ValidDouble()
    {
        double validDouble;
        bool isDouble;
        do
        {
            isDouble = double.TryParse(Console.ReadLine(), out validDouble);
            if (!isDouble)
            {
                Console.WriteLine("Try again with a valid decimal value in meters.");
            }
        } while (!isDouble);
        return validDouble;
    }
    private int ValidInt()
    {
        int validInt;
        bool isInt;
        do
        {
            isInt = int.TryParse(Console.ReadLine(), out validInt);
            if (!isInt)
            {
                Console.WriteLine("Try again with a valid integer.");
            }
        } while (!isInt);
        return validInt;
    }


}