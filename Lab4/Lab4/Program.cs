// See https://aka.ms/new-console-template for more information
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    int a = number % i ;
    if (a == 0)
    {
        Console.WriteLine("prime " + i);
    }
    else
    {
        Console.WriteLine("nope " + i);  
    }

        

    }
