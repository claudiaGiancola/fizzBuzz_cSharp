// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

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

        //do not stop loop
        // if (i % 3 == 0)
        // {
        //     resultForNumber.Add(fizz);
        // }
        // if (i % 5 == 0)
        // {
        //     resultForNumber.Add(buzz);
        // }

        List<string> resultForNumber = new List<string>();

        switch (true)
        {

            case true when i % 11 == 0:
                resultForNumber.Add(bong);
                break;

            case true when i % 3 == 0:
                resultForNumber.Add(fizz);
                goto case true when i % 5 == 0;

            case true when i % 5 == 0:
                resultForNumber.Add(buzz);
                continue;

            case true when i % 7 == 0:
                resultForNumber.Add(bang);
                continue;

            default:
                resultForNumber.Add(i.ToString());
                break;
        }

        Console.WriteLine(string.Join("", resultForNumber));
    }
}

getFizzBuzz();