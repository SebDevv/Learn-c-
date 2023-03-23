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

    //We can declare multiple variables as once. See below examples:
    static int Number1, Number2, Number3;
    static string Text1 = "Hello", Text2 = "I am", Text3 = "Seb";

    public static void Main(string[] agrs) {

        _decimal = 1.55m; //We can assign variables to be whatever data we want within a method.
        Console.WriteLine(_decimal); //Output will now be 1.55 as a decimal

        //int adding.

        Number1 = 100;
        Number2 = 250;
        Number3 = Number1 + Number2;
        Console.WriteLine("Number 1: " + Number1 + " + Number 2: " + Number2 + " Is " + Number3);

        //double adding.

        double _d1 = 1.5;
        double _d2 = 1.5;
        double sum = _d1 + _d2;
        Console.WriteLine("D1 + D2 = " + sum); //Output should be 3, this is the sum of 1.5 + 1.5

        //float adding.

        float f1 = 3.45f;
        float f2 = 5.1f;
        float f3 = f1 + f2;
        Console.WriteLine("F1 + F2 = " + f3);

        Console.ReadKey(); //This is here to stop the Console closing straight away.
    }
}