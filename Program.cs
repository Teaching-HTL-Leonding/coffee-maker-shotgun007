Console.Clear();
Console.OutputEncoding = System.Text.Encoding.Default;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;

double coins1 = 0;
double coins2x = 0;
double coins50 = 0;
double coins50x = 0;
int error = 0;
double coins11 = 0;
Console.WriteLine("How much money (💲) have you provided?");
double originalusermoney = double.Parse(Console.ReadLine()!);

while (originalusermoney % (1d / 2) != 0)
{
    Console.WriteLine("How much money (💲) have you provided?");
    originalusermoney = double.Parse(Console.ReadLine()!);
}
int boughtproduct = 0;
for (boughtproduct = 0; boughtproduct < 4;)
{
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Write (1) if you want buy tea 🍵 (1,50€), write (2) if you want buy cacao 🍫☕ (2,50€), write (3) if you want buy coffee ☕ (3.50€) or press (4) for buying nothing ❌!");
    boughtproduct = int.Parse(Console.ReadLine()!);
    if (originalusermoney >= 1.5)
    {
        if (boughtproduct == 1)
        {
            originalusermoney -= 1.5;
            error++;
        }
    }
    if (originalusermoney >= 2.5)
    {
        if (boughtproduct == 2)
        {
            originalusermoney -= 2.5;
            error++;
        }
    }
    if (originalusermoney >= 3.5)
    {
        if (boughtproduct == 3)
        {
            originalusermoney -= 3.5;
            error++;
        }
    }
    if (boughtproduct == 4)
    {
        error++;
        Console.WriteLine("You will get" + originalusermoney + "€ back.");
        double coins = originalusermoney / 0.5;
        double modolufour = coins % 4;
        if (coins >= 4)
        {
            if (modolufour == 1)
            {
                coins2x = coins - 1;
                coins1 = 1;
            }
            else if (modolufour == 2)
            {
                coins2x = coins - 2;
                coins1 = 2;
            }
            else if (modolufour == 3)
            {
                coins2x = coins - 3;
                coins1 = 3;
            }
            else if (modolufour == 0)
            {
                coins2x = coins;
            }
            if (coins1 % 2 == 1)
            {
                coins50x = coins1 - 1;
                coins50 = 1;
            }
            else if (coins1 % 2 == 0)
            {
                coins50x = coins1;
            }
        }
        coins11 = coins50x / 2;

        if (coins < 4)
        {
            if (coins == 3)
            {
                coins11 = 1;
                coins50 = 1;
            }
            else if (coins == 2)
            {
                coins11 = 1;
            }
            else if (coins == 1)
            {
                coins50 = 1;
            }
        }
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.ForegroundColor = ConsoleColor.Black;
        double coins2 = coins2x / 4;
        Console.WriteLine("You got" + coins2 + "coins back(2€).");
        Console.WriteLine("You got" + coins11 + "coins back(1€).");
        Console.WriteLine("You got" + coins50 + "coins back (0.5€).");
    }
    if (error == 0 || boughtproduct > 4)
    {
        Console.WriteLine("ERROR!!!");
    }
}
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;