using System;

class Program
{
    private static void Main(string[] args)
    {
        double myDouble = 13.37;
        int myInt;

        // Explicit conversion
        myInt = (int)myDouble;
        Console.WriteLine(myInt); // This will now become 13 as int cannot allow the .37.

        // Implicit Conversion

        int num = 123456789;
        long bigNum = num;
        Console.WriteLine(bigNum); // This will still be 123456789 but as a long.

        float myFloat = 13.37f;
        double myNewDouble = myFloat;
        Console.WriteLine(myNewDouble); // This will make it 13.369xxxxxxx.

        // Type Conversion

        string myString = myDouble.ToString();
        Console.WriteLine(myString); // This will become 13.37 but as a string.

        bool sunIsShining = false;
        string myBoolString = sunIsShining.ToString();
        Console.WriteLine(myBoolString); // This will become false but as a string.


        // Challange 1 - Convert the float into a string/

        string myFloatString = myFloat.ToString();
        Console.WriteLine(myFloatString); // This will become 13.37 but as a string.

        // Parsing a string to an Int.

        string myStringNumber1 = "158";
        string myStringNumber2 = "2";
        string result = myStringNumber1 + myStringNumber2;
        Console.WriteLine(result); // This would just return 1582 as you are combining both strings.

        int num1 = Int32.Parse(myStringNumber1);
        int num2 = Int32.Parse(myStringNumber2);
        int result2 = num1 + num2;
        Console.WriteLine(result2); // As we have converted the strings to numbers, this will now make it 160.

        // REMEMBER you cannot parse a string if it contains a character than isn't able to be parsed, for example the letter "A".
        // If you try to parse a string with a character in it, then this will through an exaption.

        // Challange 2 - Parse the below strings

        string stringForFloat = "0.85"; // datatype should be float
        float mystringForFloat = float.Parse(stringForFloat);
        string stringForInt = "12345"; // datatype should be int
        int myStringForInt = Int32.Parse(stringForInt);

    }
}