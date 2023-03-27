class Program
{
    private static void Main(string[] args)
    {
        int age = 26;
        string name = "Seb";
        string job = "Developer";

        // 1. string concatenation
        Console.WriteLine("String Concatenation");
        Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old");

        // 2. string formatting 
        // We use the index in the string format
        Console.WriteLine("String formatting");
        Console.WriteLine("Hello my name is {0},  I am {1} years old. I am a {2}",name,age,job);

        // 3. string interpolation
        // We have to add the $ symbol at the start of the string.
        Console.WriteLine("String interpolation");
        Console.WriteLine($"Hello my name is {name}, I am {age} years old");

        // 4. verbatim strings
        // Will use the @ symbol at the beginning
        // Will ignore all spaces and slashes like \n
        Console.WriteLine("Verbatim strings");
        Console.WriteLine(@"Hello,
        my name is seb and i am 26 years old.");
    }
}