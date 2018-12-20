using System;
namespace Projet
{
    public class Player
    {
        public string NomPlayer;
        public Player()
        {
            Console.WriteLine("Bienvenu au jeu");
            Console.WriteLine("Veuillez entrer votre nom s'il vous plaît");
            string Nom = Console.ReadLine();
            Nom = NomPlayer;

            Console.Clear();
            Console.WriteLine("Bienvenu" + Nom);
            Console.WriteLine("Que l'aventure commence!");
        }
    }
}
