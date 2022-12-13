// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to Tic-Tac-Toe!");

String a = " " ,b = " " ,c = " " ,d = " " ,e = " " ,f = " " ,g = " " ,h = " " ,i = "";
String Player = "X";
int Moves = 0;
String User;
int UserNumber = 0;




for (int j = 0; j < 9; j++)
{

    Console.WriteLine($" {a} | {b} | {c} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {d} | {e} | {f} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {g} | {h} | {i} ");

    if (j % 2 == 0) { 
        
        Player = "X"; 
    } 
    
    else { 

        Player = "O"; 
    }

    while (Moves < 9)
    {
        Console.WriteLine($" {Player}'s move > ");
        User = Console.ReadLine();
        if (int.TryParse(User, out UserNumber)) continue;
        if (UserNumber == 1)
        {
            if (a != " ")
            {
                Console.WriteLine("Illegal move!");

                continue;
            }
            a = Player;

        }
        else if (UserNumber == 2)
        {
            if (b != " ")
            {
                Console.WriteLine("Illegal move!");

                continue;
            }
            b = Player;
        }
        else if (UserNumber == 3)
        {
            if (c != " ")
            {
                Console.WriteLine("Illegal move!");

                continue;
            }
            c = Player;
        }
        else if (UserNumber == 4)
            {
                if (d != " ")
                {
                    Console.WriteLine("Illegal move!");

                    continue;
                }
            d = Player;
        }
        else if (UserNumber == 5)
                {
                    if (e != " ")
                    {
                        Console.WriteLine("Illegal move!");

                        continue;
                    }
            e = Player;
        }
        else if (UserNumber == 6)
                    {
                        if (f != " ")
                        {
                            Console.WriteLine("Illegal move!");

                            continue;
                        }
            f = Player;
        }
        else if (UserNumber == 7)
                        {
                            if (g != " ")
                            {
                                Console.WriteLine("Illegal move!");

                                continue;
                            }
            g = Player;
        }
        else if (UserNumber == 8)
                            {
                                if (h != " ")
                                {
                                    Console.WriteLine("Illegal move!");

                                    continue;
                                }
            h = Player;
        }
        else if (UserNumber == 9)
                                {
                                    if (i != " ")
                                    {
                                        Console.WriteLine("Illegal move!");
                                    }
            i = Player;
        }
    }
                            }

        




