﻿// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

Console.WriteLine("Welcome to FizzBuzz!");

Console.WriteLine("Select an integer numeric range:");
int userInput = Convert.ToInt32(Console.ReadLine());

string fizz = "Fizz";
string buzz = "Buzz";
string bang = "Bang";
string bong = "Bong";
string fezz = "Fezz";

void getFizzBuzz()
{

    for (int i = 1; i <= userInput; i++)
    {

        List<string> resultForNumber = new List<string>();

        bool isFizz = i % 3 == 0;
        bool isBuzz = i % 5 == 0;
        bool isBang = i % 7 == 0;
        bool isBong = i % 11 == 0;
        bool isFezz = i % 13 == 0;
        bool isReverse = i % 17 == 0;

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

        if (string.Join("", resultForNumber) == "")
        {
            resultForNumber.Add(i.ToString());
        }

        if (isFezz)
        {
            if (resultForNumber[0].StartsWith('B'))
            {
                resultForNumber.Insert(0, fezz);
            }
            else if (resultForNumber[1].StartsWith('B'))
            {
                resultForNumber.Insert(1, fezz);
            }
            else
            {
                resultForNumber.Add(fezz);
            }
        }

        if (isReverse)
        {
            resultForNumber.Reverse();
        }

        Console.WriteLine(string.Join("", resultForNumber));
    }
}

getFizzBuzz();