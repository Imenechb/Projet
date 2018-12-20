using System;
namespace Projet
{

        public class Map
        {
            public int Largeur;
            public int Longeur;
            public string Nom;
            public Case[,] Map;
            public int MaxMap;

            public Map(int largeur, int longueur)
            {
                Longeur = longueur;
                Largeur = largeur;
                Map = new Case[largeur, longueur];
                

                for (int i = 0; i < largeur; i++)
                {
                    for (int j = 0; j < longueur; j++)
                    {
                                        
                            Map[i, j] = new Case(i, j, Case.CaseType.Desert, "une case");
                       

                       Map[i, j] = new Case();

                    }
                }
            }

        }

}
