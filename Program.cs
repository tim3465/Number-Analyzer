
using System.IO.Pipes;
Console.Write("Hello Welcome to NUMBER ANALYZER. \n \nPlease enter your name. ");
string name = Console.ReadLine();
string anser="";

do
{
    Console.WriteLine($"{name} would you be so kind as to enter an integer between 1 and 100 inclusive");
    int number;
    bool validNumber = false;
    do
    {
        //in this loop it will cuntinu untill it gets a valit number
        number = int.Parse(Console.ReadLine());
        if (number < 0 || number > 100)
        {
            Console.WriteLine($"{name} that is an invalid number please try again ");
        }
        else
        {
            validNumber = true;
        }
    } while (!validNumber);

    if (number > 60 && number % 2 == 1)
    {
        //e.
        //1 Point: If the integer entered is odd and greater than 60, print the number entered and “Odd and greater than 60.”
        Console.WriteLine("Odd and greater than 60");
    }
    else if (number > 60 && number % 2 == 0)
    {
        //d.
        //1 Point: If the integer entered is even and greater than 60, print the number entered and “Even and greater than 60.”
        Console.WriteLine("Even and greater than 60.");
    }
    else if (number <= 60 && number >= 26 && number % 2 == 0)
    {
        //c.
        //1 Point: If the integer entered is even and in the inclusive range of 26 to 60, print “Even and between 26 and 60 inclusive.”
        Console.WriteLine("Even and between 26 and 60 inclusive.");
    }
    else if (number >= 2 && number <= 24 && number % 2 == 0)
    {
        //b.
        //1 Point: If the integer entered is even and in the inclusive range of 2 to 24, print “Even and less than 25.”
        Console.WriteLine("Even and less than 25.");
    }
    else if (number < 60 && number % 2 == 1)
    {
        //a.
        //1 Point: If the integer entered is odd and less than 60, print the number entered and “Odd and less than 60.”
        Console.WriteLine("Odd and less than 60.");
    }
    do
    {
        Console.WriteLine($"{name} If you'd like to test another number type y if not type n ");
        anser = Console.ReadLine().ToLower();
    } while (anser != "n" && anser != "y");
} while (anser=="y");
Console.WriteLine($"you have a good day {name}");