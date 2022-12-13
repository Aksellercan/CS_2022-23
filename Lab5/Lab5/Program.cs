// See https://aka.ms/new-console-template for more information

//pig --> igpay
String input = Console.ReadLine();

String[] sentence = input.Split(' ');
String a = input.Substring(0, 1);
String b = input.Substring(1);

Console.WriteLine(b + a + "ay");

