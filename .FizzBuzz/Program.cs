// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Welcome to FizzBuzz!");

Console.WriteLine("Select an integer numeric range:");
int userInput = Convert.ToInt32(Console.ReadLine());

string fizz = "Fizz";
string buzz = "Buzz";
string bang = "Bang";
string bong = "Bong";
// string fezz = "Fezz";

List<string> resultList = new List<string>();

string getSingleResult(string str, string str2)
{
    return str + str2;
}

void getFizzBuzz()
{

    for (int i = 1; i <= userInput; i++)
    {
        switch (true)
        {
            case true when i % 3 == 0 && i % 7 == 0:
                resultList.Add(getSingleResult(fizz, bang));
                break;

            case true when i % 5 == 0 && i % 7 == 0:
                resultList.Add(getSingleResult(buzz, bang));
                break;

            case true when i % 3 == 0 && i % 5 == 0:
                resultList.Add(getSingleResult(fizz, buzz));
                break;

            // case true when i % 13 == 0:
            //     resultList.Add(fezz);
            //     break;

            case true when i % 11 == 0:
                resultList.Add(bong);
                break;

            case true when i % 7 == 0:
                resultList.Add(bang);
                break;

            case true when i % 5 == 0:
                resultList.Add(buzz);
                break;

            case true when i % 3 == 0:
                resultList.Add(fizz);
                break;

            default:
                resultList.Add(i.ToString());
                break;
        }
    }

    foreach (var result in resultList)
    {
        Console.WriteLine(result);
    }

}

getFizzBuzz();