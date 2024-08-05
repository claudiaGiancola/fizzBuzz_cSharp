// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to FizzBuzz!");

Console.WriteLine("Select an integer numeric range:");
int userInput = Convert.ToInt32(Console.ReadLine());

string fizz = "Fizz";
string buzz = "Buzz";
string bang = "Bang";
string bong = "Bong";
string fezz = "Fezz";

for (int i = 1; i <= userInput; i++)
{
    switch (true)
    {
        case true when i % 3 == 0 && i % 7 == 0:
            Console.WriteLine(fizz + bang);
            break;

        case true when i % 5 == 0 && i % 7 == 0:
            Console.WriteLine(buzz + bang);
            break;

        case true when i % 3 == 0 && i % 5 == 0:
            Console.WriteLine(fizz + buzz);
            break;

        case true when i % 13 == 0:
            Console.WriteLine(fezz);
            break;

        case true when i % 11 == 0:
            Console.WriteLine(bong);
            break;

        case true when i % 7 == 0:
            Console.WriteLine(bang);
            break;

        case true when i % 5 == 0:
            Console.WriteLine(buzz);
            break;

        case true when i % 3 == 0:
            Console.WriteLine(fizz);
            break;

        default:
            Console.WriteLine(i);
            break;
    }
}