using System;

Console.WriteLine("Player Name: ");
string playername = Console.ReadLine();
int playerhp = 20;
string playerweapon = "2d6";
string playerblock = "1d20";
int score = 0;

Monster[] enemies = new Monster[3];
enemies[0] = new Monster("Goblin", 15, "1d6");
enemies[1] = new Monster("Orc", 30, "1d8");
enemies[2] = new Monster("Dragon", 60, "1d8");
string enemyname = "goblin";
int enemyhp = 15;
string enemyweapon = "1d6";
for (int i = 0; i < enemies.Length; i++)
{
    Monster enemy = Monster[i];

    while (true)
    {
        Console.WriteLine($"{playername} has {playerhp} hp");
        Console.WriteLine($"{enemyname} has {enemyhp} hp");
        Console.Write("The player decides to (ATTACK/BLOCK)");
        string choice = Console.ReadLine();
        int enemydamage = RollDices(enemyweapon);
        switch (choice)
        {
            case "ATTACK":
                int playerdamage = RollDices(playerweapon);
                playerhp -= enemydamage;
                enemyhp -= playerdamage;
                Console.WriteLine($"Player striked {enemyname} for {playerdamage}, enemy responded with {enemydamage}!");
                break;
            case "BLOCK":
                int playerblockvalue = RollDices(playerblock);
                playerhp -= enemydamage - playerblockvalue;
                Console.WriteLine($"Enemy striked {playername} for {enemydamage}, {playername} blocked {playerblockvalue}");
                break;
            default:
                playerhp -= enemydamage;
                Console.WriteLine($"Enemy striked {playername} for {enemydamage}");
                break;
        }
        if (enemyhp <= 0)
        {
            Console.WriteLine("Player Wins");
            break;
        }
        else if (playerhp <= 0)
        {
            Console.WriteLine("Player Loses");


        }





        /*
        //test for Dice. 
        Console.WriteLine($"New Value 1 = {RollDices("2d6")}");
        Console.WriteLine($"New Value 2 = {RollDices("3d5")}");
        Console.WriteLine($"New Value 3 = {RollDices("1d6")}");
        Console.WriteLine($"New Value 4 = {RollDices("3d5+3")}");
        */

        int RollDices(String input)
        {
            String[] inputelements = input.Split("d", '+');
            int howmanydices = int.Parse(inputelements[0]);
            int howmanysides = int.Parse(inputelements[1]);
            Random random = new Random();
            int result = 0;
            for (int i = 0; i < howmanydices; i++)
            {
                int diceresult = random.Next(1, howmanysides);
                result += diceresult;
            }
            return result;
        }
    }
}

