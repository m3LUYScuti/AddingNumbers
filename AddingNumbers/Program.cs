using System;
using System.ComponentModel.Design;

Console.WriteLine("1. Add all numbers from 1 to 50 ");
Console.WriteLine("2 Add 5 numbers of your choice");
Console.WriteLine("Choos: 1 or 2");

int choice = int.Parse(Console.ReadLine());

if (choice == 1)
{
    
    int num = 1;
    int Total = 0;

    while (num <= 50)
    {
        
        Total += num;
        num++;

    }

    Console.WriteLine("The sum of numbers from 1 to 50 is: " + Total);


}

else if (choice == 2)
{
    int sum = 0;
    int count = 0;

    while (count < 5)
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        int number;
        if (int.TryParse(input, out number))
        {
            sum += number;
            count++;
        }


        else

            Console.WriteLine("Please enter a valid number.");
    }


    Console.WriteLine("The sum of the numbers you entered is: " + sum);
}

