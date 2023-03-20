using System;

public class Variables {

    //Declaring variables can be done in different places, but if we declare them outside a method in the class, then they can be used in other methods
    //if we declare them within a method, then only that method is able to see them.

    //Numbers
    static int _int = 100;
    static sbyte _sbyte = 120;
    static float _float = 99.99f;
    static double _double = 1.5;
    static decimal _decimal = 1.1m;
    static short _short = 3000;
    static long _long = 123456789101112;

    //Text
    static string _string =  "Hello world";
    static char _char = 'A';

    //True or false (Switch)
    static bool _bool = true;

    public static void Main(string[] agrs) {

        _decimal = 1.55m; //We can assign variables to be whatever data we want within a method.

        Console.WriteLine(_decimal); //Output will now be 1.55 as a decimal
        Console.ReadKey(); //This is here to stop the Console closing straight away.
    }
}