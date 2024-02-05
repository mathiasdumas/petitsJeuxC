using System;

class Program
{
    static void Main()
    {
        char[,] grilleMorpion = {
            {' ', '|', ' ', '|',' '},
            {'-', '-','-', '-','-' },
            {' ', '|', ' ', '|',' '},
            {'-', '-','-', '-','-' },
            {' ', '|', ' ', '|',' '},
        };

        char joueur1 = 'X';
        char joueur2 = 'O';
        DrawGrille(grilleMorpion);

        while (!ConditionVictoire(grilleMorpion, joueur2) && !ConditionVictoire(grilleMorpion, joueur1) && !ConditionArret(grilleMorpion))
        {
            Placement(grilleMorpion, joueur1);
            DrawGrille(grilleMorpion);

            if (ConditionVictoire(grilleMorpion, joueur1))
            {
                Console.WriteLine("Le joueur " + joueur1 + " a gagné !");
                break;
            }

            Placement(grilleMorpion, joueur2);
            DrawGrille(grilleMorpion);

            if (ConditionVictoire(grilleMorpion, joueur2))
            {
                Console.WriteLine("Le joueur " + joueur2 + " a gagné !");
                break;
            }

            if (ConditionArret(grilleMorpion))
            {
                Console.WriteLine("La partie est un match nul ");
                break;
            }
        }
    }

    static (int i, int j) Mouvement(char joueur)
    {
        Console.WriteLine(joueur + " : Où placer votre morpial ?");
        int mouvement = int.Parse(Console.ReadLine());
        int i = 0;
        int j = 0;

        switch (mouvement)
        {
            case 1:
                i = 0;
                j = 0;
                break;
            case 2:
                i = 0;
                j = 2;
                break;
            case 3:
                i = 0;
                j = 4;
                break;
            case 4:
                i = 2;
                j = 0;
                break;
            case 5:
                i = 2;
                j = 2;
                break;
            case 6:
                i = 2;
                j = 4;
                break;
            case 7:
                i = 4;
                j = 0;
                break;
            case 8:
                i = 4;
                j = 2;
                break;
            case 9:
                i = 4;
                j = 4;
                break;
            default:
                Console.WriteLine("Choisir hoisir un nombre entre 1 et 9.");
                return Mouvement(joueur);
        }
        return (i, j);
    }

    static void DrawGrille(char[,] grille)
    {
        for (int i = 0; i < grille.GetLength(0); i++)
        {
            for (int j = 0; j < grille.GetLength(1); j++)
            {
                Console.Write(grille[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void Placement(char[,] grille, char joueur)
    {
        (int i, int j) mouvement = Mouvement(joueur);

        if (grille[mouvement.i, mouvement.j] != ' ')
        {
            Console.WriteLine("Place déjà prise. Choisisr une autre position.");
            Placement(grille, joueur);
        }
        else
        {
            grille[mouvement.i, mouvement.j] = joueur;
        }
    }

    static bool VictoireVerticale(char[,] grille, char joueur)
    {
        return (grille[0, 0] == joueur && grille[2, 0] == joueur && grille[4, 0] == joueur ||
                grille[0, 2] == joueur && grille[2, 2] == joueur && grille[4, 2] == joueur ||
                grille[0, 4] == joueur && grille[2, 4] == joueur && grille[4, 4] == joueur);
    }

    static bool VictoireHorizontale(char[,] grille, char joueur)
    {
        return (grille[0, 0] == joueur && grille[0, 2] == joueur && grille[0, 4] == joueur ||
                grille[2, 0] == joueur && grille[2, 2] == joueur && grille[2, 4] == joueur ||
                grille[4, 0] == joueur && grille[4, 2] == joueur && grille[4, 4] == joueur);
    }

    static bool VictoireDiagonale(char[,] grille, char joueur)
    {
        return (grille[0, 0] == joueur && grille[2, 2] == joueur && grille[4, 4] == joueur ||
                grille[0, 4] == joueur && grille[2, 2] == joueur && grille[4, 0] == joueur);
    }

    static bool ConditionArret(char[,] grille)
    {
        for (int i = 0; i < grille.GetLength(0); i++)
        {
            for (int j = 0; j < grille.GetLength(1); j++)
            {
                if (grille[i, j] == ' ')
                {
                    return false;
                }
            }
        }

        return true;
    }

    static bool ConditionVictoire(char[,] grille, char joueur)
    {
        return VictoireDiagonale(grille, joueur) || VictoireHorizontale(grille, joueur) || VictoireVerticale(grille, joueur);
    }
}
