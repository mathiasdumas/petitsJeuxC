Random aleatoire = new Random();
int aleatoireNew = aleatoire.Next();

int cerise = 1;
int banane = 2;
int pomme = 3;
int sept = 4;
int tentative = 0;


Console.WriteLine("Combien tu veux jouer?");
int count = int.Parse(Console.ReadLine());


for (count = 100; count >= 4; count -= 5)
{
    tentative++;
    int essai1 = aleatoire.Next(1, 5);
    int essai2 = aleatoire.Next(1, 5);
    int essai3 = aleatoire.Next(1, 5);
    if (essai1 == 1 && essai2 == 1 || essai3 == 1 && essai2 == 1 || essai3 == 1 && essai1 == 1)
    {
        count += 12;
    }
    if (essai1 == 1 && essai2 == 1 && essai3 == 1)
    {
        count += 20;
    }
    if (essai1 == 2 && essai2 == 2 && essai3 == 2)
    {
        count += 30;
    }
    if (essai1 == 3 && essai2 == 3 && essai3 == 3)
    {
        count += 50;
    }

    if (essai1 == 4 && essai2 == 4 && essai3 == 4)
    {
        count += 100;
    }

};

Console.WriteLine("tu as pu jouer " + tentative + " fois. Et il te reste " + count + " euros");