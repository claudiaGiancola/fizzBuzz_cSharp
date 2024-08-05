// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

//useful info about C# jump statement (switch case "continue" instead of "break")
//found at A Comprehensive Walkthrough of C# Jump Statements
//at https://www.pluralsight.com/resources/blog/guides/flow-control-csharp-jump-statements-break-continue


Console.WriteLine("Welcome to FizzBuzz!");

Console.WriteLine("Select an integer numeric range:");
int userInput = Convert.ToInt32(Console.ReadLine());

string fizz = "Fizz";
string buzz = "Buzz";
string bang = "Bang";
string bong = "Bong";
// string fezz = "Fezz";

void getFizzBuzz()
{

    for (int i = 1; i <= userInput; i++)
    {

        List<string> resultForNumber = new List<string>();

        bool isFizz = i % 3 == 0;
        bool isBuzz = i % 5 == 0;
        bool isBang = i % 7 == 0;
        bool isBong = i % 11 == 0;

        if (isBong)
        {
            resultForNumber.Add(bong);
            Console.WriteLine(string.Join("", resultForNumber));
            continue;
        }

        if (isFizz)
        {
            resultForNumber.Add(fizz);
        }

        if (isBuzz)
        {
            resultForNumber.Add(buzz);
        }

        if (isBang)
        {
            resultForNumber.Add(bang);
        }

        if (!isFizz && !isBuzz && !isBang && !isBong)
        {
            resultForNumber.Add(i.ToString());
        }

        // if (i % 13 == 0)
        // {

        // }

        if (i % 17 == 0)
        {
            resultForNumber.Reverse();
        }

        Console.WriteLine(string.Join("", resultForNumber));
    }
}

getFizzBuzz();