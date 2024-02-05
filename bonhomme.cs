using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using System;

namespace tableaux;

class Program
{
    static void Main(string[] args)
    {
        string[,] grille = { { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" } };
        int BonhommeI = 2;
        int BonhommeJ = 2;
        int ArriveeI = 4;
        int ArriveeJ = 3;
        ConsoleKeyInfo keyInfo;


        do

        {
            Console.Clear();
            for (int i = 0; i < grille.GetLength(0); i++)
        {
                for (int j = 0; j < grille.GetLength(1); j++)
                    if (i == BonhommeI && j == BonhommeJ)
                    {
                        Console.Write("@ ");
                    }
                    else if (i == ArriveeI && j == ArriveeJ)
                    {
                        Console.Write("! ");
                    }
                    else
                    {
                        Console.Write(grille[i, j] + " ");
                    }
                Console.WriteLine();

            }

            keyInfo = Console.ReadKey();
            Console.WriteLine("-----------------");


            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (BonhommeJ > 0)
                        BonhommeJ--;
                    break;
                case ConsoleKey.RightArrow:
                    if (BonhommeJ < grille.GetLength(1) - 1)
                        BonhommeJ++;
                    break;
                case ConsoleKey.UpArrow:
                    if (BonhommeI > 0)
                        BonhommeI--;
                    break;
                case ConsoleKey.DownArrow:
                    if (BonhommeI < grille.GetLength(0) - 1)
                        BonhommeI++;
                    break;
            }
        } while (BonhommeI != ArriveeI || BonhommeJ != ArriveeJ);
    }
}





// --------------------------------------------------------------------------------------------------------------------------------------------


//Niveau 1 : Faire un tableau qui contient des prénoms et les afficher tous dans la console

//Niveau 2 : Faire une fonction qui prend en paramètre un tableau et renvoie la moyenne des valeurs

//Niveau 3 : Faire un jeu sur lequel on peut déplacer un personnage sur une grille