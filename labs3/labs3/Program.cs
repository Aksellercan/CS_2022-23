// See https://aka.ms/new-console-template for more information

Console.WriteLine("Number ");
int x = int.Parse(Console.ReadLine());
if (x % 2 == 1)
{
    Console.WriteLine("Odd");
}
else
{
    Console.WriteLine("Even");
}




Console.WriteLine("a = ?");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("b = ?");
int b =int.Parse(Console.ReadLine());

double c = a * b;
double d = a + b;
double u = c / d;

Console.WriteLine(u);


Console.WriteLine();
int p = int.Parse(Console.ReadLine());


Console.WriteLine("First Number = ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Operation = ");
String k = Console.ReadLine();
Console.WriteLine("Second Number = ");
int m = int.Parse(Console.ReadLine());
int result = 0;
switch (k)
{
    case "+": result = n + m; break;
    case "-": result = n - m; break;
    case "*": result = n * m; break;
    case "/": result = n / m; break;
}


Console.WriteLine("Result = " + result);

