//FizzBuzz();
//RandomGuess();
//Guess();
//int m = int.Parse(Console.ReadLine());
GuessMenu();


void GuessMenu()
{
    Console.WriteLine("Welcome");
    Console.WriteLine("press 1 for computer to guess your number");
    Console.WriteLine("press 2 to guess random number");
    int n = int.Parse(Console.ReadLine());
    if (n == 1)
    {
        GuessSplit();

    }
    else if (n == 2)
    {
        Guess();
    }
}


void GuessSplit()
{
    int m = int.Parse(Console.ReadLine());
    int i = 0;
    while (i < 100)
    {
        Random rd = new Random();
        int rand_num = rd.Next(1, 100);
        i++;
        if (rand_num == m)
        {
            Console.WriteLine("Found it after " + i + " try(s)");
            break;
        }
        else
            if (rand_num < m)
        {
            Random dt = new Random();
            int rand_new = dt.Next(1, m);
            //Console.WriteLine("new range " + rand_new);
            if (rand_new > m)
            {
                Random rt = new Random();
                int rand_new1 = rt.Next(m, 1);


            }

        }
    }
}
        void Guess()
        {
            int m = int.Parse(Console.ReadLine());
            int i = 0;
            Random rd = new Random();
            int rand_num = rd.Next(1, 10);
            while (i < 10)
            {
                i++;
                if (rand_num < m)
                {
                    rand_num++;
                }
                else if (rand_num > m)
                {
                    rand_num--;


                }
                else if (rand_num == m)
                {
                    Console.WriteLine("guessed it on " + i + " try(s)");
                    break;

                }

            }
        }
void RandomGuess()
{

    Random rd = new Random();
    int rand_num = rd.Next(1, 10);
    int i = 0;
    while (i < 10) {
        i++;
        int User = int.Parse(Console.ReadLine());
     
        int m = User;
        if (m == rand_num)
        {
            Console.WriteLine("Congrats");
            break;

        }
        else
        {
            Console.WriteLine("try again");
        }
        if (m > rand_num)
        {
            Console.WriteLine("Lower");
        }
        else { Console.WriteLine("Higher"); }
    }
    
}
void FizzBuzz(int m)
{

    if (m % 5 == 0 && m % 3 == 0)
    {
        Console.WriteLine("FIZZBUZZ");
    }
    else if (m % 3 == 0)
    {
        Console.WriteLine("FIZZ");
    }
     if (m % 5 == 0)
    {
        Console.WriteLine("BUZZ");
    }
 }