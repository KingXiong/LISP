while (true)
{
    Console.WriteLine("Please Enter LISP Code:");

    string input = Console.ReadLine();

    if (!string.IsNullOrEmpty(input))
        Console.WriteLine(LISP.BL.Checker.LISPInput(input) ? "Valid input" : "Invalid input");
}

