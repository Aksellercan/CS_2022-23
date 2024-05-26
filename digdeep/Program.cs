// See https://aka.ms/new-console-template for more information

// Fundamentals #1

// Question 3:

/*
int a = 10;
    int b = 15;
bool compare = (a == b);
Console.WriteLine($"The Two integers are equal: { compare}");
*/

// Question 5:

/*
Console.WriteLine("Enter a number between 0 and 5");
int a = int.Parse(Console.ReadLine());
if (a < 0 || a > 5)
{
    Console.WriteLine("Number can't be larger than 5 or smaller than 0");
}
else
{
    switch (a)
    {
        case 0:
            Console.WriteLine("Zero");
            break;
        case 1:
            Console.WriteLine("One");
            break;
        case 2:
            Console.WriteLine("Two");
            break;
        case 3:
            Console.WriteLine("Three");
            break;
        case 4:
            Console.WriteLine("Four");
            break;
        case 5:
            Console.WriteLine("Five");
            break;
    }
}
*/

// Question 4:

/*
Console.WriteLine("Enter 3 numbers ");

Console.WriteLine("First: ");
int aa = int.Parse(Console.ReadLine());
Console.WriteLine("Second: ");
int bb = int.Parse(Console.ReadLine());
Console.WriteLine("Third: ");
int cc = int.Parse(Console.ReadLine());

if (aa == 99 || bb == 99 || cc == 99 || aa + bb + cc > 50)
{
    Console.WriteLine("Invalid Values");
}
else
{
    Console.WriteLine("Valid Values");
}
*/


// Question 6: 

/*
for (int i = 15; i <= 35; i++)
{
    Console.WriteLine(i);
}
*/

// Question 7.0:

/*
for (int i = 450; i <= 550; i++)
{
    if (i % 2 == 0 || i % 3 == 0)
    {
        Console.WriteLine(i);
    }
}
*/


// Question 7.1:
/*
int a = 450;
while (a < 550)
{if (a % 2 == 0 || a % 3 == 0)
    {
        Console.WriteLine(a);
    }
    a++;
}
*/

// Question 8:

// Online Class 1: 

/*
using System;
using System.Diagnostics;
class Program
{
    static void Main()
    {
        // makes sure all function code is already loaded in memory
        Console.WriteLine(FirstAndLast(new int[] { 5, 7 }));
        int[] data = { 1, 2, 4, 9, 12, 15, 19, 25, 32, 60 };
        var watch = System.Diagnostics.Stopwatch.StartNew();
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(FirstAndLast(data));
        }
        watch.Stop();
        var elapsedMs = watch.ElapsedMilliseconds;
        Console.WriteLine(elapsedMs);
        int[] data2 = new int[100000];
        Array.Fill(data2, 3);
        var watch2 = System.Diagnostics.Stopwatch.StartNew();
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(FirstAndLast(data2));
        }
        watch2.Stop();
        var elapsedMs2 = watch2.ElapsedMilliseconds;
        Console.WriteLine(elapsedMs2);
    }
    static (int, int) FirstAndLast(int[] data)
    {
        int first = data[0];
        int last = data[data.Length - 1];
        return (first, last);
    }
}
*/

// Online Class 2:

/*
// Create a random object
Random random = new Random();

// Generate a random number from 1 to 10
int number = random.Next(1, 11);

// Print the number
Console.WriteLine("The random number is: " + number);

// Print the amount of stars equal to the number
for (int i = 0; i < number; i++)
{
    Console.Write("*");
}
*/

// Question 8:

/*

Random random = new Random();
int a = random.Next(0, 20);

for (int i = 0; i < a; i++)
{
    Console.Write("*");
}
*/

/*
for (int row = 7; row < 10; row++)
{
    for (int kol = 9; kol >= 5; kol = kol - 2)
    {
        Console.WriteLine(row+ ":"+ kol);
    }
}
*/

// Fundamentals #2

// Question 1:

/*
Console.WriteLine("Enter a number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine($"The number you entered was {a}");
*/

// Question 2:

/*
Console.WriteLine("Enter two numbers for a and b: ");
Console.WriteLine("a: ");
int aa = int.Parse(Console.ReadLine());
Console.WriteLine("b: ");
int bb = int.Parse(Console.ReadLine());

Console.WriteLine($"Addition: {aa+bb}, Substraction: {aa-bb}, Multiplication: {aa*bb} and Division: {aa/bb}");
*/

