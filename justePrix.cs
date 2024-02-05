Random aleatoire = new Random();
int aleatoireNew = aleatoire.Next();
int recommencer = 0;

do
{

    Console.WriteLine("Choisissez un niveau de difficulté entre 1 et 3");
    int difficulte = int.Parse(Console.ReadLine());
    Console.WriteLine("Niveau de difficulté = " + difficulte);

    Console.WriteLine("Devinez le nombre : ");
    int nombreUtilisateur = int.Parse(Console.ReadLine());
    int count = 0;


    switch (difficulte)
    {
        case 1:
            aleatoireNew = aleatoire.Next(100);
            break;
        case 2:
            aleatoireNew = aleatoire.Next(1000);
            break;
        case 3:
            aleatoireNew = aleatoire.Next(10000);
            break;
        default:
            aleatoireNew = aleatoire.Next(100);
            break;
    }

    do
        
    {
        count += 1;
        if (aleatoireNew < nombreUtilisateur)
        {
            Console.WriteLine("C'est plus petit");
            Console.WriteLine("Devinez le nombre");
            nombreUtilisateur = int.Parse(Console.ReadLine());
        }
        else if (aleatoireNew > nombreUtilisateur)
        {
            Console.WriteLine("C'est plus grand");
            Console.WriteLine("Devinez le nombre");
            nombreUtilisateur = int.Parse(Console.ReadLine());
        }
    } while (aleatoireNew != nombreUtilisateur);

    if (aleatoireNew == nombreUtilisateur)
    {
        Console.WriteLine("T'as gagné en " + count + " coup");
        Console.WriteLine("Voulez vous recommencer (0 = Oui, 1 = Non");
        recommencer = int.Parse(Console.ReadLine());
    }

} while (recommencer == 0);


Console.WriteLine("Combien de carré ?");
int carré = int.Parse(Console.ReadLine());

Console.WriteLine("Combien de rond ?");
int rond = int.Parse(Console.ReadLine());

Console.WriteLine("Combien de triangle ?");
int triangle = int.Parse(Console.ReadLine());
int ligne = 0;
int resultat = 0;

if (triangle < carré && triangle < rond)
{
    ligne = 7 * triangle;
}
if (carré < triangle && carré < rond)
{
    ligne = 7 * carré;
}
if (rond < carré && rond < triangle)
{
    ligne = 7 * rond;
}

carré = carré * carré;
rond = rond * rond;
triangle = triangle * triangle;

resultat = carré + rond + triangle + ligne;
Console.WriteLine(resultat);