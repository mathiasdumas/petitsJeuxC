
Random aleatoire = new Random();
int Joueur1Dé = aleatoire.Next(1, 7);
int Joueur2Dé = aleatoire.Next(1, 7);
int countJoueur1 = 0;
int countJoueur2 = 0;
int tour = 1;
int recommencer = 1;
string joueur1 = "Jessica";
string joueur2 = "Imane";

do
{
    while(!Winwin(countJoueur1, countJoueur2))
    {
        Console.WriteLine("Tour " + tour);
        countJoueur1 = Tour(Joueur1Dé, joueur1,countJoueur1);

        if (!Winwin(countJoueur1, countJoueur2))
        {
            countJoueur2 = Tour(Joueur2Dé, joueur2, countJoueur2);
        }
        tour++;

        countJoueur1 = CaseMystere(countJoueur1);
        countJoueur2 = CaseMystere(countJoueur2);

        countJoueur1 = Retombe0(countJoueur1);
        countJoueur2 = Retombe0(countJoueur2);

        Gagner(countJoueur1, joueur1, tour);
        Gagner(countJoueur2, joueur2, tour);

    } 

    Console.WriteLine("Reommencez? (0/1)");
    recommencer = int.Parse(Console.ReadLine());

} while (recommencer == 1);


int Tour(int dé, string joueur, int countJoueur)
{
    dé = aleatoire.Next(1, 7);
    countJoueur += dé;
    Console.WriteLine("\t" + joueur + " a lancé un " + dé + " et est sur la case " + countJoueur);
    return countJoueur;
};

int Retombe0(int countJoueur)
{
    if (countJoueur > 50)
    {
        countJoueur = 0;
    }
    return countJoueur;
};

void Gagner(int countJoueur, string joueur, int tour)
{
    if (countJoueur == 50)
    {
        Console.WriteLine("bravo " + joueur + " tu as gagné en " + tour + " tours"); ;
    }
}

int CaseMystere(int countJoueur)
{
    switch (countJoueur)
    {
        case 17:
            countJoueur += 2;
            break;
        case 25:
            countJoueur -= 10;
            break;
        case 40:
            countJoueur += 9;
            break;
    }
    return countJoueur;
};

bool Winwin(int player1, int player2)0
{
    if (player1 == 50 || player2 == 50)
    {
        return true;
    }
    else 
        return false;

};
//# Evaluation pratique
//-Cette évaluation sera à faire en deux fois
//- Une fois avec vos connaissances actuelles & une fois après avoir vu quelques conseils de clean code (code propre)

//## Objectifs
//-Vous devez faire un script php procédural qui permet de faire jouer deux joueurs au jeu du serpent (plateau)  
//-Votre objectif est de réaliser le jeu en utilisant **des fonctions**
//- Aucune nécessité pour de réalisé une belle interface, des affichages dans la console suffisent.
//- A minima une fonction pour :
//    -Réaliser le tour d'un joueur, donc lancer le dé et modifier le score (attention, cette fonction nécessitera normalement un return)
//    - Afficher dans la console la position des joueurs
//    - Afficher le gagnant à la fin de la partie
//    - Proposer de rejouer une partie ou terminer le programme

//## Fonctionnalités premières
//Voici les fonctionnalités attendues par votre jeu du serpent :
//-Lancé de dé(1-6) aléatoire(voir Random.Next())
//- Jeu au tour par tour, chaque joueur lance un dé lors de son tour, un affichage dans la console doit afficher le nombre sorti par le dé et la nouvelle position du joueur
//-	Déplacement des joueurs en fonction du nombre sorti par le dé (1-6)
//-Si le joueur dépasse 50, il revient automatiquement à la case 25
//-	La partie se termine lorsqu’un joueur arrive à la case 50, il gagne donc la partie ! Le vainqueur est affiché et on peut relancer une partie ou terminer l'exécution du programme.

//## Fonctionnalités optionnelles
//-	Ajoutez des cases pièges, par exemple la 37 fait redescendre à la 12, la 14 fait revenir à la 7 et la 46 fait revenir à la case 33 (Mettez les valeurs que vous voulez)
//-Ajoutez des cases bonus, par exemple la 20 fait monter à la case 35, la 2 fait monter à la case 17 et la 31 fait monter à la 43 (Mettez les valeurs que vous voulez)

//Bon courage et bons dévs à toutes et à tous !