// Question 3:
/*
Console.WriteLine("Enter two numbers for a and b: ");
Console.WriteLine("a: ");
int aa = int.Parse(Console.ReadLine());
Console.WriteLine("b: ");
int bb = int.Parse(Console.ReadLine());

bool cc = true;

if (aa < bb)

{
    cc = false;
    Console.WriteLine("The second integer was greater than the first");
}
else if (aa > bb)
{
    cc = true;
    Console.WriteLine("The first integer was greater than the second");
}
*/

// 31st of march test Data Structures

// Question 4:

/*
Console.WriteLine("Enter three numbers for a,b and c: ");
Console.WriteLine("a: ");
int aa = int.Parse(Console.ReadLine());
Console.WriteLine("b: ");
int bb = int.Parse(Console.ReadLine());
Console.WriteLine("c: ");
int cc = int.Parse(Console.ReadLine());
if (aa == bb && aa == cc)
{
    Console.WriteLine("All 3 numbers are equal");
}
else
{
    Console.WriteLine("Not all numbers are equal");
}
*/

/*
 bool dd = aa==bb;
bool ee = aa==cc;
Console.WriteLine(dd&&ee);
*/

// Question 5:

/*

Console.WriteLine("Enter three numbers for a,b and c: ");
Console.WriteLine("a: ");
int aa = int.Parse(Console.ReadLine());
Console.WriteLine("b: ");
int bb = int.Parse(Console.ReadLine());
Console.WriteLine("c: ");
int cc = int.Parse(Console.ReadLine());

if (aa == bb || aa == cc || bb == cc ){
    Console.WriteLine("At least 2 numbers are equal");
}
else
{
    Console.WriteLine("None of the numbers are equal");

}
*/

// Question 6:

/*
Console.WriteLine("Choose a Language: ");
string lang = Console.ReadLine();
Console.WriteLine("Enter a number from 0 to 5: ");
int aa = int.Parse(Console.ReadLine());

if (aa > 5)
{
    Console.WriteLine("ERROR");
}
    if (lang == "english")
    {
        switch (aa)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
        }
    }
    else if (lang == "polish")
    {
        switch (aa)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("Jeden");
                break;
            case 2:
                Console.WriteLine("Dwa");
                break;
            case 3:
                Console.WriteLine("Trzy");
                break;
            case 4:
                Console.WriteLine("Cztery");
                break;
            case 5:
                Console.WriteLine("Pięć");
                break;
        }
    }
*/



// Dry run 46
/*
void rdruk(int[] liczby)
{
    for (int i = liczby.Length; i > 0; i--)
    {
        if (liczby[i - 1] == 6)
        {
            Console.WriteLine("Szostka!");
        }
        else Console.WriteLine(liczby[i - 1]);
    }
}

int[] ocenyJa = { 2, 4, 6 };
int[] ocenyTy = { 1, 6, 5 };
rdruk(ocenyJa);
rdruk(ocenyTy);
*/

// Question 8



Console.Write("Enter a number: ");
int aa = int.Parse(Console.ReadLine());
int cc = 0;
int i = aa + 1; // incase of 0 it will include 0 too, so to make sure I 1 up the input.
do
{
    if (i % 7 == 0)
    {
        Console.WriteLine(i);
        cc++;
    }
    i++;
} while (cc < 5);





// Question 9

/*

for (int i = 0; i <= 50; i++)

{
    Console.Write(i + " - ");
    Console.WriteLine(50 - i);
}
*/

// Question 10

/*
 // ******************************
for (int i = 50; i <= 70; i++)

{
    Console.Write(i + " - ");
    for (int j = 1; j < 6; j++)
    {
        Console.Write(j+",");
    }
    Console.WriteLine();


}
*/

// Question 11

/*

int[] numbers = { 7, 9, 6, 8, 2 };

Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[4]);

*/

// Question 12

/*

int[] numbers = { 7, 9, 6, 8, 2 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

*/

// Fundamentals #3

// Question 1


/*
Console.WriteLine("First Number: ");

int aa = int.Parse(Console.ReadLine());
Console.WriteLine("Second Number: ");
int bb = int.Parse(Console.ReadLine());
Console.WriteLine("Third Number: ");
int cc = int.Parse(Console.ReadLine());

if (aa == 33 || bb == 33 || cc == 33)
{
    Console.WriteLine("Invalid");

}
*/


// Question 2


/*
Console.WriteLine("Enter Password: ");

int actpass = 123;
for (int i = 0; i < 7; i++) {

    Console.WriteLine("Enter Password: ");
    int pass = int.Parse(Console.ReadLine());
    if (pass != actpass)
    {
        Console.WriteLine($"Wrong password.Please try again {i+1}");
    }
}
*/