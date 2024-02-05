Console.WriteLine("donnez un chiffre");
int chiffre = int.Parse(Console.ReadLine());

// niveau 0

for (int i = 0; i < chiffre; i++)
{
    Console.WriteLine("*");
};


// niveau 1

for (int i = 0; i < chiffre; ++i)
{
    for (int j = 0; j < chiffre; ++j)
    {
        if (j <= chiffre - i)
        {
            Console.Write(" ");
        }
        else
        {
            Console.Write("*");
        }
    }
    Console.WriteLine();
}

// niveau 1

for (int i = 0; i < chiffre; i++)
{
    for (int j = 0; j < chiffre; j++)
    {
        if (j <= i)
        {
            Console.Write("*");
        } else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}

//niveau 2

for (int i = 0; i < chiffre; i++)
{
    for (int j = 0; j < chiffre*2; j++)
    {
        if (j > chiffre - i && j < chiffre + i)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}

//niveau 3

for (int i = 0; i <= chiffre; i++)
{
    for (int j = 0; j <= chiffre; j++)
    {
        if ((j + i )% 2 == 0)
        {
            Console.Write("*");
        } else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}


