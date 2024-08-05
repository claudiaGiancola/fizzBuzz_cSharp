// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to FizzBuzz!");

string fizz = "Fizz";
string buzz = "Buzz";

for (int i = 1; i <= 100; i++)
{
    switch (true)
    {
        case true when i % 3 == 0 && i % 5 == 0:
            Console.WriteLine(fizz + buzz);
            break;

        case true when i % 3 == 0:
            Console.WriteLine(fizz);
            break;

        case true when i % 5 == 0:
            Console.WriteLine(buzz);
            break;

        default:
            Console.WriteLine(i);
            break;
    }
}