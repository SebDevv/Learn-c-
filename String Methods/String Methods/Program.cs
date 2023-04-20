class Program
{
    private static void Main(string[] args)
    {
        string name = "Seb";

        string name2 = name.Substring(0);
        Console.WriteLine(name2);

        // Challange 1
        string Challangename = "";
        Console.WriteLine("Please enter your name followed by the ENTER key.");
        Challangename = Console.ReadLine(); // Will assign name as what i enter, which will be " Sebastian "
        Console.WriteLine(Challangename.ToUpper()); // Will message out the name in uppercase = SEBASTIAN
        Console.WriteLine(Challangename.ToLower()); // Will message out the name in lowercase = sebastian
        Console.WriteLine(Challangename.Trim()); // Will remove any " " from the start and end = Sebastian
        Console.WriteLine(Challangename.Substring(2)); // Will return the substring starting at index 2 = ebastian

        // Challange 2
        string string1 = "";
        char searchInput;
        Console.WriteLine("Enter a string here: ");
        string1 = Console.ReadLine();
        Console.WriteLine("Enter a character to search");
        searchInput = Console.ReadLine()[0];
        int searchindex = string1.IndexOf(searchInput);
        Console.WriteLine(searchindex);

        Console.WriteLine("Enter your firstname: ");
        string firstname = Console.ReadLine();
        Console.WriteLine("Enter your lastname: ");
        string lastname = Console.ReadLine();

        string fullname = string.Concat(firstname," ",lastname);
        Console.WriteLine(fullname);

        // Challange 3
        int _int = 158;
        float _float = 1.5f;
        double _double = 11.11;
        string _string = "158";

        Console.WriteLine(_int.ToString());
        Console.WriteLine(Convert.ToDouble(_float));
        Console.WriteLine(Convert.ToDecimal(_double));
        Console.WriteLine(Int32.Parse(_string));

        const string birthday = "17/12/1996";
        Console.WriteLine("My birthday will always be {0}",birthday);

 
    }
}