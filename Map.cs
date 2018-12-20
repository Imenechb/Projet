using System;
namespace Projet
{

        public class Map
        {
            public int Largeur;
            public int Longeur;
            public string Nom;
            public Case[,] Plateau;
            public int MaxPlateau;

            public Map(int largeur, int longueur)
            {
                Longeur = longueur;
                Largeur = largeur;
                Plateau = new Case[largeur, longueur];
                

                for (int i = 0; i < largeur; i++)
                {
                    for (int j = 0; j < longueur; j++)
                    {
                                        
                            Plateau[i, j] = new Case(i, j, Case.CaseType.Desert, "une case");
                       

                        Plateau[i, j] = new Case();

                    }
                }
            }

        }

}
