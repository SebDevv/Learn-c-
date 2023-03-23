class Program
{
    private static void Main(string[] args)
    {
        /*
            Console.Write("Demo text"); // This prints and keeps the cursor on the same line.
            Console.WriteLine("Hello, World!"); // This prints and then puts the cursor on the next line.
            Console.Read(); // This will take a string value input and retun the ASCII value of that input.
            Console.ReadLine(); // This will take a string or int value and return it as the output value.
            Console.ReadKey(); // This will take a single string value and return the value as key info.
        */

   
        // This is the single character input example, this should return 83 if you enter upper case 'S' or 115 if you enter lowercase 's'.
       
        Console.WriteLine("Enter a string and press enter"); // Write out to user to enter a value and then place the cursor on the next line.
        int asciiValue = Console.Read(); // Wait for user to enter a character for example 'S'.
        Console.WriteLine("ASCII Value is {0}",asciiValue); // After user enters a character and hits enter this will display the value in the ASCII format.
        Console.ReadKey(); // This is just waiting for the user to enter some sort of input so that the terminal can end.

        // This is the string input, this will return any string value the user enters.

        Console.WriteLine("Enter a string and press enter"); // Write out to user to enter a value and then place the cursor on the next line.
        string inputString = Console.ReadLine(); // Wait for user to enter a string and press enter.
        Console.WriteLine("The String value you entered is {0}", inputString); // Once the user enters a string and presses enter, this will print the string out.
        Console.ReadKey(); // This is just waiting for the user to enter some key input so that the terminal can end.

        // You can find more information here - https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-7.0
    }
}